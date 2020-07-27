using Model;
using Server.Form_Event.Form_ManHinhChonCauHoi;
using Server.Model;
using Server.ReadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class serverConfetti : Form
    {

        #region Variable

        private delegate void SafeCallDelegate(string text);
        delegate void SetTextCallback(string text);

        private const int BUFFER_SIZE = 2048;

        private int kiemtralaplaikhithaydoicauhoi = 0;

        int count = 0;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        private string path = @"..\..\ReadFile\QuestionData.xml";

        NetworkStream networkStream = null;

        List<Player> ListPlayersConnecting = new List<Player>(); // Danh sách người chơi đã connect
        
        List<Question> ListQuestionData = new List<Question>();
        
        Question QuestionChoice = null;

        TcpListener ServerSocket = null;

        List<Question> ListQuestionsUsedTo = new List<Question>(); // Danh sách câu hỏi đã từng sử dụng

        bool SendQuestionButDontSendAnswer = false;

        #endregion

        #region InitializeComponent

        public serverConfetti()
        {
            InitializeComponent();
            LoadListQuestionData();
            StartServer();
            listviewPlayerConnected.Columns.Add("Họ tên người chơi", 100);
            listviewPlayerConnected.Columns.Add("Số câu đúng", 100);
        }

        #endregion

        #region Event
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadListPlayerConnect();
            lbCountListPlayerChange();
           
        }

        private void listviewQuestionData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SendQuestionButDontSendAnswer == true)
            {
                /*
                 * 3 cái if này dùng để không lặp lại thông báo lỗi
                 */
                if(kiemtralaplaikhithaydoicauhoi == 1)
                {
                    kiemtralaplaikhithaydoicauhoi++;
                    return;
                }
                if(kiemtralaplaikhithaydoicauhoi > 1)
                {
                    MessageBox.Show("Hiện tại bạn không thể chuyển câu hỏi . Xin hãy gửi câu trả lời rồi mới chuyển câu hỏi",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    kiemtralaplaikhithaydoicauhoi = 1;
                    return;
                }
                if(kiemtralaplaikhithaydoicauhoi == 0)
                {
                    MessageBox.Show("Hiện tại bạn không thể chuyển câu hỏi . Xin hãy gửi câu trả lời rồi mới chuyển câu hỏi",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    kiemtralaplaikhithaydoicauhoi++;
                    return;
                }
            }
            int IDquestion = -1;

            ListView.SelectedListViewItemCollection selectItem = this.listviewQuestionData.SelectedItems;

            if (selectItem.Count == 0)
            {
                return;
            }

            foreach (ListViewItem item in selectItem)
            {
                if (!int.TryParse(item.SubItems[0].Text, out IDquestion))
                {

                    MessageBox.Show("Định dạng bị sai . Xin kiểm tra câu hỏi lại",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                }

                QuestionChoice = Question.FindQuestion(ListQuestionData, IDquestion);

                if (QuestionChoice == null)
                {

                    MessageBox.Show("Không thể tìm thấy câu hỏi",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                }
            }

            txtIDQuestion.Text = QuestionChoice.ID.ToString();
            txtContentQuesttion.Text = QuestionChoice._contentQuestion;
            txtAnswerA.Text = QuestionChoice._a_Answer;
            txtAnswerB.Text = QuestionChoice._b_Answer;
            txtAnswerC.Text = QuestionChoice._c_Answer;
            txtRightQuestion.Text = QuestionChoice.RightAnswer;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddOneQuestion addOneQuestion = new AddOneQuestion();
            addOneQuestion.ShowDialog();

            LoadListQuestionData();
        }
        
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            DeleteMutiQuestion deleteMutiQuestion = new DeleteMutiQuestion(QuestionChoice);
            deleteMutiQuestion.ShowDialog();

            LoadListQuestionData();
        }

        private void serverConfetti_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn kết thúc phần game hay không",
                                        "Thông báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (dialogResult == DialogResult.Yes)
            {
                if (ServerSocket != null)
                {
                    ServerSocket.Stop();
                }
            }
        }

        private void serverConfetti_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if(SendQuestionButDontSendAnswer == false)
            {
                MessageBox.Show("Bạn chưa gửi câu hỏi để có thể gửi câu trả lời . Xin hãy gửi câu hỏi",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            byte[] bytes = new byte[2048];
            bytes = encoding.GetBytes(QuestionChoice.RightAnswer);
            
            foreach(Player player in ListPlayersConnecting)
            {
                try
                {
                    player.tcpClient.Send(bytes);
                }
                catch
                {
                    MessageBox.Show("Không thể gửi câu trả lời cho người chơi có tên : " + player._namePlayer,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            SendQuestionButDontSendAnswer = false;
            kiemtralaplaikhithaydoicauhoi = 0;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if(ListQuestionsUsedTo.Count == 10)
            {
                MessageBox.Show("Đã đủ 10 câu hỏi . Xin không bấm gửi câu hỏi nữa",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if(ListPlayersConnecting.Count == 0)
            {
                MessageBox.Show("Chưa có người chơi để bắt đầu . Xin đợi người chơi để bất đầu",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if(SendQuestionButDontSendAnswer == true)
            {
                MessageBox.Show("Bạn đã gửi câu hỏi nhưng chưa gửi câu trả lời . Xin gửi câu trả lời rồi mới bấm gửi câu hỏi khác",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtIDQuestion.Text))
            {
                MessageBox.Show("Bạn phải chọn câu hỏi . Xin chọn câu hỏi trước khi gửi câu hỏi",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            foreach (Question question in ListQuestionsUsedTo)
            {
                /* Check the question has been used or not . If question has been used is return */
                if (question.ID == QuestionChoice.ID)
                {
                    MessageBox.Show("Bạn đã sử dụng câu hỏi này rồi . Xin mời chọn câu hỏi khác",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                }
            }

            byte[] bytes = new byte[2048*500];

            Question tempQuestion = new Question(QuestionChoice.ID,
                                                 QuestionChoice._contentQuestion,
                                                 QuestionChoice._a_Answer,
                                                 QuestionChoice._b_Answer,
                                                 QuestionChoice._c_Answer);

            bytes = Utils.ObjectToByteArray(tempQuestion);

            foreach (Player player in ListPlayersConnecting)
            {
                try
                {
                    player.tcpClient.Send(bytes);
                }
                catch
                {
                    MessageBox.Show("Không thể gửi câu hỏi cho người chơi có tên : " + player._namePlayer,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            ListQuestionsUsedTo.Add(QuestionChoice);
            SendQuestionButDontSendAnswer = true;
        }

        #endregion

        #region Function

        private void ChangeCountLabelPlayer(string text)
        {
            if (this.lbCountListPlayer.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(ChangeCountLabelPlayer);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.lbCountListPlayer.Text = count.ToString(); ;

            }
        }


        private void StartServer()
        {
            try
            {
                int PORT = int.Parse(txtPORT.Text);
                IPAddress address = IPAddress.Parse(txtIP.Text);
                
                ServerSocket = new TcpListener(address, PORT);
            }
            catch
            {
                MessageBox.Show("Lỗi . Không thể khởi động server ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelConnect.Text = "Start server success"; 
            ServerSocket.Start();
            Thread thread = new Thread(clientConnectServer);
            thread.Start();

        }

        private void LoadListPlayerConnect()
        {

            if (ListPlayersConnecting.Count == 0)
            {
                return;
            }

            if (listviewPlayerConnected.InvokeRequired)
            {
                
                listviewPlayerConnected.Invoke((MethodInvoker)delegate ()
                {
                        string[] row = { ListPlayersConnecting.ElementAt(count)._namePlayer, ListPlayersConnecting.ElementAt(count).CountTrueQuestion.ToString() + "/" + "10" };
                        ListViewItem item = new ListViewItem(row);
                        listviewPlayerConnected.Items.Add(item);
                        listviewPlayerConnected.EnsureVisible(listviewPlayerConnected.Items.Count - 1);
                });
            }




        }
        
        private void lbCountListPlayerChange()
        {

            if (ListPlayersConnecting.Count <= 0)
            {
                return;
            }
            else
            {
                lbCountListPlayer.Text = ListPlayersConnecting.Count.ToString();
            }
        }
        
        private void LoadListQuestionData()
        {
            /*
             * Hiển thị danh sách các câu hỏi có trong file
             */
            listviewQuestionData.Clear();

            listviewQuestionData.Columns.Add("ID", 50);
            listviewQuestionData.Columns.Add("Nội dung câu hỏi", 400);
            listviewQuestionData.Columns.Add("Câu A", 150);
            listviewQuestionData.Columns.Add("Câu B", 150);
            listviewQuestionData.Columns.Add("Câu C", 150);
            listviewQuestionData.Columns.Add("Câu đúng", 70);

            ListQuestionData = ReadFile.ReadFile.LoadQuestionData(path);//Read file QuestionData.xml

            if (ListQuestionData == null)
            {
                return;
            }

            for (int INDEX = 0; INDEX < ListQuestionData.Count; INDEX++)
            {

                Question questionIndex = ListQuestionData.ElementAt(INDEX);

                listviewQuestionData.Items.Add(questionIndex.ID.ToString());
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._contentQuestion);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._a_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._b_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._c_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex.RightAnswer);

            }
        }
        #endregion

        #region Function_Thread

        private void clientConnectServer()
        {
            byte[] bytes = new byte[1024];
            try
            {
                while (true)
                {
                    MessageBox.Show(count.ToString()); // Đếm số lượng acc count
                    
                    Socket client = ServerSocket.AcceptSocket();
                    
                    string CodePlayer = "abc";

                    client.Receive(bytes);
                    string name = encoding.GetString(bytes);
                    

                    Player player = new Player(count + 1, CodePlayer, name, client); // Khởi tạo người chơi
                    ListPlayersConnecting.Add(player); // Thêm người chơi vào List
                    LoadListPlayerConnect();
                    count++;
                    this.ChangeCountLabelPlayer(count.ToString());
                    

                }
            }
            catch
            {
                return;
            }
                
            
        }

        private void WriteTextSafe(string text)
        {
            if (listviewPlayerConnected.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                listviewPlayerConnected.Invoke(d, new object[] { text });
            }
            else
            {
                LoadListPlayerConnect();
            }
        }

        #endregion

    }
}


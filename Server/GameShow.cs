﻿using Model;
using Server.Form_Event.Form_ManHinhChonCauHoi;
using Server.Model;
using Server.ReadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using AForge.Video;
using AForge.Video.DirectShow;



namespace Server
{
    public partial class serverConfetti : Form
    {
        #region Variable
        private delegate void SafeCallDelegate(string text);
        delegate void SetTextCallback(string text);
        delegate void ListViewDelegate(ListView list, string name, string value);

        private const int BUFFER_SIZE = 2048;

        private int kiemtralaplaikhithaydoicauhoi = 0;

        int count = 0;

        private string path = @"..\..\ReadFile\QuestionData.xml";

        private List<Player> ListPlayersConnecting = new List<Player>(); // Danh sách người chơi đã connect
        
        List<Question> ListQuestionData = new List<Question>();
        
        private Question QuestionChoice = null;

        private TcpListener ServerSocket = null;

        private UdpClient udpClient = null;

        private List<Question> ListQuestionsUsedTo = new List<Question>(); // Danh sách câu hỏi đã từng sử dụng

        bool SendQuestionButDontSendAnswer = false;


        /* người chơi cần biết số người chọn câu A , câu B , câu C */
        private int CountAnswerA = 0; // Dùng để đếm số người chọn câu A
        private int CountAnswerB = 0; // Dùng để đếm số người chọn câu B
        private int CountAnswerC = 0; // Dùng để đếm số người chọn câu C

        private FilterInfoCollection camera;
        private VideoCaptureDevice cam;

        public UdpClient UdpClient { get; private set; }

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

            LoadDanhSach();
            lbCountListPlayerChange();
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            LoadCam();
        }

        private void LoadCam()
        {
            try
            {
                if (cam != null && cam.IsRunning)
                {
                    cam.Stop();
                }
                cam = new VideoCaptureDevice(camera[0].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
            catch
            {
                return;
            }
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap resized = new Bitmap(bitmap, new Size(246, 469));
            pictureBox2.Image = resized;
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

            btnNextQuestion.Enabled = true;
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
                    if(cam != null)
                    {
                        cam.Stop();
                    }
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
            
            string answer = "as"+
                            "A"+CountAnswerA.ToString() +
                            "B"+CountAnswerB.ToString() +
                            "C"+CountAnswerC.ToString() + 
                            QuestionChoice.RightAnswer;
            
            bytes = Utils.ObjectToByteArray(answer);


            foreach(Player player in ListPlayersConnecting)
            {
                if (player.tcpClient.Connected)
                {
                    player.tcpClient.Send(bytes);
                }
            }

            SendQuestionButDontSendAnswer = false;
            kiemtralaplaikhithaydoicauhoi = 0;
            

            btnShowAnswer.Enabled = false;
            btnNextQuestion.Enabled = true;
            
            CountAnswerA = 0;
            CountAnswerB = 0;
            CountAnswerC = 0;
            
            /*
             * Gửi danh sách tên người chơi nào thắng cuộc cho toàn bộ người chơi 
             * Client nhận 1 chuỗi string chứ thông tin 
             * string : kqTen@Ten@
             * Example : có 2 tên người chơi có tên Abc và abc1 thắng cuộc =>> kqAbc@abc1@
             */

            if(ListQuestionsUsedTo.Count == 10)
            {

                string DanhSachNguoiChoiThang = "kq";
                byte[] bytess = new byte[2048];
                
                foreach (Player player in ListPlayersConnecting)
                {
                    if(player.CountTrueQuestion == 10)
                    {
                        DanhSachNguoiChoiThang += player._namePlayer + "@"+player._iDPlayer.ToString()+"@";
                    }
                }

                bytess = Utils.ObjectToByteArray(DanhSachNguoiChoiThang);
                
                foreach (Player player in ListPlayersConnecting)
                {
                    if (player.tcpClient.Connected)
                    {
                        player.tcpClient.Send(bytess);
                    }
                }
            }
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            /* Kiem Tra */
            #region Check
            if (ListQuestionsUsedTo.Count == 10)
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

            DialogResult dialogResult = MessageBox.Show("Bạn chắc sử dụng câu hỏi này để gửi ?",
                                                        "Thông báo",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                return;
            }
            #endregion
            byte[] bytes = new byte[2048*500];

            Question tempQuestion = new Question(QuestionChoice.ID,
                                                 QuestionChoice._contentQuestion,
                                                 QuestionChoice._a_Answer,
                                                 QuestionChoice._b_Answer,
                                                 QuestionChoice._c_Answer);

            foreach (Player player in ListPlayersConnecting)
            {
                try
                {

                    string stringQuestion ="qs"+"id"+
                                            tempQuestion.ID.ToString()+
                                            tempQuestion._contentQuestion+
                                            "A@"+tempQuestion._a_Answer+
                                            "B@"+tempQuestion._b_Answer+
                                            "C@"+tempQuestion._c_Answer;
                    bytes = Utils.ObjectToByteArray(stringQuestion);
                    player.tcpClient.Send(bytes);
                }
                catch
                {
                }
            }

            ListQuestionsUsedTo.Add(QuestionChoice);
            ChangeCountLabelSumQuestion(ListQuestionsUsedTo.Count.ToString());
            
            foreach (Player player1 in ListPlayersConnecting)
            {
                if(!player1.tcpClient.Connected)
                {
                    continue;
                }

                Thread thread = new Thread(() => Receive(player1));
                thread.Start();
            }
            
            SendQuestionButDontSendAnswer = true;
            btnNextQuestion.Enabled = false;
            timerStop.Start();
            
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
        private void ChangeCountLabelSumQuestion(string text)
        {
            if (this.txtCauHoiCount.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(ChangeCountLabelSumQuestion);

                this.Invoke(d, new object[] { text });

            }
            else

            {

                this.txtCauHoiCount.Text = ListQuestionsUsedTo.Count.ToString(); ;

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

            try
            {
                //StartServerUDP();
            }
            catch
            {
                MessageBox.Show("Lỗi . Không thể khởi động server webcam", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            labelConnect.Text = "Start server success"; 
            ServerSocket.Start();
            Thread thread = new Thread(clientConnectServer);
            thread.Start();
            
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
        private void StartServerUDP()
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 5000);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            UdpClient = new UdpClient(5000);
        }


        #endregion

        #region Function_Thread
        public static void InvokeClearListViewItems(ListView listView)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new MethodInvoker(delegate () { InvokeClearListViewItems(listView); }));
            }
            else
            {
                listView.Items.Clear();
            }
        }
        public void LoadDanhSach()
        {


            InvokeClearListViewItems(listviewPlayerConnected);
            foreach (Player player in ListPlayersConnecting)
            {
                AddListViewData(listviewPlayerConnected, player._namePlayer, player.CountTrueQuestion.ToString());
            }
        }
        private void timerStop_Tick(object sender, EventArgs e)
        {
            btnShowAnswer.Enabled = true;
            timerStop.Stop();
        }
        private void clientConnectServer()
        {
            try
            {
                while (true)
                {
                    Socket client = ServerSocket.AcceptSocket();
                    Thread thread = new Thread(() => SetName(client));
                    thread.Start();
                }
            }
            catch
            {
                return;
            }
        }
        private void clientConnectServerUDP()
        {
            //int recv;
            //byte[] data = new byte[1024];
            //Console.WriteLine("Dang cho Client ket noi den...");
            //IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            //EndPoint Remote = (EndPoint)(sender);
            ////recv = newsock.ReceiveFrom(data, ref Remote);
            //Console.WriteLine("Thong diep duoc nhan tu {0}:", Remote.ToString());
            //Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            //string welcome = "Hello Client";
            //data = Encoding.ASCII.GetBytes(welcome);
            ////.SendTo(data, data.Length, SocketFlags.None, Remote);
        }
        private void SetName(Socket client)
        {
            string CodePlayer = "abc";
            byte[] bytes = new byte[1024];
            client.Receive(bytes);

            string name = Utils.ByteArrayToObject(bytes);
            foreach(Player playerConnecting in ListPlayersConnecting)
            {

                /*
                 * Kiểm tra player có tồn tại hay không 
                 * Bước 1 . Gửi 1 yêu cầu cho client để xác nhận đã trùng tên
                 * Bước 2 . Client gửi lại 1 mã chứa id
                 * Bước 3 . Nếu mã đó đã tồn tại thì gán lại
                 * Bước 4 . Nếu không tồn tại thì tạo ra player mới
                 */

                string abc = "11asdxzcvda";
                bytes = Utils.ObjectToByteArray(abc);
                if(name == playerConnecting._namePlayer)
                {
                    try
                    {
                        playerConnecting.tcpClient.Send(bytes);
                    }
                    catch
                    {
                        bytes = Utils.ObjectToByteArray("ycid");

                        client.Send(bytes);

                        client.Receive(bytes);

                        try
                        {
                            int idName = int.Parse(Utils.ByteArrayToObject(bytes));
                            if (idName == playerConnecting._iDPlayer)
                            {
                                playerConnecting.tcpClient = client;

                                string reId = "reid" + playerConnecting._iDPlayer.ToString()+"qs"+ListQuestionsUsedTo.Count.ToString()+"kq"+playerConnecting.CountTrueQuestion.ToString();

                                bytes = Utils.ObjectToByteArray(reId);
                                client.Send(bytes);

                                return;
                            }
                            else
                            {
                                CreateNewPlayer(count + 1, CodePlayer, name, client);
                                return;
                            }
                        }
                        catch
                        {

                        }
                    }


                    
                }
            }

            CreateNewPlayer(count + 1, CodePlayer, name, client); // Khởi tạo người chơi



        }

        public void CreateNewPlayer(int id,string _Coloder,string _name,Socket client)
        {
            try
            {
                byte[] bytes = new byte[1024];
                Player player = new Player(id, _Coloder, _name, client);
                ListPlayersConnecting.Add(player); // Thêm người chơi vào List

                bytes = Utils.ObjectToByteArray("id" + player._iDPlayer.ToString());

                client.Send(bytes);

                LoadDanhSach();
                count++;
                this.ChangeCountLabelPlayer(count.ToString());
            }
            catch
            {
                MessageBox.Show("Không thế tạo người chơi mới .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AddListViewData(ListView list, string name,string value)
        {
            if (list.InvokeRequired)
            {
                var d = new ListViewDelegate(AddListViewData);
                list.Invoke(d, new object[] { list, name,value });
            }
            else
            {
                list.BeginUpdate();
                string[] row = { name, value + "/" + "10" };
                ListViewItem item = new ListViewItem(row);
                list.Items.Add(item);
                list.EnsureVisible(list.Items.Count - 1);
                list.EndUpdate();

            }
        }
        private void Receive(Player client)
        {
            byte[] bytes = new byte[1024];
            client.tcpClient.Receive(bytes);
            string answer = Utils.ByteArrayToObject(bytes).Substring(0,1);
            if(answer == "A")
            {
                CountAnswerA++;
            }    
            if(answer == "C")
            {
                CountAnswerC++;
            }
            if(answer == "B")
            {
                CountAnswerB++;
            }
            if(answer == QuestionChoice.RightAnswer)
            {
                client.CountTrueQuestion++;
            }
            LoadDanhSach();
        }
        #endregion
    }
}


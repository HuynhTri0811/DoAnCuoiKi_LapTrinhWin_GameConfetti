using Model;
using Server.Form_Event.Form_ManHinhChonCauHoi;
using Server.Model;
using Server.ReadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class serverConfetti : Form
    {

        #region Variable

        private string path = @"..\..\ReadFile\QuestionData.xml";
        
        List<Player> ListPlayersConnecting = new List<Player>();
        
        List<Question> questionsData = new List<Question>();
        
        List<Question> ListQuestionData = new List<Question>();
        
        Question questionChoice = null;

        TcpListener ServerSocket = null;

        #endregion

        #region InitializeComponent

        public serverConfetti()
        {
            InitializeComponent();
            LoadListQuestionData();
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

                questionChoice = Question.FindQuestion(ListQuestionData, IDquestion);

                if (questionChoice == null)
                {

                    MessageBox.Show("Không thể tìm thấy câu hỏi",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                }
            }

            txtIDQuestion.Text = questionChoice.ID.ToString();
            txtContentQuesttion.Text = questionChoice._contentQuestion;
            txtAnswerA.Text = questionChoice._a_Answer;
            txtAnswerB.Text = questionChoice._b_Answer;
            txtAnswerC.Text = questionChoice._c_Answer;
            txtRightQuestion.Text = questionChoice.RightAnswer;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddOneQuestion addOneQuestion = new AddOneQuestion();
            addOneQuestion.ShowDialog();

            LoadListQuestionData();
        }
        
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            DeleteMutiQuestion deleteMutiQuestion = new DeleteMutiQuestion(questionChoice);
            deleteMutiQuestion.ShowDialog();

            LoadListQuestionData();
        }
        
        #endregion

        #region Function
        
        private void StartServer()
        {
            try
            {
                IPAddress address = IPAddress.Parse(txtIP.Text);
                ServerSocket = new TcpListener(IPAddress.Any, 5000);
            }
            catch
            {

            }
        }

        private void LoadListPlayerConnect()
        {

            if (ListPlayersConnecting.Count == 0)
            {
                return;
            }

            listviewPlayerConnected.Columns.Add("Họ tên người chơi", 100);
            listviewPlayerConnected.Columns.Add("Số câu đúng", 70);

            for (int i = 0; i < ListPlayersConnecting.Count; i++)
            {

                string[] row = { ListPlayersConnecting.ElementAt(0)._namePlayer, "/" + "10" };

                var listViewItem = new ListViewItem(row);

                listviewPlayerConnected.Items.Add(listViewItem);
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

    }
}

using Server.Form_Event.Form_ManHinhChonCauHoi;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerStartAndChoiceQuestion : Form
    {
        #region Variable
        private string path = @"..\..\ReadFile\QuestionData.xml";
        List<Question> ListQuestionData = new List<Question>();
        #endregion

        #region InitializeComponent
        public ServerStartAndChoiceQuestion()
        {
            InitializeComponent();
            LoadListQuestionData();
        }
        #endregion

        #region Function
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
            listviewQuestionData.Columns.Add("Câu D", 150);
            listviewQuestionData.Columns.Add("Câu đúng", 70);
            
            ListQuestionData = ReadFile.ReadFile.LoadQuestionData(path);
            
            if (ListQuestionData == null)
            {
                return;
            }

            for(int INDEX = 0 ; INDEX < ListQuestionData.Count ; INDEX++)
            {

                Question questionIndex = ListQuestionData.ElementAt(INDEX);

                listviewQuestionData.Items.Add(questionIndex.ID.ToString());
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._contentQuestion);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._a_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._b_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._c_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex._d_Answer);
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex.RightAnswer);
            }
        }
        #endregion

        #region Event
        private void btnStartServer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddOneQuestion addOneQuestion = new AddOneQuestion();
            addOneQuestion.ShowDialog();
            
            LoadListQuestionData();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}

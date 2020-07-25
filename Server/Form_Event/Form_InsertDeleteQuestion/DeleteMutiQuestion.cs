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
using Server.ReadFile;

namespace Server
{
    public partial class DeleteMutiQuestion : Form
    {
        #region Variable
        private string path = @"..\..\ReadFile\QuestionData.xml";
        List<Question> ListQuestionData;
        Question questionChoice;

        #endregion

        #region InitializeComponent
        public DeleteMutiQuestion(Question question)
        {
            this.questionChoice = question;

            InitializeComponent();
            LoadListQuestionData();

            MessageBox.Show("Danh sách câu hỏi sẽ không thể cập nhật cho đến khi bạn xóa xong câu hỏi và thoát mình hình thêm xóa câu hỏi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
                listviewQuestionData.Items[INDEX].SubItems.Add(questionIndex.RightAnswer);
            
            }
        }
        #endregion

        #region Event
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            bool CheckDelete = true;
            DialogResult dialogResult;
            Question question = new Question();


            dialogResult = MessageBox.Show("Bạn có chắc muốn xóa những câu hỏi này ?",
                                           "Thông báo",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            
            if(dialogResult == DialogResult.No)
            {
                return;
            }

            if(listviewQuestionData.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn câu hỏi để xóa",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            for (int i=0; i < listviewQuestionData.CheckedIndices.Count; i++)
            {
                question = ListQuestionData.ElementAt(listviewQuestionData.CheckedIndices[i]);

                if(questionChoice != null)
                {
                    if (question.ID == questionChoice.ID)
                    {
                        MessageBox.Show("Xóa câu hỏi có ID la " + listviewQuestionData.CheckedIndices[i].ToString() + "KHÔNG THÀNH CÔNG . Vì câu hỏi bạn chọn hiện đang có trên chi tiết câu hỏi",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                        CheckDelete = false;
                        continue;
                    }
                }

                

                if(!WriteFile.DeleteQuestion(path,question))
                {

                    MessageBox.Show("Xóa câu hỏi có ID la "+ listviewQuestionData.CheckedIndices[i].ToString()+"KHÔNG THÀNH CÔNG",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    
                    CheckDelete = false;
                }    
                
            }
            if(CheckDelete == true)
            {

                MessageBox.Show("Đã xóa toàn bộ câu hỏi mà bạn đã chọn",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Đã Xóa Những Câu Hỏi Không Bị Lỗi Mà Bạn Đã Chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            LoadListQuestionData();
        }
        #endregion

        
    }
}

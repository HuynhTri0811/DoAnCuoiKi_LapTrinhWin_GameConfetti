using Model;
using Server.ReadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Form_Event.Form_ManHinhChonCauHoi
{
    public partial class AddOneQuestion : Form
    {
        #region Varibale
        private string path = @"..\..\ReadFile\QuestionData.xml";
        #endregion

        #region InitializeComponent
        public AddOneQuestion()
        {
            InitializeComponent();
            
            LoadComboBoxAnswerRightAnswer();
            
            MessageBox.Show("Danh sách câu hỏi sẽ không thể cập nhật cho đến khi bạn đã tạo xong câu hỏi và thoát mình hình thêm câu hỏi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region Function
        private void LoadComboBoxAnswerRightAnswer()
        {
            string[] listAnswer = {"A", "B", "C"};

            comboBoxRightAnswer.Items.AddRange(listAnswer);
            
            comboBoxRightAnswer.SelectedIndex = 0;

            
        }
        #endregion

        #region Event
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo câu hỏi này hay không ?",
                                                        "Thông báo",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                return;
            }

            foreach(Control textBox in this.Controls)
            {
                if(textBox is TextBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {

                        MessageBox.Show("Bạn đã để trống ô " + textBox.Name + " . Xin mời nhập lại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        textBox.Focus();
                        
                        return;
                    
                    }
                }
            }

            if(comboBoxRightAnswer.Text == "A" || comboBoxRightAnswer.Text =="B" || comboBoxRightAnswer.Text =="C") 
            {
                
                Question question = new Question(
                    ReadFile.ReadFile.GetQuestionLast(path).ID + 1, // Get ID last question
                    txtContentQuestion.Text,
                    txtAnswerA.Text,
                    txtAnswerB.Text,
                    txtAnswerC.Text,
                    comboBoxRightAnswer.Text    );

                if (WriteFile.AddQuestion(path, question))
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất baị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("BẠN ĐÃ CHỌN CÂU TRẢ LỜI KHÔNG ĐƯỢC KHÁC 'A' hoặc 'B' hoặc 'C'",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion

        
    }
}

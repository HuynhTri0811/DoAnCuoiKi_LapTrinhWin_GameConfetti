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
        }
        #endregion

        #region Function
        private void LoadComboBoxAnswerRightAnswer()
        {
            string[] listAnswer = {"A", "B", "C", "D"};

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

            if(comboBoxRightAnswer.Text == "A" || comboBoxRightAnswer.Text =="B" || comboBoxRightAnswer.Text =="C" || comboBoxRightAnswer.Text == "D") 
            {
                
                Question question = new Question(
                    ReadFile.ReadFile.LoadQuestionData(path).Count + 1,
                    txtContentQuestion.Text,
                    txtAnswerA.Text,
                    txtAnswerB.Text,
                    txtAnswerC.Text,
                    txtAnswerD.Text,
                    comboBoxRightAnswer.Text    );

                if (WriteFile.AddQuestion(path, question))
                {
                    MessageBox.Show("THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("BẠN ĐÃ CHỌN CÂU TRẢ LỜI KHÔNG ĐƯỢC KHÁC 'A' hoặc 'B' hoặc 'C' hoặc 'D' ","LỖI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}

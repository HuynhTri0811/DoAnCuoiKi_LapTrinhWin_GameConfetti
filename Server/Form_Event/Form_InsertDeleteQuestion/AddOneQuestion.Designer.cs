namespace Server.Form_Event.Form_ManHinhChonCauHoi
{
    partial class AddOneQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContentQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.comboBoxRightAnswer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm câu hỏi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung câu hỏi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Câu A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Câu B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Câu C:";
            // 
            // txtContentQuestion
            // 
            this.txtContentQuestion.Location = new System.Drawing.Point(112, 54);
            this.txtContentQuestion.Multiline = true;
            this.txtContentQuestion.Name = "txtContentQuestion";
            this.txtContentQuestion.Size = new System.Drawing.Size(239, 86);
            this.txtContentQuestion.TabIndex = 6;
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Location = new System.Drawing.Point(112, 146);
            this.txtAnswerA.Multiline = true;
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(239, 50);
            this.txtAnswerA.TabIndex = 7;
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Location = new System.Drawing.Point(112, 202);
            this.txtAnswerB.Multiline = true;
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(239, 50);
            this.txtAnswerB.TabIndex = 8;
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Location = new System.Drawing.Point(112, 258);
            this.txtAnswerC.Multiline = true;
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(239, 50);
            this.txtAnswerC.TabIndex = 9;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(113, 382);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(239, 51);
            this.btnAddQuestion.TabIndex = 11;
            this.btnAddQuestion.Text = "Thêm câu hỏi ";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // comboBoxRightAnswer
            // 
            this.comboBoxRightAnswer.FormattingEnabled = true;
            this.comboBoxRightAnswer.Location = new System.Drawing.Point(113, 331);
            this.comboBoxRightAnswer.Name = "comboBoxRightAnswer";
            this.comboBoxRightAnswer.Size = new System.Drawing.Size(239, 21);
            this.comboBoxRightAnswer.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Câu đúng :";
            // 
            // AddOneQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 454);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxRightAnswer);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.txtAnswerA);
            this.Controls.Add(this.txtContentQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOneQuestion";
            this.Text = "Thêm câu hỏi ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContentQuestion;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ComboBox comboBoxRightAnswer;
        private System.Windows.Forms.Label label7;
    }
}
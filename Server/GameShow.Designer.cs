namespace Server
{
    partial class serverConfetti
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
            this.components = new System.ComponentModel.Container();
            this.listviewPlayerConnected = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountListPlayer = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.Stream = new System.Windows.Forms.GroupBox();
            this.labelConnect = new System.Windows.Forms.Label();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCauHoiCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRightQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtContentQuesttion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listviewQuestionData = new System.Windows.Forms.ListView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Stream.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewPlayerConnected
            // 
            this.listviewPlayerConnected.HideSelection = false;
            this.listviewPlayerConnected.Location = new System.Drawing.Point(6, 44);
            this.listviewPlayerConnected.Name = "listviewPlayerConnected";
            this.listviewPlayerConnected.Size = new System.Drawing.Size(252, 354);
            this.listviewPlayerConnected.TabIndex = 0;
            this.listviewPlayerConnected.UseCompatibleStateImageBehavior = false;
            this.listviewPlayerConnected.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số người chơi :";
            // 
            // lbCountListPlayer
            // 
            this.lbCountListPlayer.AutoSize = true;
            this.lbCountListPlayer.Location = new System.Drawing.Point(128, 28);
            this.lbCountListPlayer.Name = "lbCountListPlayer";
            this.lbCountListPlayer.Size = new System.Drawing.Size(13, 13);
            this.lbCountListPlayer.TabIndex = 2;
            this.lbCountListPlayer.Text = "0";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Location = new System.Drawing.Point(403, 428);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(135, 36);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.Text = "Gửi câu hỏi ";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // Stream
            // 
            this.Stream.Controls.Add(this.pictureBox2);
            this.Stream.Controls.Add(this.labelConnect);
            this.Stream.Controls.Add(this.btnShowAnswer);
            this.Stream.Controls.Add(this.groupBox3);
            this.Stream.Controls.Add(this.txtPORT);
            this.Stream.Controls.Add(this.label10);
            this.Stream.Controls.Add(this.label9);
            this.Stream.Controls.Add(this.txtIP);
            this.Stream.Controls.Add(this.btnNextQuestion);
            this.Stream.Location = new System.Drawing.Point(12, 12);
            this.Stream.Name = "Stream";
            this.Stream.Size = new System.Drawing.Size(556, 531);
            this.Stream.TabIndex = 0;
            this.Stream.TabStop = false;
            this.Stream.Text = "Stream";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.Location = new System.Drawing.Point(408, 501);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(136, 20);
            this.labelConnect.TabIndex = 10;
            this.labelConnect.Text = "Don\'t Start Server";
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Enabled = false;
            this.btnShowAnswer.Location = new System.Drawing.Point(280, 428);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(117, 36);
            this.btnShowAnswer.TabIndex = 9;
            this.btnShowAnswer.Text = "Gửi câu trả lời ";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbCountListPlayer);
            this.groupBox3.Controls.Add(this.listviewPlayerConnected);
            this.groupBox3.Location = new System.Drawing.Point(280, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 406);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách người chơi ";
            // 
            // txtPORT
            // 
            this.txtPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPORT.Location = new System.Drawing.Point(284, 502);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.ReadOnly = true;
            this.txtPORT.Size = new System.Drawing.Size(113, 26);
            this.txtPORT.TabIndex = 1;
            this.txtPORT.Text = "3000";
            this.txtPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "PORT :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "IP :";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(44, 499);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(173, 26);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCauHoiCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIDQuestion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRightQuestion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAnswerC);
            this.groupBox1.Controls.Add(this.txtAnswerB);
            this.groupBox1.Controls.Add(this.txtAnswerA);
            this.groupBox1.Controls.Add(this.txtContentQuesttion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(574, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết câu hỏi";
            // 
            // txtCauHoiCount
            // 
            this.txtCauHoiCount.AutoSize = true;
            this.txtCauHoiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoiCount.Location = new System.Drawing.Point(105, 490);
            this.txtCauHoiCount.Name = "txtCauHoiCount";
            this.txtCauHoiCount.Size = new System.Drawing.Size(18, 20);
            this.txtCauHoiCount.TabIndex = 11;
            this.txtCauHoiCount.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Câu hỏi số : ";
            // 
            // txtIDQuestion
            // 
            this.txtIDQuestion.Enabled = false;
            this.txtIDQuestion.Location = new System.Drawing.Point(78, 454);
            this.txtIDQuestion.Multiline = true;
            this.txtIDQuestion.Name = "txtIDQuestion";
            this.txtIDQuestion.Size = new System.Drawing.Size(195, 24);
            this.txtIDQuestion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Câu Hỏi :";
            // 
            // txtRightQuestion
            // 
            this.txtRightQuestion.Enabled = false;
            this.txtRightQuestion.Location = new System.Drawing.Point(78, 424);
            this.txtRightQuestion.Multiline = true;
            this.txtRightQuestion.Name = "txtRightQuestion";
            this.txtRightQuestion.Size = new System.Drawing.Size(195, 24);
            this.txtRightQuestion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Câu Đúng :";
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Enabled = false;
            this.txtAnswerC.Location = new System.Drawing.Point(78, 342);
            this.txtAnswerC.Multiline = true;
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(195, 71);
            this.txtAnswerC.TabIndex = 8;
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Enabled = false;
            this.txtAnswerB.Location = new System.Drawing.Point(78, 265);
            this.txtAnswerB.Multiline = true;
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(195, 71);
            this.txtAnswerB.TabIndex = 7;
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Enabled = false;
            this.txtAnswerA.Location = new System.Drawing.Point(78, 188);
            this.txtAnswerA.Multiline = true;
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(195, 71);
            this.txtAnswerA.TabIndex = 6;
            // 
            // txtContentQuesttion
            // 
            this.txtContentQuesttion.Enabled = false;
            this.txtContentQuesttion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContentQuesttion.Location = new System.Drawing.Point(78, 29);
            this.txtContentQuesttion.Multiline = true;
            this.txtContentQuesttion.Name = "txtContentQuesttion";
            this.txtContentQuesttion.Size = new System.Drawing.Size(195, 153);
            this.txtContentQuesttion.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Câu C :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Câu B :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Câu A :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung :";
            // 
            // listviewQuestionData
            // 
            this.listviewQuestionData.HideSelection = false;
            this.listviewQuestionData.Location = new System.Drawing.Point(880, 16);
            this.listviewQuestionData.Name = "listviewQuestionData";
            this.listviewQuestionData.Size = new System.Drawing.Size(420, 484);
            this.listviewQuestionData.TabIndex = 1;
            this.listviewQuestionData.UseCompatibleStateImageBehavior = false;
            this.listviewQuestionData.View = System.Windows.Forms.View.Details;
            this.listviewQuestionData.SelectedIndexChanged += new System.EventHandler(this.listviewQuestionData_SelectedIndexChanged);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(880, 506);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(204, 37);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Thêm câu hỏi ";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(1113, 506);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(187, 37);
            this.btnDeleteQuestion.TabIndex = 3;
            this.btnDeleteQuestion.Text = "Xóa câu hỏi ";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // timerStop
            // 
            this.timerStop.Interval = 15000;
            this.timerStop.Tick += new System.EventHandler(this.timerStop_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 469);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // serverConfetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.listviewQuestionData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Stream);
            this.Name = "serverConfetti";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serverConfetti_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.serverConfetti_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Stream.ResumeLayout(false);
            this.Stream.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewPlayerConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountListPlayer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox Stream;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtContentQuesttion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.TextBox txtRightQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listviewQuestionData;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Timer timerStop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtCauHoiCount;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


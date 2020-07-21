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
            this.listviewPlayerConnected = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountListPlayer = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pnaelStream = new System.Windows.Forms.Panel();
            this.comboxLoadIDCauHoi = new System.Windows.Forms.ComboBox();
            this.Stream = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Stream.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewPlayerConnected
            // 
            this.listviewPlayerConnected.HideSelection = false;
            this.listviewPlayerConnected.Location = new System.Drawing.Point(1081, 59);
            this.listviewPlayerConnected.Name = "listviewPlayerConnected";
            this.listviewPlayerConnected.Size = new System.Drawing.Size(200, 488);
            this.listviewPlayerConnected.TabIndex = 0;
            this.listviewPlayerConnected.UseCompatibleStateImageBehavior = false;
            this.listviewPlayerConnected.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số người chơi :";
            // 
            // lbCountListPlayer
            // 
            this.lbCountListPlayer.AutoSize = true;
            this.lbCountListPlayer.Location = new System.Drawing.Point(1248, 43);
            this.lbCountListPlayer.Name = "lbCountListPlayer";
            this.lbCountListPlayer.Size = new System.Drawing.Size(13, 13);
            this.lbCountListPlayer.TabIndex = 2;
            this.lbCountListPlayer.Text = "0";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(682, 493);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(96, 36);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // pnaelStream
            // 
            this.pnaelStream.Location = new System.Drawing.Point(6, 19);
            this.pnaelStream.Name = "pnaelStream";
            this.pnaelStream.Size = new System.Drawing.Size(772, 468);
            this.pnaelStream.TabIndex = 5;
            // 
            // comboxLoadIDCauHoi
            // 
            this.comboxLoadIDCauHoi.FormattingEnabled = true;
            this.comboxLoadIDCauHoi.Location = new System.Drawing.Point(78, 30);
            this.comboxLoadIDCauHoi.Name = "comboxLoadIDCauHoi";
            this.comboxLoadIDCauHoi.Size = new System.Drawing.Size(195, 21);
            this.comboxLoadIDCauHoi.TabIndex = 0;
            // 
            // Stream
            // 
            this.Stream.Controls.Add(this.txtPORT);
            this.Stream.Controls.Add(this.label10);
            this.Stream.Controls.Add(this.label9);
            this.Stream.Controls.Add(this.txtIP);
            this.Stream.Controls.Add(this.pnaelStream);
            this.Stream.Controls.Add(this.btnNextQuestion);
            this.Stream.Location = new System.Drawing.Point(12, 12);
            this.Stream.Name = "Stream";
            this.Stream.Size = new System.Drawing.Size(784, 535);
            this.Stream.TabIndex = 0;
            this.Stream.TabStop = false;
            this.Stream.Text = "Stream";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã câu hỏi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết câu hỏi";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "A :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "B :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "C :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "D :";
            // 
            // txtPORT
            // 
            this.txtPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPORT.Location = new System.Drawing.Point(301, 499);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.ReadOnly = true;
            this.txtPORT.Size = new System.Drawing.Size(113, 26);
            this.txtPORT.TabIndex = 1;
            this.txtPORT.Text = "3000";
            this.txtPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(44, 502);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(173, 26);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "PORT :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboxLoadIDCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(802, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 526);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 104);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 71);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 227);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 71);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 304);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 71);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 381);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 71);
            this.textBox5.TabIndex = 9;
            // 
            // serverConfetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Stream);
            this.Controls.Add(this.lbCountListPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listviewPlayerConnected);
            this.Name = "serverConfetti";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Stream.ResumeLayout(false);
            this.Stream.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewPlayerConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountListPlayer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Panel pnaelStream;
        private System.Windows.Forms.GroupBox Stream;
        private System.Windows.Forms.ComboBox comboxLoadIDCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


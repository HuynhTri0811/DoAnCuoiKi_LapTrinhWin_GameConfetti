﻿namespace Client
{
    partial class ClientMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbNameClient = new System.Windows.Forms.Label();
            this.tooltipShowTitle = new System.Windows.Forms.ToolTip(this.components);
            this.timeChooseAnswer = new System.Windows.Forms.Timer(this.components);
            this.pictureboxMain = new System.Windows.Forms.PictureBox();
            this.tplpnAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.picboxAnswer3 = new System.Windows.Forms.PictureBox();
            this.picboxAnswer2 = new System.Windows.Forms.PictureBox();
            this.picboxAnswer1 = new System.Windows.Forms.PictureBox();
            this.pnQuestion = new System.Windows.Forms.Panel();
            this.lbIdPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumberASTrue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumberQuestion = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.tblpnQuestion = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).BeginInit();
            this.tplpnAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer1)).BeginInit();
            this.tblpnQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(555, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // lbNameClient
            // 
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClient.ForeColor = System.Drawing.Color.White;
            this.lbNameClient.Location = new System.Drawing.Point(12, 9);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(163, 31);
            this.lbNameClient.TabIndex = 3;
            this.lbNameClient.Text = "Name Client";
            this.lbNameClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseDown);
            this.lbNameClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseMove);
            this.lbNameClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseUp);
            // 
            // timeChooseAnswer
            // 
            this.timeChooseAnswer.Interval = 1000;
            this.timeChooseAnswer.Tick += new System.EventHandler(this.timeChooseAnswer_Tick);
            // 
            // pictureboxMain
            // 
            this.pictureboxMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureboxMain.Location = new System.Drawing.Point(0, 50);
            this.pictureboxMain.Name = "pictureboxMain";
            this.pictureboxMain.Size = new System.Drawing.Size(600, 470);
            this.pictureboxMain.TabIndex = 4;
            this.pictureboxMain.TabStop = false;
            // 
            // tplpnAnswer
            // 
            this.tplpnAnswer.ColumnCount = 3;
            this.tplpnAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplpnAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplpnAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplpnAnswer.Controls.Add(this.picboxAnswer3, 2, 0);
            this.tplpnAnswer.Controls.Add(this.picboxAnswer2, 1, 0);
            this.tplpnAnswer.Controls.Add(this.picboxAnswer1, 0, 0);
            this.tplpnAnswer.Location = new System.Drawing.Point(3, 92);
            this.tplpnAnswer.Name = "tplpnAnswer";
            this.tplpnAnswer.RowCount = 1;
            this.tplpnAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplpnAnswer.Size = new System.Drawing.Size(570, 83);
            this.tplpnAnswer.TabIndex = 0;
            // 
            // picboxAnswer3
            // 
            this.picboxAnswer3.BackColor = System.Drawing.Color.MidnightBlue;
            this.picboxAnswer3.Location = new System.Drawing.Point(383, 3);
            this.picboxAnswer3.Name = "picboxAnswer3";
            this.picboxAnswer3.Size = new System.Drawing.Size(180, 60);
            this.picboxAnswer3.TabIndex = 2;
            this.picboxAnswer3.TabStop = false;
            // 
            // picboxAnswer2
            // 
            this.picboxAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picboxAnswer2.BackColor = System.Drawing.Color.RoyalBlue;
            this.picboxAnswer2.Location = new System.Drawing.Point(195, 3);
            this.picboxAnswer2.Name = "picboxAnswer2";
            this.picboxAnswer2.Size = new System.Drawing.Size(180, 60);
            this.picboxAnswer2.TabIndex = 1;
            this.picboxAnswer2.TabStop = false;
            // 
            // picboxAnswer1
            // 
            this.picboxAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxAnswer1.BackColor = System.Drawing.Color.MediumOrchid;
            this.picboxAnswer1.Location = new System.Drawing.Point(7, 3);
            this.picboxAnswer1.Name = "picboxAnswer1";
            this.picboxAnswer1.Size = new System.Drawing.Size(180, 60);
            this.picboxAnswer1.TabIndex = 0;
            this.picboxAnswer1.TabStop = false;
            // 
            // pnQuestion
            // 
            this.pnQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnQuestion.Location = new System.Drawing.Point(63, 16);
            this.pnQuestion.Name = "pnQuestion";
            this.pnQuestion.Size = new System.Drawing.Size(450, 70);
            this.pnQuestion.TabIndex = 1;
            // 
            // lbIdPlayer
            // 
            this.lbIdPlayer.AllowDrop = true;
            this.lbIdPlayer.AutoSize = true;
            this.lbIdPlayer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbIdPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPlayer.Location = new System.Drawing.Point(561, 61);
            this.lbIdPlayer.Name = "lbIdPlayer";
            this.lbIdPlayer.Size = new System.Drawing.Size(17, 17);
            this.lbIdPlayer.TabIndex = 13;
            this.lbIdPlayer.Text = "0";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID của bạn:";
            // 
            // lbNumberASTrue
            // 
            this.lbNumberASTrue.AllowDrop = true;
            this.lbNumberASTrue.AutoSize = true;
            this.lbNumberASTrue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbNumberASTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberASTrue.Location = new System.Drawing.Point(81, 61);
            this.lbNumberASTrue.Name = "lbNumberASTrue";
            this.lbNumberASTrue.Size = new System.Drawing.Size(40, 17);
            this.lbNumberASTrue.TabIndex = 11;
            this.lbNumberASTrue.Text = "0/10";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Câu đúng:";
            // 
            // lbNumberQuestion
            // 
            this.lbNumberQuestion.AllowDrop = true;
            this.lbNumberQuestion.AutoSize = true;
            this.lbNumberQuestion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbNumberQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberQuestion.Location = new System.Drawing.Point(72, 310);
            this.lbNumberQuestion.Name = "lbNumberQuestion";
            this.lbNumberQuestion.Size = new System.Drawing.Size(50, 17);
            this.lbNumberQuestion.TabIndex = 9;
            this.lbNumberQuestion.Text = "Câu 1";
            // 
            // lbTime
            // 
            this.lbTime.AllowDrop = true;
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(464, 310);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(61, 17);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "15 giây";
            // 
            // tblpnQuestion
            // 
            this.tblpnQuestion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tblpnQuestion.ColumnCount = 1;
            this.tblpnQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnQuestion.Controls.Add(this.tplpnAnswer, 0, 1);
            this.tblpnQuestion.Controls.Add(this.pnQuestion, 0, 0);
            this.tblpnQuestion.Location = new System.Drawing.Point(12, 330);
            this.tblpnQuestion.Name = "tblpnQuestion";
            this.tblpnQuestion.RowCount = 2;
            this.tblpnQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnQuestion.Size = new System.Drawing.Size(576, 178);
            this.tblpnQuestion.TabIndex = 7;
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.lbIdPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNumberASTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumberQuestion);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tblpnQuestion);
            this.Controls.Add(this.pictureboxMain);
            this.Controls.Add(this.lbNameClient);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientMain_FormClosed);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).EndInit();
            this.tplpnAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnswer1)).EndInit();
            this.tblpnQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.ToolTip tooltipShowTitle;
        public System.Windows.Forms.Timer timeChooseAnswer;
        private System.Windows.Forms.PictureBox pictureboxMain;
        private System.Windows.Forms.TableLayoutPanel tplpnAnswer;
        private System.Windows.Forms.PictureBox picboxAnswer3;
        private System.Windows.Forms.PictureBox picboxAnswer2;
        private System.Windows.Forms.PictureBox picboxAnswer1;
        private System.Windows.Forms.Panel pnQuestion;
        private System.Windows.Forms.Label lbIdPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumberASTrue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumberQuestion;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TableLayoutPanel tblpnQuestion;
    }
}


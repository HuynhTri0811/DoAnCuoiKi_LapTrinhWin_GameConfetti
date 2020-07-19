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
            this.button1 = new System.Windows.Forms.Button();
            this.listViewListCauHoi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listviewPlayerConnected
            // 
            this.listviewPlayerConnected.HideSelection = false;
            this.listviewPlayerConnected.Location = new System.Drawing.Point(1014, 59);
            this.listviewPlayerConnected.Name = "listviewPlayerConnected";
            this.listviewPlayerConnected.Size = new System.Drawing.Size(267, 488);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewListCauHoi
            // 
            this.listViewListCauHoi.HideSelection = false;
            this.listViewListCauHoi.Location = new System.Drawing.Point(730, 59);
            this.listViewListCauHoi.Name = "listViewListCauHoi";
            this.listViewListCauHoi.Size = new System.Drawing.Size(279, 488);
            this.listViewListCauHoi.TabIndex = 4;
            this.listViewListCauHoi.UseCompatibleStateImageBehavior = false;
            this.listViewListCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // serverConfetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 559);
            this.Controls.Add(this.listViewListCauHoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCountListPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listviewPlayerConnected);
            this.Name = "serverConfetti";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewPlayerConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountListPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewListCauHoi;
    }
}


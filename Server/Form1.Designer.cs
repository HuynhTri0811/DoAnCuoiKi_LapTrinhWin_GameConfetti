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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewPlayerConnected
            // 
            this.listviewPlayerConnected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewPlayerConnected.HideSelection = false;
            this.listviewPlayerConnected.Location = new System.Drawing.Point(1015, 59);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên người chơi ";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số câu đúng";
            this.columnHeader2.Width = 109;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverConfetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 559);
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

        private System.Windows.Forms.ListView listPlayerConnect;
        private System.Windows.Forms.ListView listviewPlayerConnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountListPlayer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
    }
}


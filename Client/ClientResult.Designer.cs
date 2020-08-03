namespace Client
{
    partial class ClientResult
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
            this.lbNameClient = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tooltipShowTitle = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameClient
            // 
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClient.ForeColor = System.Drawing.Color.White;
            this.lbNameClient.Location = new System.Drawing.Point(12, 9);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(203, 31);
            this.lbNameClient.TabIndex = 8;
            this.lbNameClient.Text = "Kết quả trò chơi";
            this.lbNameClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseDown);
            this.lbNameClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseMove);
            this.lbNameClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(255, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-2, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người thắng cuộc";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 168);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // ClientResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNameClient);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ClientResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientResult";
            this.Load += new System.EventHandler(this.ClientResult_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientResult_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip tooltipShowTitle;
        private System.Windows.Forms.ListView listView1;
    }
}
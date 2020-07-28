namespace Client
{
    partial class ClientName
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxDangKy = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbNameClient = new System.Windows.Forms.Label();
            this.tooltipShowTitle = new System.Windows.Forms.ToolTip(this.components);
            this.txtPort = new Client.TextboxRoundedCorner();
            this.txtIPServer = new Client.TextboxRoundedCorner();
            this.txtNameClient = new Client.TextboxRoundedCorner();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIPServer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picboxDangKy);
            this.panel1.Controls.Add(this.txtNameClient);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 150);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // picboxDangKy
            // 
            this.picboxDangKy.Location = new System.Drawing.Point(218, 15);
            this.picboxDangKy.Name = "picboxDangKy";
            this.picboxDangKy.Size = new System.Drawing.Size(120, 34);
            this.picboxDangKy.TabIndex = 1;
            this.picboxDangKy.TabStop = false;
            this.picboxDangKy.Click += new System.EventHandler(this.picboxDangKy_Click);
            this.picboxDangKy.MouseLeave += new System.EventHandler(this.picboxDangKy_MouseLeave);
            this.picboxDangKy.MouseHover += new System.EventHandler(this.picboxDangKy_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(305, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 3;
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
            this.lbNameClient.Size = new System.Drawing.Size(218, 31);
            this.lbNameClient.TabIndex = 4;
            this.lbNameClient.Text = "Chọn tên hiển thị";
            this.lbNameClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseDown);
            this.lbNameClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseMove);
            this.lbNameClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseUp);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.BorderColor = System.Drawing.Color.Gray;
            this.txtPort.BorderSize = 1;
            this.txtPort.Br = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(218, 90);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.Size = new System.Drawing.Size(120, 33);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "3000";
            this.txtPort.textboxRadius = 15;
            this.txtPort.UseSystemPasswordChar = false;
            // 
            // txtIPServer
            // 
            this.txtIPServer.BackColor = System.Drawing.Color.Transparent;
            this.txtIPServer.BorderColor = System.Drawing.Color.Gray;
            this.txtIPServer.BorderSize = 1;
            this.txtIPServer.Br = System.Drawing.Color.White;
            this.txtIPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIPServer.ForeColor = System.Drawing.Color.Black;
            this.txtIPServer.Location = new System.Drawing.Point(12, 90);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.PasswordChar = '\0';
            this.txtIPServer.Size = new System.Drawing.Size(188, 33);
            this.txtIPServer.TabIndex = 4;
            this.txtIPServer.Text = "127.0.0.1";
            this.txtIPServer.textboxRadius = 15;
            this.txtIPServer.UseSystemPasswordChar = false;
            // 
            // txtNameClient
            // 
            this.txtNameClient.BackColor = System.Drawing.Color.Transparent;
            this.txtNameClient.BorderColor = System.Drawing.Color.Gray;
            this.txtNameClient.BorderSize = 1;
            this.txtNameClient.Br = System.Drawing.Color.White;
            this.txtNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameClient.ForeColor = System.Drawing.Color.Black;
            this.txtNameClient.Location = new System.Drawing.Point(12, 15);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.PasswordChar = '\0';
            this.txtNameClient.Size = new System.Drawing.Size(188, 34);
            this.txtNameClient.TabIndex = 0;
            this.txtNameClient.Text = "Tên của bạn";
            this.txtNameClient.textboxRadius = 15;
            this.txtNameClient.UseSystemPasswordChar = false;
            // 
            // ClientName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lbNameClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ClientName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientName";
            this.Load += new System.EventHandler(this.ClientName_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientName_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.ToolTip tooltipShowTitle;
        private TextboxRoundedCorner txtNameClient;
        private System.Windows.Forms.PictureBox picboxDangKy;
        private TextboxRoundedCorner txtIPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextboxRoundedCorner txtPort;
    }
}
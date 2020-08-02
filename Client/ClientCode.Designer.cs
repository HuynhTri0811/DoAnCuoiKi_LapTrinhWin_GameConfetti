namespace Client
{
    partial class ClientCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxGui = new System.Windows.Forms.PictureBox();
            this.txtCodeClient = new Client.TextboxRoundedCorner();
            this.tooltipShowTitle = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGui)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameClient
            // 
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameClient.ForeColor = System.Drawing.Color.White;
            this.lbNameClient.Location = new System.Drawing.Point(12, 9);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(248, 31);
            this.lbNameClient.TabIndex = 6;
            this.lbNameClient.Text = "Nhập code của bạn";
            this.lbNameClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseDown);
            this.lbNameClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseMove);
            this.lbNameClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(305, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picboxGui);
            this.panel1.Controls.Add(this.txtCodeClient);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 60);
            this.panel1.TabIndex = 7;
            // 
            // picboxGui
            // 
            this.picboxGui.Location = new System.Drawing.Point(218, 15);
            this.picboxGui.Name = "picboxGui";
            this.picboxGui.Size = new System.Drawing.Size(120, 34);
            this.picboxGui.TabIndex = 3;
            this.picboxGui.TabStop = false;
            this.picboxGui.Click += new System.EventHandler(this.picboxGui_Click);
            this.picboxGui.MouseLeave += new System.EventHandler(this.picboxGui_MouseLeave);
            this.picboxGui.MouseHover += new System.EventHandler(this.picboxGui_MouseHover);
            // 
            // txtCodeClient
            // 
            this.txtCodeClient.BackColor = System.Drawing.Color.Transparent;
            this.txtCodeClient.BorderColor = System.Drawing.Color.Gray;
            this.txtCodeClient.BorderSize = 1;
            this.txtCodeClient.Br = System.Drawing.Color.White;
            this.txtCodeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodeClient.ForeColor = System.Drawing.Color.Black;
            this.txtCodeClient.Location = new System.Drawing.Point(12, 15);
            this.txtCodeClient.Name = "txtCodeClient";
            this.txtCodeClient.PasswordChar = '\0';
            this.txtCodeClient.Size = new System.Drawing.Size(188, 34);
            this.txtCodeClient.TabIndex = 2;
            this.txtCodeClient.Text = "ID của bạn";
            this.txtCodeClient.textboxRadius = 15;
            this.txtCodeClient.UseSystemPasswordChar = false;
            // 
            // ClientCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 110);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNameClient);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ClientCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCode";
            this.Load += new System.EventHandler(this.ClientCode_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClientCode_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxGui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxGui;
        private TextboxRoundedCorner txtCodeClient;
        private System.Windows.Forms.ToolTip tooltipShowTitle;
    }
}
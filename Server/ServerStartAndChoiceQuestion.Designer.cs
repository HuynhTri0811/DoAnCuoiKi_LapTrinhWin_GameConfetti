namespace Server
{
    partial class ServerStartAndChoiceQuestion
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
            this.listviewQuestionData = new System.Windows.Forms.ListView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewQuestionData
            // 
            this.listviewQuestionData.CheckBoxes = true;
            this.listviewQuestionData.HideSelection = false;
            this.listviewQuestionData.Location = new System.Drawing.Point(12, 12);
            this.listviewQuestionData.Name = "listviewQuestionData";
            this.listviewQuestionData.Size = new System.Drawing.Size(839, 329);
            this.listviewQuestionData.TabIndex = 0;
            this.listviewQuestionData.UseCompatibleStateImageBehavior = false;
            this.listviewQuestionData.View = System.Windows.Forms.View.Details;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(6, 19);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(159, 55);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Thêm câu hỏi ";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddQuestion);
            this.groupBox1.Controls.Add(this.btnDeleteQuestion);
            this.groupBox1.Location = new System.Drawing.Point(857, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác trên câu hỏi";
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(6, 80);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(159, 55);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Xóa câu hỏi đã chọn";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(863, 222);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(165, 93);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Bất đầu game";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // ServerStartAndChoiceQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 358);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewQuestionData);
            this.Name = "ServerStartAndChoiceQuestion";
            this.Text = "Màn hình chọn câu hỏi ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewQuestionData;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnStartServer;
    }
}
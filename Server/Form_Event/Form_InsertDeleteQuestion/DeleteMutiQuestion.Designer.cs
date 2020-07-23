namespace Server
{
    partial class DeleteMutiQuestion
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
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewQuestionData
            // 
            this.listviewQuestionData.CheckBoxes = true;
            this.listviewQuestionData.HideSelection = false;
            this.listviewQuestionData.Location = new System.Drawing.Point(12, 12);
            this.listviewQuestionData.Name = "listviewQuestionData";
            this.listviewQuestionData.Size = new System.Drawing.Size(1016, 329);
            this.listviewQuestionData.TabIndex = 0;
            this.listviewQuestionData.UseCompatibleStateImageBehavior = false;
            this.listviewQuestionData.View = System.Windows.Forms.View.Details;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(398, 347);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(159, 55);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Xóa câu hỏi đã chọn";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // DeleteMutiQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 425);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.listviewQuestionData);
            this.Name = "DeleteMutiQuestion";
            this.Text = "Màn hình chọn câu hỏi  để xóa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewQuestionData;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}
namespace ChapeauUI
{
    partial class AddCommentForm
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
            AddCommentLbl = new Label();
            AddCommentLbl2 = new Label();
            AddCommentTxtBox = new TextBox();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // AddCommentLbl
            // 
            AddCommentLbl.AutoSize = true;
            AddCommentLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddCommentLbl.Location = new Point(12, 41);
            AddCommentLbl.Name = "AddCommentLbl";
            AddCommentLbl.Size = new Size(356, 31);
            AddCommentLbl.TabIndex = 0;
            AddCommentLbl.Text = "Are there any comments from the";
            // 
            // AddCommentLbl2
            // 
            AddCommentLbl2.AutoSize = true;
            AddCommentLbl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddCommentLbl2.Location = new Point(12, 72);
            AddCommentLbl2.Name = "AddCommentLbl2";
            AddCommentLbl2.Size = new Size(338, 31);
            AddCommentLbl2.TabIndex = 1;
            AddCommentLbl2.Text = "customer that you want to add?";
            // 
            // AddCommentTxtBox
            // 
            AddCommentTxtBox.Location = new Point(33, 137);
            AddCommentTxtBox.Multiline = true;
            AddCommentTxtBox.Name = "AddCommentTxtBox";
            AddCommentTxtBox.Size = new Size(317, 84);
            AddCommentTxtBox.TabIndex = 2;
            AddCommentTxtBox.TextChanged += AddCommentTxtBox_TextChanged;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(107, 263);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(162, 48);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "Finish Payment";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddCommentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 375);
            Controls.Add(AddBtn);
            Controls.Add(AddCommentTxtBox);
            Controls.Add(AddCommentLbl2);
            Controls.Add(AddCommentLbl);
            Name = "AddCommentForm";
            Text = "AddComments";
            Load += AddCommentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddCommentLbl;
        private Label AddCommentLbl2;
        private TextBox AddCommentTxtBox;
        private Button AddBtn;
    }
}
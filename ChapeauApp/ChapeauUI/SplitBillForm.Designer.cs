namespace ChapeauUI
{
    partial class SplitBillForm
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
            text1 = new Label();
            text2 = new Label();
            AmountOfPersonsTxtBox = new TextBox();
            ConfirmBtn = new Button();
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text1.Location = new Point(12, 31);
            text1.Name = "text1";
            text1.Size = new Size(366, 31);
            text1.TabIndex = 0;
            text1.Text = "Select the amount of persons you  ";
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text2.Location = new Point(12, 73);
            text2.Name = "text2";
            text2.Size = new Size(223, 31);
            text2.TabIndex = 1;
            text2.Text = "want to split the bill:";
            // 
            // AmountOfPersonsTxtBox
            // 
            AmountOfPersonsTxtBox.Location = new Point(241, 79);
            AmountOfPersonsTxtBox.Name = "AmountOfPersonsTxtBox";
            AmountOfPersonsTxtBox.Size = new Size(125, 27);
            AmountOfPersonsTxtBox.TabIndex = 2;
            AmountOfPersonsTxtBox.TextChanged += AmountOfPersonsTxtBox_TextChanged;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(119, 133);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(145, 59);
            ConfirmBtn.TabIndex = 3;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // SplitBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 227);
            Controls.Add(ConfirmBtn);
            Controls.Add(AmountOfPersonsTxtBox);
            Controls.Add(text2);
            Controls.Add(text1);
            Name = "SplitBillForm";
            Text = "SplitBillForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text1;
        private Label text2;
        private TextBox AmountOfPersonsTxtBox;
        private Button ConfirmBtn;
    }
}
namespace ChapeauUI
{
    partial class Payment
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
            TableSelectPnl = new Panel();
            NextBtn = new Button();
            TablesList = new ListView();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TableSelectPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TableSelectPnl
            // 
            TableSelectPnl.Controls.Add(NextBtn);
            TableSelectPnl.Controls.Add(TablesList);
            TableSelectPnl.Controls.Add(label2);
            TableSelectPnl.Controls.Add(label1);
            TableSelectPnl.Controls.Add(pictureBox1);
            TableSelectPnl.Location = new Point(12, 12);
            TableSelectPnl.Name = "TableSelectPnl";
            TableSelectPnl.Size = new Size(587, 578);
            TableSelectPnl.TabIndex = 0;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.SkyBlue;
            NextBtn.Location = new Point(193, 508);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(180, 29);
            NextBtn.TabIndex = 4;
            NextBtn.Text = "NEXT";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // TablesList
            // 
            TablesList.Location = new Point(134, 199);
            TablesList.Name = "TablesList";
            TablesList.Size = new Size(311, 255);
            TablesList.TabIndex = 3;
            TablesList.UseCompatibleStateImageBehavior = false;
            TablesList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 149);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "Select table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 93);
            label1.Name = "label1";
            label1.Size = new Size(167, 46);
            label1.TabIndex = 1;
            label1.Text = "PAYMENT";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_03_142740;
            pictureBox1.Location = new Point(206, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 601);
            Controls.Add(TableSelectPnl);
            Name = "Payment";
            Text = "Payment";
            TableSelectPnl.ResumeLayout(false);
            TableSelectPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TableSelectPnl;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListView TablesList;
        private Button NextBtn;
    }
}
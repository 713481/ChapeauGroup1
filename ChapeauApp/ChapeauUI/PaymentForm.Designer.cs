namespace ChapeauUI
{
    partial class PaymentForm
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
            ColorPanel1 = new Panel();
            ChapeauPictureLogo = new PictureBox();
            TableSelectPnl = new Panel();
            NextBtn = new Button();
            ListViewTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SelectTableLbl = new Label();
            Payment1Lbl = new Label();
            PaymentLogOutBtn = new Button();
            ColorPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChapeauPictureLogo).BeginInit();
            TableSelectPnl.SuspendLayout();
            SuspendLayout();
            // 
            // ColorPanel1
            // 
            ColorPanel1.BackColor = SystemColors.MenuHighlight;
            ColorPanel1.Controls.Add(PaymentLogOutBtn);
            ColorPanel1.Controls.Add(ChapeauPictureLogo);
            ColorPanel1.Location = new Point(3, 3);
            ColorPanel1.Name = "ColorPanel1";
            ColorPanel1.Size = new Size(573, 139);
            ColorPanel1.TabIndex = 0;
            // 
            // ChapeauPictureLogo
            // 
            ChapeauPictureLogo.Image = Properties.Resources.Screenshot_2024_06_03_142740;
            ChapeauPictureLogo.Location = new Point(215, 30);
            ChapeauPictureLogo.Name = "ChapeauPictureLogo";
            ChapeauPictureLogo.Size = new Size(144, 75);
            ChapeauPictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ChapeauPictureLogo.TabIndex = 0;
            ChapeauPictureLogo.TabStop = false;
            // 
            // TableSelectPnl
            // 
            TableSelectPnl.Controls.Add(NextBtn);
            TableSelectPnl.Controls.Add(ListViewTables);
            TableSelectPnl.Controls.Add(SelectTableLbl);
            TableSelectPnl.Controls.Add(Payment1Lbl);
            TableSelectPnl.Controls.Add(ColorPanel1);
            TableSelectPnl.Location = new Point(8, 12);
            TableSelectPnl.Name = "TableSelectPnl";
            TableSelectPnl.Size = new Size(579, 666);
            TableSelectPnl.TabIndex = 1;
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(207, 608);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(163, 29);
            NextBtn.TabIndex = 4;
            NextBtn.Text = "NEXT";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // ListViewTables
            // 
            ListViewTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ListViewTables.Location = new Point(155, 288);
            ListViewTables.Name = "ListViewTables";
            ListViewTables.Size = new Size(272, 293);
            ListViewTables.TabIndex = 3;
            ListViewTables.UseCompatibleStateImageBehavior = false;
            ListViewTables.View = View.Details;
            ListViewTables.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Table Number";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Table Status";
            columnHeader2.Width = 120;
            // 
            // SelectTableLbl
            // 
            SelectTableLbl.AutoSize = true;
            SelectTableLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTableLbl.Location = new Point(211, 241);
            SelectTableLbl.Name = "SelectTableLbl";
            SelectTableLbl.Size = new Size(151, 31);
            SelectTableLbl.TabIndex = 2;
            SelectTableLbl.Text = "Select a table";
            SelectTableLbl.Click += SelectTableLbl_Click;
            // 
            // Payment1Lbl
            // 
            Payment1Lbl.AutoSize = true;
            Payment1Lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Payment1Lbl.Location = new Point(207, 163);
            Payment1Lbl.Name = "Payment1Lbl";
            Payment1Lbl.Size = new Size(167, 46);
            Payment1Lbl.TabIndex = 1;
            Payment1Lbl.Text = "PAYMENT";
            Payment1Lbl.Click += Payment1Lbl_Click;
            // 
            // PaymentLogOutBtn
            // 
            PaymentLogOutBtn.Location = new Point(415, 43);
            PaymentLogOutBtn.Name = "PaymentLogOutBtn";
            PaymentLogOutBtn.Size = new Size(126, 42);
            PaymentLogOutBtn.TabIndex = 1;
            PaymentLogOutBtn.Text = "Log Out";
            PaymentLogOutBtn.UseVisualStyleBackColor = true;
            PaymentLogOutBtn.Click += PaymentLogOutBtn_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 690);
            Controls.Add(TableSelectPnl);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ColorPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChapeauPictureLogo).EndInit();
            TableSelectPnl.ResumeLayout(false);
            TableSelectPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ColorPanel1;
        private Panel TableSelectPnl;
        private PictureBox ChapeauPictureLogo;
        private Label Payment1Lbl;
        private ListView ListViewTables;
        private Label SelectTableLbl;
        private Button NextBtn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button PaymentLogOutBtn;
    }
}
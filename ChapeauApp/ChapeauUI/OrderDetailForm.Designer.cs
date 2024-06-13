namespace ChapeauUI
{
    partial class OrderDetailForm
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
            ColorPanel2 = new Panel();
            PictureLogo2 = new PictureBox();
            OrderDetailLbl = new Label();
            OrderDetailPanel = new Panel();
            SplittedPriceLbl = new Label();
            SplittedPrice = new Label();
            SplitBillBtn = new Button();
            PayPinBtn = new Button();
            label1 = new Label();
            PayCashBtn = new Button();
            FinalPriceLbl = new Label();
            TotalPriceLbl = new Label();
            AddTipTxtBox = new TextBox();
            AddTipLbl = new Label();
            OrderDetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ShowTableNbLbl = new Label();
            ColorPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureLogo2).BeginInit();
            OrderDetailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ColorPanel2
            // 
            ColorPanel2.BackColor = SystemColors.MenuHighlight;
            ColorPanel2.Controls.Add(PictureLogo2);
            ColorPanel2.Location = new Point(3, 3);
            ColorPanel2.Name = "ColorPanel2";
            ColorPanel2.Size = new Size(868, 115);
            ColorPanel2.TabIndex = 0;
            // 
            // PictureLogo2
            // 
            PictureLogo2.Image = Properties.Resources.Screenshot_2024_06_03_1427401;
            PictureLogo2.Location = new Point(373, 18);
            PictureLogo2.Name = "PictureLogo2";
            PictureLogo2.Size = new Size(140, 70);
            PictureLogo2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLogo2.TabIndex = 0;
            PictureLogo2.TabStop = false;
            // 
            // OrderDetailLbl
            // 
            OrderDetailLbl.AutoSize = true;
            OrderDetailLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            OrderDetailLbl.Location = new Point(320, 138);
            OrderDetailLbl.Name = "OrderDetailLbl";
            OrderDetailLbl.Size = new Size(258, 46);
            OrderDetailLbl.TabIndex = 1;
            OrderDetailLbl.Text = "ORDER DETAILS";
            // 
            // OrderDetailPanel
            // 
            OrderDetailPanel.Controls.Add(SplittedPriceLbl);
            OrderDetailPanel.Controls.Add(SplittedPrice);
            OrderDetailPanel.Controls.Add(SplitBillBtn);
            OrderDetailPanel.Controls.Add(PayPinBtn);
            OrderDetailPanel.Controls.Add(label1);
            OrderDetailPanel.Controls.Add(PayCashBtn);
            OrderDetailPanel.Controls.Add(FinalPriceLbl);
            OrderDetailPanel.Controls.Add(TotalPriceLbl);
            OrderDetailPanel.Controls.Add(AddTipTxtBox);
            OrderDetailPanel.Controls.Add(AddTipLbl);
            OrderDetailPanel.Controls.Add(OrderDetailsListView);
            OrderDetailPanel.Controls.Add(ShowTableNbLbl);
            OrderDetailPanel.Controls.Add(OrderDetailLbl);
            OrderDetailPanel.Controls.Add(ColorPanel2);
            OrderDetailPanel.Location = new Point(4, 5);
            OrderDetailPanel.Name = "OrderDetailPanel";
            OrderDetailPanel.Size = new Size(876, 722);
            OrderDetailPanel.TabIndex = 1;
            OrderDetailPanel.Paint += panel1_Paint;
            // 
            // SplittedPriceLbl
            // 
            SplittedPriceLbl.AutoSize = true;
            SplittedPriceLbl.Location = new Point(459, 659);
            SplittedPriceLbl.Name = "SplittedPriceLbl";
            SplittedPriceLbl.Size = new Size(50, 20);
            SplittedPriceLbl.TabIndex = 14;
            SplittedPriceLbl.Text = "label2";
            // 
            // SplittedPrice
            // 
            SplittedPrice.AutoSize = true;
            SplittedPrice.Location = new Point(353, 659);
            SplittedPrice.Name = "SplittedPrice";
            SplittedPrice.Size = new Size(100, 20);
            SplittedPrice.TabIndex = 13;
            SplittedPrice.Text = "Splitted Price:";
            // 
            // SplitBillBtn
            // 
            SplitBillBtn.Location = new Point(353, 614);
            SplitBillBtn.Name = "SplitBillBtn";
            SplitBillBtn.Size = new Size(94, 29);
            SplitBillBtn.TabIndex = 12;
            SplitBillBtn.Text = "Split Bill";
            SplitBillBtn.UseVisualStyleBackColor = true;
            SplitBillBtn.Click += SplitBillBtn_Click;
            // 
            // PayPinBtn
            // 
            PayPinBtn.BackColor = Color.GreenYellow;
            PayPinBtn.Location = new Point(658, 659);
            PayPinBtn.Name = "PayPinBtn";
            PayPinBtn.Size = new Size(163, 29);
            PayPinBtn.TabIndex = 11;
            PayPinBtn.Text = "Pay with Credit/Debit";
            PayPinBtn.UseVisualStyleBackColor = false;
            PayPinBtn.Click += PayPinBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 652);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // PayCashBtn
            // 
            PayCashBtn.BackColor = Color.GreenYellow;
            PayCashBtn.Location = new Point(658, 614);
            PayCashBtn.Name = "PayCashBtn";
            PayCashBtn.Size = new Size(140, 29);
            PayCashBtn.TabIndex = 8;
            PayCashBtn.Text = "Pay with cash";
            PayCashBtn.UseVisualStyleBackColor = false;
            PayCashBtn.Click += PayCashBtn_Click;
            // 
            // FinalPriceLbl
            // 
            FinalPriceLbl.AutoSize = true;
            FinalPriceLbl.Location = new Point(178, 659);
            FinalPriceLbl.Name = "FinalPriceLbl";
            FinalPriceLbl.Size = new Size(50, 20);
            FinalPriceLbl.TabIndex = 7;
            FinalPriceLbl.Text = "label1";
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Location = new Point(91, 659);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(81, 20);
            TotalPriceLbl.TabIndex = 6;
            TotalPriceLbl.Text = "Total Price:";
            // 
            // AddTipTxtBox
            // 
            AddTipTxtBox.Location = new Point(171, 615);
            AddTipTxtBox.Name = "AddTipTxtBox";
            AddTipTxtBox.Size = new Size(66, 27);
            AddTipTxtBox.TabIndex = 5;
            AddTipTxtBox.TextChanged += AddTipTxtBox_TextChanged;
            // 
            // AddTipLbl
            // 
            AddTipLbl.AutoSize = true;
            AddTipLbl.Location = new Point(91, 617);
            AddTipLbl.Name = "AddTipLbl";
            AddTipLbl.Size = new Size(65, 20);
            AddTipLbl.TabIndex = 4;
            AddTipLbl.Text = "Add Tip:";
            // 
            // OrderDetailsListView
            // 
            OrderDetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            OrderDetailsListView.Location = new Point(8, 234);
            OrderDetailsListView.Name = "OrderDetailsListView";
            OrderDetailsListView.Size = new Size(863, 363);
            OrderDetailsListView.TabIndex = 3;
            OrderDetailsListView.UseCompatibleStateImageBehavior = false;
            OrderDetailsListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Menu Item";
            columnHeader1.Width = 670;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "VAT";
            columnHeader3.Width = 90;
            // 
            // ShowTableNbLbl
            // 
            ShowTableNbLbl.AutoSize = true;
            ShowTableNbLbl.BackColor = SystemColors.Control;
            ShowTableNbLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ShowTableNbLbl.ForeColor = SystemColors.ControlText;
            ShowTableNbLbl.Location = new Point(21, 183);
            ShowTableNbLbl.Name = "ShowTableNbLbl";
            ShowTableNbLbl.Size = new Size(76, 31);
            ShowTableNbLbl.TabIndex = 2;
            ShowTableNbLbl.Text = "label1";
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 728);
            Controls.Add(OrderDetailPanel);
            Name = "OrderDetailForm";
            Text = "OrderDetailForm";
            Load += OrderDetailForm_Load;
            ColorPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureLogo2).EndInit();
            OrderDetailPanel.ResumeLayout(false);
            OrderDetailPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ColorPanel2;
        private PictureBox PictureLogo2;
        private Label OrderDetailLbl;
        private Panel OrderDetailPanel;
        private ListView OrderDetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label ShowTableNbLbl;
        private Label TotalPriceLbl;
        private TextBox AddTipTxtBox;
        private Label AddTipLbl;
        private Button PayCashBtn;
        private Label FinalPriceLbl;
        private Label label1;
        private ColumnHeader columnHeader3;
        private Button PayPinBtn;
        private Button SplitBillBtn;
        private Label SplittedPriceLbl;
        private Label SplittedPrice;
    }
}
namespace ChapeauUI
{
    partial class MyOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrder));
            btnMyOrderReturn = new Button();
            pnlMyOrderingLogo = new Panel();
            pnlMyOrderingHeaderBackground = new Panel();
            lblOrderingMyOrder = new Label();
            lvMyOrderList = new ListView();
            chMyOrderCount = new ColumnHeader();
            chMyOrderDishName = new ColumnHeader();
            chMyOrderPrice = new ColumnHeader();
            chMyOrderNotes = new ColumnHeader();
            btnMyOrderOrder = new Button();
            btnMyOrderClearOrder = new Button();
            lblMyOrderTotalPriceText = new Label();
            lblMyOrderTotalPrice = new Label();
            pnlMyOrderingHeaderBackground.SuspendLayout();
            SuspendLayout();
            // 
            // btnMyOrderReturn
            // 
            btnMyOrderReturn.BackgroundImage = (Image)resources.GetObject("btnMyOrderReturn.BackgroundImage");
            btnMyOrderReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnMyOrderReturn.FlatAppearance.BorderSize = 0;
            btnMyOrderReturn.Location = new Point(32, 49);
            btnMyOrderReturn.Name = "btnMyOrderReturn";
            btnMyOrderReturn.Size = new Size(36, 36);
            btnMyOrderReturn.TabIndex = 0;
            btnMyOrderReturn.UseVisualStyleBackColor = true;
            btnMyOrderReturn.Click += btnMyOrderReturn_Click;
            // 
            // pnlMyOrderingLogo
            // 
            pnlMyOrderingLogo.BackColor = Color.White;
            pnlMyOrderingLogo.BackgroundImage = (Image)resources.GetObject("pnlMyOrderingLogo.BackgroundImage");
            pnlMyOrderingLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMyOrderingLogo.Location = new Point(123, -5);
            pnlMyOrderingLogo.Name = "pnlMyOrderingLogo";
            pnlMyOrderingLogo.Size = new Size(132, 116);
            pnlMyOrderingLogo.TabIndex = 4;
            // 
            // pnlMyOrderingHeaderBackground
            // 
            pnlMyOrderingHeaderBackground.BackColor = Color.White;
            pnlMyOrderingHeaderBackground.Controls.Add(btnMyOrderReturn);
            pnlMyOrderingHeaderBackground.Location = new Point(-2, -2);
            pnlMyOrderingHeaderBackground.Name = "pnlMyOrderingHeaderBackground";
            pnlMyOrderingHeaderBackground.Size = new Size(391, 113);
            pnlMyOrderingHeaderBackground.TabIndex = 5;
            // 
            // lblOrderingMyOrder
            // 
            lblOrderingMyOrder.AutoSize = true;
            lblOrderingMyOrder.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderingMyOrder.ForeColor = SystemColors.ControlLightLight;
            lblOrderingMyOrder.Location = new Point(30, 137);
            lblOrderingMyOrder.Name = "lblOrderingMyOrder";
            lblOrderingMyOrder.Size = new Size(94, 22);
            lblOrderingMyOrder.TabIndex = 6;
            lblOrderingMyOrder.Text = "My order: ";
            // 
            // lvMyOrderList
            // 
            lvMyOrderList.Columns.AddRange(new ColumnHeader[] { chMyOrderCount, chMyOrderDishName, chMyOrderPrice, chMyOrderNotes });
            lvMyOrderList.FullRowSelect = true;
            lvMyOrderList.Location = new Point(30, 171);
            lvMyOrderList.Name = "lvMyOrderList";
            lvMyOrderList.Size = new Size(324, 404);
            lvMyOrderList.TabIndex = 7;
            lvMyOrderList.UseCompatibleStateImageBehavior = false;
            lvMyOrderList.View = View.Details;
            // 
            // chMyOrderCount
            // 
            chMyOrderCount.Text = "Count";
            chMyOrderCount.Width = 50;
            // 
            // chMyOrderDishName
            // 
            chMyOrderDishName.Text = "Dish name";
            chMyOrderDishName.Width = 130;
            // 
            // chMyOrderPrice
            // 
            chMyOrderPrice.Text = "Price";
            chMyOrderPrice.Width = 50;
            // 
            // chMyOrderNotes
            // 
            chMyOrderNotes.Text = "Notes";
            chMyOrderNotes.Width = 100;
            // 
            // btnMyOrderOrder
            // 
            btnMyOrderOrder.Location = new Point(227, 657);
            btnMyOrderOrder.Name = "btnMyOrderOrder";
            btnMyOrderOrder.Size = new Size(127, 53);
            btnMyOrderOrder.TabIndex = 8;
            btnMyOrderOrder.Text = "Order";
            btnMyOrderOrder.UseVisualStyleBackColor = true;
            // 
            // btnMyOrderClearOrder
            // 
            btnMyOrderClearOrder.Location = new Point(30, 657);
            btnMyOrderClearOrder.Name = "btnMyOrderClearOrder";
            btnMyOrderClearOrder.Size = new Size(127, 53);
            btnMyOrderClearOrder.TabIndex = 9;
            btnMyOrderClearOrder.Text = "Clear Order";
            btnMyOrderClearOrder.UseVisualStyleBackColor = true;
            btnMyOrderClearOrder.Click += btnMyOrderClearOrder_Click;
            // 
            // lblMyOrderTotalPriceText
            // 
            lblMyOrderTotalPriceText.AutoSize = true;
            lblMyOrderTotalPriceText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMyOrderTotalPriceText.ForeColor = SystemColors.ControlLightLight;
            lblMyOrderTotalPriceText.Location = new Point(30, 596);
            lblMyOrderTotalPriceText.Name = "lblMyOrderTotalPriceText";
            lblMyOrderTotalPriceText.Size = new Size(107, 22);
            lblMyOrderTotalPriceText.TabIndex = 10;
            lblMyOrderTotalPriceText.Text = "Total price: ";
            lblMyOrderTotalPriceText.Click += lblMyOrderTotalPriceText_Click;
            // 
            // lblMyOrderTotalPrice
            // 
            lblMyOrderTotalPrice.AutoSize = true;
            lblMyOrderTotalPrice.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMyOrderTotalPrice.ForeColor = SystemColors.ControlLightLight;
            lblMyOrderTotalPrice.Location = new Point(133, 596);
            lblMyOrderTotalPrice.Name = "lblMyOrderTotalPrice";
            lblMyOrderTotalPrice.Size = new Size(0, 22);
            lblMyOrderTotalPrice.TabIndex = 11;
            // 
            // MyOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(lblMyOrderTotalPrice);
            Controls.Add(lblMyOrderTotalPriceText);
            Controls.Add(btnMyOrderClearOrder);
            Controls.Add(btnMyOrderOrder);
            Controls.Add(lvMyOrderList);
            Controls.Add(lblOrderingMyOrder);
            Controls.Add(pnlMyOrderingLogo);
            Controls.Add(pnlMyOrderingHeaderBackground);
            Name = "MyOrder";
            Text = "MyOrder";
            Load += MyOrder_Load;
            pnlMyOrderingHeaderBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMyOrderReturn;
        private Panel pnlMyOrderingLogo;
        private Panel pnlMyOrderingHeaderBackground;
        private Label lblOrderingMyOrder;
        private ListView lvMyOrderList;
        private ColumnHeader chMyOrderCount;
        private ColumnHeader chMyOrderDishName;
        private ColumnHeader chMyOrderPrice;
        private ColumnHeader chMyOrderNotes;
        private Button btnMyOrderOrder;
        private Button btnMyOrderClearOrder;
        private Label lblMyOrderTotalPriceText;
        private Label lblMyOrderTotalPrice;
    }
}
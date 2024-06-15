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
            lblMyOrderTotalPriceText = new Label();
            btnMyOrderClearOrder = new Button();
            btnMyOrderOrder = new Button();
            lblMyOrderTotalPrice = new Label();
            btnMyOrderEditDish = new Button();
            btnMyOrderRemoveDish = new Button();
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
            pnlMyOrderingLogo.Location = new Point(122, -5);
            pnlMyOrderingLogo.Name = "pnlMyOrderingLogo";
            pnlMyOrderingLogo.Size = new Size(132, 116);
            pnlMyOrderingLogo.TabIndex = 6;
            // 
            // pnlMyOrderingHeaderBackground
            // 
            pnlMyOrderingHeaderBackground.BackColor = Color.White;
            pnlMyOrderingHeaderBackground.Controls.Add(btnMyOrderReturn);
            pnlMyOrderingHeaderBackground.Location = new Point(-3, -2);
            pnlMyOrderingHeaderBackground.Name = "pnlMyOrderingHeaderBackground";
            pnlMyOrderingHeaderBackground.Size = new Size(391, 113);
            pnlMyOrderingHeaderBackground.TabIndex = 7;
            // 
            // lblOrderingMyOrder
            // 
            lblOrderingMyOrder.AutoSize = true;
            lblOrderingMyOrder.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderingMyOrder.ForeColor = SystemColors.ControlLightLight;
            lblOrderingMyOrder.Location = new Point(29, 127);
            lblOrderingMyOrder.Name = "lblOrderingMyOrder";
            lblOrderingMyOrder.Size = new Size(94, 22);
            lblOrderingMyOrder.TabIndex = 8;
            lblOrderingMyOrder.Text = "My order: ";
            // 
            // lvMyOrderList
            // 
            lvMyOrderList.Columns.AddRange(new ColumnHeader[] { chMyOrderCount, chMyOrderDishName, chMyOrderPrice, chMyOrderNotes });
            lvMyOrderList.FullRowSelect = true;
            lvMyOrderList.Location = new Point(29, 152);
            lvMyOrderList.Name = "lvMyOrderList";
            lvMyOrderList.Size = new Size(324, 469);
            lvMyOrderList.TabIndex = 9;
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
            // lblMyOrderTotalPriceText
            // 
            lblMyOrderTotalPriceText.AutoSize = true;
            lblMyOrderTotalPriceText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMyOrderTotalPriceText.ForeColor = SystemColors.ControlLightLight;
            lblMyOrderTotalPriceText.Location = new Point(29, 636);
            lblMyOrderTotalPriceText.Name = "lblMyOrderTotalPriceText";
            lblMyOrderTotalPriceText.Size = new Size(107, 22);
            lblMyOrderTotalPriceText.TabIndex = 11;
            lblMyOrderTotalPriceText.Text = "Total price: ";
            lblMyOrderTotalPriceText.Click += lblMyOrderTotalPriceText_Click;
            // 
            // btnMyOrderClearOrder
            // 
            btnMyOrderClearOrder.Location = new Point(29, 661);
            btnMyOrderClearOrder.Name = "btnMyOrderClearOrder";
            btnMyOrderClearOrder.Size = new Size(100, 53);
            btnMyOrderClearOrder.TabIndex = 12;
            btnMyOrderClearOrder.Text = "Clear Order";
            btnMyOrderClearOrder.UseVisualStyleBackColor = true;
            btnMyOrderClearOrder.Click += btnMyOrderClearOrder_Click;
            // 
            // btnMyOrderOrder
            // 
            btnMyOrderOrder.Location = new Point(29, 723);
            btnMyOrderOrder.Name = "btnMyOrderOrder";
            btnMyOrderOrder.Size = new Size(324, 53);
            btnMyOrderOrder.TabIndex = 13;
            btnMyOrderOrder.Text = "Order";
            btnMyOrderOrder.UseVisualStyleBackColor = true;
            btnMyOrderOrder.Click += btnMyOrderOrder_Click;
            // 
            // lblMyOrderTotalPrice
            // 
            lblMyOrderTotalPrice.AutoSize = true;
            lblMyOrderTotalPrice.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMyOrderTotalPrice.ForeColor = SystemColors.ControlLightLight;
            lblMyOrderTotalPrice.Location = new Point(136, 636);
            lblMyOrderTotalPrice.Name = "lblMyOrderTotalPrice";
            lblMyOrderTotalPrice.Size = new Size(0, 22);
            lblMyOrderTotalPrice.TabIndex = 14;
            // 
            // btnMyOrderEditDish
            // 
            btnMyOrderEditDish.Location = new Point(253, 661);
            btnMyOrderEditDish.Name = "btnMyOrderEditDish";
            btnMyOrderEditDish.Size = new Size(100, 53);
            btnMyOrderEditDish.TabIndex = 15;
            btnMyOrderEditDish.Text = "Edit dish";
            btnMyOrderEditDish.UseVisualStyleBackColor = true;
            btnMyOrderEditDish.Click += btnMyOrderEditDish_Click;
            // 
            // btnMyOrderRemoveDish
            // 
            btnMyOrderRemoveDish.Location = new Point(142, 661);
            btnMyOrderRemoveDish.Name = "btnMyOrderRemoveDish";
            btnMyOrderRemoveDish.Size = new Size(100, 53);
            btnMyOrderRemoveDish.TabIndex = 16;
            btnMyOrderRemoveDish.Text = "Remove Dish";
            btnMyOrderRemoveDish.UseVisualStyleBackColor = true;
            btnMyOrderRemoveDish.Click += btnMyOrderRemoveDish_Click;
            // 
            // MyOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(btnMyOrderRemoveDish);
            Controls.Add(btnMyOrderEditDish);
            Controls.Add(lblMyOrderTotalPrice);
            Controls.Add(btnMyOrderOrder);
            Controls.Add(btnMyOrderClearOrder);
            Controls.Add(lblMyOrderTotalPriceText);
            Controls.Add(lvMyOrderList);
            Controls.Add(lblOrderingMyOrder);
            Controls.Add(pnlMyOrderingLogo);
            Controls.Add(pnlMyOrderingHeaderBackground);
            Name = "MyOrder";
            Text = "MyOrder";
            Load += MyOrder_Load_1;
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
        private Label lblMyOrderTotalPriceText;
        private Button btnMyOrderClearOrder;
        private Button btnMyOrderOrder;
        private Label lblMyOrderTotalPrice;
        private Button btnMyOrderEditDish;
        private Button btnMyOrderRemoveDish;
    }
}
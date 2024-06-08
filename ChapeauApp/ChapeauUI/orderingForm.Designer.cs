namespace ChapeauUI
{
    partial class orderingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderingForm));
            pnlOrderingLogo = new Panel();
            pnlOrderingHeaderBackground = new Panel();
            btnOrderingReturn = new Button();
            lblOrderingTableNumber = new Label();
            btnOrderingAddDishes = new Button();
            btnOrderingMyOrder = new Button();
            cmbOrderingCategory = new ComboBox();
            lvOrderingMenuItems = new ListView();
            chDishName = new ColumnHeader();
            chPrice = new ColumnHeader();
            chStock = new ColumnHeader();
            btnOrderingLunch = new Button();
            btnOrderingDiner = new Button();
            btnOrderingDrink = new Button();
            pnlOrderingHeaderBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOrderingLogo
            // 
            pnlOrderingLogo.BackColor = Color.White;
            pnlOrderingLogo.BackgroundImage = (Image)resources.GetObject("pnlOrderingLogo.BackgroundImage");
            pnlOrderingLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlOrderingLogo.Location = new Point(120, -6);
            pnlOrderingLogo.Name = "pnlOrderingLogo";
            pnlOrderingLogo.Size = new Size(132, 116);
            pnlOrderingLogo.TabIndex = 0;
            // 
            // pnlOrderingHeaderBackground
            // 
            pnlOrderingHeaderBackground.BackColor = Color.White;
            pnlOrderingHeaderBackground.Controls.Add(btnOrderingReturn);
            pnlOrderingHeaderBackground.Location = new Point(-5, -3);
            pnlOrderingHeaderBackground.Name = "pnlOrderingHeaderBackground";
            pnlOrderingHeaderBackground.Size = new Size(391, 113);
            pnlOrderingHeaderBackground.TabIndex = 1;
            // 
            // btnOrderingReturn
            // 
            btnOrderingReturn.BackgroundImage = (Image)resources.GetObject("btnOrderingReturn.BackgroundImage");
            btnOrderingReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnOrderingReturn.FlatAppearance.BorderSize = 0;
            btnOrderingReturn.Location = new Point(32, 49);
            btnOrderingReturn.Name = "btnOrderingReturn";
            btnOrderingReturn.Size = new Size(36, 36);
            btnOrderingReturn.TabIndex = 0;
            btnOrderingReturn.UseVisualStyleBackColor = true;
            // 
            // lblOrderingTableNumber
            // 
            lblOrderingTableNumber.AutoSize = true;
            lblOrderingTableNumber.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderingTableNumber.ForeColor = SystemColors.ControlLightLight;
            lblOrderingTableNumber.Location = new Point(27, 113);
            lblOrderingTableNumber.Name = "lblOrderingTableNumber";
            lblOrderingTableNumber.Size = new Size(66, 22);
            lblOrderingTableNumber.TabIndex = 2;
            lblOrderingTableNumber.Text = "Table: ";
            // 
            // btnOrderingAddDishes
            // 
            btnOrderingAddDishes.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrderingAddDishes.Location = new Point(27, 714);
            btnOrderingAddDishes.Name = "btnOrderingAddDishes";
            btnOrderingAddDishes.Size = new Size(132, 58);
            btnOrderingAddDishes.TabIndex = 9;
            btnOrderingAddDishes.Text = "Add";
            btnOrderingAddDishes.UseVisualStyleBackColor = true;
            btnOrderingAddDishes.Click += btnOrderingAddDishes_Click;
            // 
            // btnOrderingMyOrder
            // 
            btnOrderingMyOrder.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrderingMyOrder.Location = new Point(219, 714);
            btnOrderingMyOrder.Name = "btnOrderingMyOrder";
            btnOrderingMyOrder.Size = new Size(132, 58);
            btnOrderingMyOrder.TabIndex = 10;
            btnOrderingMyOrder.Text = "My order";
            btnOrderingMyOrder.UseVisualStyleBackColor = true;
            btnOrderingMyOrder.Click += btnOrderingMyOrder_Click;
            // 
            // cmbOrderingCategory
            // 
            cmbOrderingCategory.FormattingEnabled = true;
            cmbOrderingCategory.Location = new Point(24, 228);
            cmbOrderingCategory.Name = "cmbOrderingCategory";
            cmbOrderingCategory.Size = new Size(121, 23);
            cmbOrderingCategory.TabIndex = 11;
            cmbOrderingCategory.SelectedIndexChanged += cmbOrderingCategory_SelectedIndexChanged;
            // 
            // lvOrderingMenuItems
            // 
            lvOrderingMenuItems.Columns.AddRange(new ColumnHeader[] { chDishName, chPrice, chStock });
            lvOrderingMenuItems.FullRowSelect = true;
            lvOrderingMenuItems.Location = new Point(24, 257);
            lvOrderingMenuItems.Name = "lvOrderingMenuItems";
            lvOrderingMenuItems.Size = new Size(345, 338);
            lvOrderingMenuItems.TabIndex = 12;
            lvOrderingMenuItems.UseCompatibleStateImageBehavior = false;
            lvOrderingMenuItems.View = View.Details;
            // 
            // chDishName
            // 
            chDishName.Text = "Dish name";
            chDishName.Width = 195;
            // 
            // chPrice
            // 
            chPrice.Text = "Price";
            chPrice.Width = 70;
            // 
            // chStock
            // 
            chStock.Text = "Stock";
            chStock.Width = 50;
            // 
            // btnOrderingLunch
            // 
            btnOrderingLunch.Location = new Point(24, 152);
            btnOrderingLunch.Name = "btnOrderingLunch";
            btnOrderingLunch.Size = new Size(111, 58);
            btnOrderingLunch.TabIndex = 13;
            btnOrderingLunch.Text = "Lunch";
            btnOrderingLunch.UseVisualStyleBackColor = true;
            btnOrderingLunch.Click += btnOrderingLunch_Click_1;
            // 
            // btnOrderingDiner
            // 
            btnOrderingDiner.Location = new Point(141, 152);
            btnOrderingDiner.Name = "btnOrderingDiner";
            btnOrderingDiner.Size = new Size(111, 58);
            btnOrderingDiner.TabIndex = 14;
            btnOrderingDiner.Text = "Diner";
            btnOrderingDiner.UseVisualStyleBackColor = true;
            btnOrderingDiner.Click += btnOrderingDiner_Click;
            // 
            // btnOrderingDrink
            // 
            btnOrderingDrink.Location = new Point(258, 152);
            btnOrderingDrink.Name = "btnOrderingDrink";
            btnOrderingDrink.Size = new Size(111, 58);
            btnOrderingDrink.TabIndex = 15;
            btnOrderingDrink.Text = "Drink";
            btnOrderingDrink.UseVisualStyleBackColor = true;
            btnOrderingDrink.Click += btnOrderingDrink_Click;
            // 
            // orderingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(btnOrderingDrink);
            Controls.Add(btnOrderingDiner);
            Controls.Add(btnOrderingLunch);
            Controls.Add(lvOrderingMenuItems);
            Controls.Add(cmbOrderingCategory);
            Controls.Add(btnOrderingMyOrder);
            Controls.Add(btnOrderingAddDishes);
            Controls.Add(lblOrderingTableNumber);
            Controls.Add(pnlOrderingLogo);
            Controls.Add(pnlOrderingHeaderBackground);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "orderingForm";
            Text = "Ordering";
            Load += orderingForm_Load;
            pnlOrderingHeaderBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlOrderingLogo;
        private Panel pnlOrderingHeaderBackground;
        private Button btnOrderingReturn;
        private Label lblOrderingTableNumber;
        private Button btnOrderingAddDishes;
        private Button btnOrderingMyOrder;
        private ComboBox cmbOrderingCategory;
        private ListView lvOrderingMenuItems;
        private ColumnHeader chDishName;
        private ColumnHeader chPrice;
        private ColumnHeader chStock;
        private Button btnOrderingLunch;
        private Button btnOrderingDiner;
        private Button btnOrderingDrink;
    }
}
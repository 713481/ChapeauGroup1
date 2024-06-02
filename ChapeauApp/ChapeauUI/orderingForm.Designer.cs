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
            pnlLogo = new Panel();
            pnlHeaderBackground = new Panel();
            btnOrderingReturn = new Button();
            lblTableNumber = new Label();
            btnLunch = new Button();
            btnDiner = new Button();
            btnDrinks = new Button();
            btnLunchStarters = new Button();
            btnLunchMains = new Button();
            btnLunchDesserts = new Button();
            btnAddDishes = new Button();
            btnMyOrder = new Button();
            pnlHeaderBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.White;
            pnlLogo.BackgroundImage = (Image)resources.GetObject("pnlLogo.BackgroundImage");
            pnlLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogo.Location = new Point(120, -6);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(132, 116);
            pnlLogo.TabIndex = 0;
            // 
            // pnlHeaderBackground
            // 
            pnlHeaderBackground.BackColor = Color.White;
            pnlHeaderBackground.Controls.Add(btnOrderingReturn);
            pnlHeaderBackground.Location = new Point(-5, -3);
            pnlHeaderBackground.Name = "pnlHeaderBackground";
            pnlHeaderBackground.Size = new Size(391, 113);
            pnlHeaderBackground.TabIndex = 1;
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
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableNumber.ForeColor = SystemColors.ControlLightLight;
            lblTableNumber.Location = new Point(27, 113);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(57, 23);
            lblTableNumber.TabIndex = 2;
            lblTableNumber.Text = "Table: ";
            // 
            // btnLunch
            // 
            btnLunch.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunch.Location = new Point(-5, 139);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(132, 58);
            btnLunch.TabIndex = 3;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = true;
            // 
            // btnDiner
            // 
            btnDiner.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiner.Location = new Point(120, 139);
            btnDiner.Name = "btnDiner";
            btnDiner.Size = new Size(132, 58);
            btnDiner.TabIndex = 4;
            btnDiner.Text = "Diner";
            btnDiner.UseVisualStyleBackColor = true;
            // 
            // btnDrinks
            // 
            btnDrinks.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrinks.Location = new Point(251, 139);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(135, 58);
            btnDrinks.TabIndex = 5;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = true;
            // 
            // btnLunchStarters
            // 
            btnLunchStarters.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunchStarters.Location = new Point(-5, 194);
            btnLunchStarters.Name = "btnLunchStarters";
            btnLunchStarters.Size = new Size(132, 39);
            btnLunchStarters.TabIndex = 6;
            btnLunchStarters.Text = "Starters";
            btnLunchStarters.UseVisualStyleBackColor = true;
            // 
            // btnLunchMains
            // 
            btnLunchMains.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunchMains.Location = new Point(120, 194);
            btnLunchMains.Name = "btnLunchMains";
            btnLunchMains.Size = new Size(132, 39);
            btnLunchMains.TabIndex = 7;
            btnLunchMains.Text = "Mains";
            btnLunchMains.UseVisualStyleBackColor = true;
            // 
            // btnLunchDesserts
            // 
            btnLunchDesserts.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunchDesserts.Location = new Point(251, 194);
            btnLunchDesserts.Name = "btnLunchDesserts";
            btnLunchDesserts.Size = new Size(135, 39);
            btnLunchDesserts.TabIndex = 8;
            btnLunchDesserts.Text = "Desserts";
            btnLunchDesserts.UseVisualStyleBackColor = true;
            // 
            // btnAddDishes
            // 
            btnAddDishes.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDishes.Location = new Point(27, 714);
            btnAddDishes.Name = "btnAddDishes";
            btnAddDishes.Size = new Size(132, 58);
            btnAddDishes.TabIndex = 9;
            btnAddDishes.Text = "Add";
            btnAddDishes.UseVisualStyleBackColor = true;
            // 
            // btnMyOrder
            // 
            btnMyOrder.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyOrder.Location = new Point(219, 714);
            btnMyOrder.Name = "btnMyOrder";
            btnMyOrder.Size = new Size(132, 58);
            btnMyOrder.TabIndex = 10;
            btnMyOrder.Text = "My order";
            btnMyOrder.UseVisualStyleBackColor = true;
            // 
            // orderingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(btnMyOrder);
            Controls.Add(btnAddDishes);
            Controls.Add(btnLunchDesserts);
            Controls.Add(btnLunchMains);
            Controls.Add(btnLunchStarters);
            Controls.Add(btnDrinks);
            Controls.Add(btnDiner);
            Controls.Add(btnLunch);
            Controls.Add(lblTableNumber);
            Controls.Add(pnlLogo);
            Controls.Add(pnlHeaderBackground);
            Name = "orderingForm";
            Text = "Ordering";
            Load += orderingForm_Load;
            pnlHeaderBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogo;
        private Panel pnlHeaderBackground;
        private Button btnOrderingReturn;
        private Label lblTableNumber;
        private Button btnLunch;
        private Button btnDiner;
        private Button btnDrinks;
        private Button btnLunchStarters;
        private Button btnLunchMains;
        private Button btnLunchDesserts;
        private Button btnAddDishes;
        private Button btnMyOrder;
    }
}
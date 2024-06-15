namespace ChapeauUI
{
    partial class DishEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishEditor));
            pnlMyOrderingLogo = new Panel();
            pnlMyOrderingHeaderBackground = new Panel();
            btnDishEditorIncreaseCount = new Button();
            btnDishEditorDecreaseCount = new Button();
            lblDEOrderedCountText = new Label();
            lblDECurrentDish = new Label();
            btnDEDone = new Button();
            tbxDENotes = new TextBox();
            lblDENotes = new Label();
            btnDEAllergicPeanuts = new Button();
            btnDESeperateSauce = new Button();
            btnDEVegetarian = new Button();
            btnDENoSauce = new Button();
            btnDERare = new Button();
            btnDEMedRare = new Button();
            btnDEMedium = new Button();
            btnDEWellDone = new Button();
            SuspendLayout();
            // 
            // pnlMyOrderingLogo
            // 
            pnlMyOrderingLogo.BackColor = Color.White;
            pnlMyOrderingLogo.BackgroundImage = (Image)resources.GetObject("pnlMyOrderingLogo.BackgroundImage");
            pnlMyOrderingLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMyOrderingLogo.Location = new Point(122, -5);
            pnlMyOrderingLogo.Name = "pnlMyOrderingLogo";
            pnlMyOrderingLogo.Size = new Size(132, 116);
            pnlMyOrderingLogo.TabIndex = 8;
            // 
            // pnlMyOrderingHeaderBackground
            // 
            pnlMyOrderingHeaderBackground.BackColor = Color.White;
            pnlMyOrderingHeaderBackground.Location = new Point(-3, -2);
            pnlMyOrderingHeaderBackground.Name = "pnlMyOrderingHeaderBackground";
            pnlMyOrderingHeaderBackground.Size = new Size(391, 113);
            pnlMyOrderingHeaderBackground.TabIndex = 9;
            // 
            // btnDishEditorIncreaseCount
            // 
            btnDishEditorIncreaseCount.Location = new Point(29, 575);
            btnDishEditorIncreaseCount.Name = "btnDishEditorIncreaseCount";
            btnDishEditorIncreaseCount.Size = new Size(137, 59);
            btnDishEditorIncreaseCount.TabIndex = 10;
            btnDishEditorIncreaseCount.Text = "Increase";
            btnDishEditorIncreaseCount.UseVisualStyleBackColor = true;
            btnDishEditorIncreaseCount.Click += btnDishEditorIncreaseCount_Click;
            // 
            // btnDishEditorDecreaseCount
            // 
            btnDishEditorDecreaseCount.Location = new Point(221, 575);
            btnDishEditorDecreaseCount.Name = "btnDishEditorDecreaseCount";
            btnDishEditorDecreaseCount.Size = new Size(139, 59);
            btnDishEditorDecreaseCount.TabIndex = 11;
            btnDishEditorDecreaseCount.Text = "Decrease";
            btnDishEditorDecreaseCount.UseVisualStyleBackColor = true;
            btnDishEditorDecreaseCount.Click += btnDishEditorDecreaseCount_Click;
            // 
            // lblDEOrderedCountText
            // 
            lblDEOrderedCountText.AutoSize = true;
            lblDEOrderedCountText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDEOrderedCountText.ForeColor = SystemColors.Window;
            lblDEOrderedCountText.Location = new Point(31, 541);
            lblDEOrderedCountText.Name = "lblDEOrderedCountText";
            lblDEOrderedCountText.Size = new Size(137, 22);
            lblDEOrderedCountText.TabIndex = 12;
            lblDEOrderedCountText.Text = "Ordered count:";
            // 
            // lblDECurrentDish
            // 
            lblDECurrentDish.AutoSize = true;
            lblDECurrentDish.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDECurrentDish.ForeColor = SystemColors.ControlLightLight;
            lblDECurrentDish.Location = new Point(31, 161);
            lblDECurrentDish.MaximumSize = new Size(340, 0);
            lblDECurrentDish.Name = "lblDECurrentDish";
            lblDECurrentDish.Size = new Size(0, 18);
            lblDECurrentDish.TabIndex = 13;
            // 
            // btnDEDone
            // 
            btnDEDone.Location = new Point(29, 705);
            btnDEDone.Name = "btnDEDone";
            btnDEDone.Size = new Size(329, 61);
            btnDEDone.TabIndex = 14;
            btnDEDone.Text = "Done";
            btnDEDone.UseVisualStyleBackColor = true;
            btnDEDone.Click += btnDEDone_Click;
            // 
            // tbxDENotes
            // 
            tbxDENotes.Location = new Point(29, 229);
            tbxDENotes.Multiline = true;
            tbxDENotes.Name = "tbxDENotes";
            tbxDENotes.Size = new Size(331, 127);
            tbxDENotes.TabIndex = 15;
            // 
            // lblDENotes
            // 
            lblDENotes.AutoSize = true;
            lblDENotes.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDENotes.ForeColor = SystemColors.Window;
            lblDENotes.Location = new Point(29, 204);
            lblDENotes.Name = "lblDENotes";
            lblDENotes.Size = new Size(65, 22);
            lblDENotes.TabIndex = 16;
            lblDENotes.Text = "Notes:";
            // 
            // btnDEAllergicPeanuts
            // 
            btnDEAllergicPeanuts.Location = new Point(31, 362);
            btnDEAllergicPeanuts.Name = "btnDEAllergicPeanuts";
            btnDEAllergicPeanuts.Size = new Size(139, 38);
            btnDEAllergicPeanuts.TabIndex = 17;
            btnDEAllergicPeanuts.Text = "Allergic Peanuts";
            btnDEAllergicPeanuts.UseVisualStyleBackColor = true;
            btnDEAllergicPeanuts.Click += btnDEAllergicPeanuts_Click;
            // 
            // btnDESeperateSauce
            // 
            btnDESeperateSauce.Location = new Point(31, 450);
            btnDESeperateSauce.Name = "btnDESeperateSauce";
            btnDESeperateSauce.Size = new Size(139, 38);
            btnDESeperateSauce.TabIndex = 18;
            btnDESeperateSauce.Text = "Seperate Sauce";
            btnDESeperateSauce.UseVisualStyleBackColor = true;
            btnDESeperateSauce.Click += btnDESeperateSauce_Click;
            // 
            // btnDEVegetarian
            // 
            btnDEVegetarian.Location = new Point(31, 406);
            btnDEVegetarian.Name = "btnDEVegetarian";
            btnDEVegetarian.Size = new Size(139, 38);
            btnDEVegetarian.TabIndex = 19;
            btnDEVegetarian.Text = "Vegetarian";
            btnDEVegetarian.UseVisualStyleBackColor = true;
            btnDEVegetarian.Click += btnDEVegetarian_Click;
            // 
            // btnDENoSauce
            // 
            btnDENoSauce.Location = new Point(31, 494);
            btnDENoSauce.Name = "btnDENoSauce";
            btnDENoSauce.Size = new Size(139, 38);
            btnDENoSauce.TabIndex = 20;
            btnDENoSauce.Text = "No Sauce";
            btnDENoSauce.UseVisualStyleBackColor = true;
            btnDENoSauce.Click += btnDENoSauce_Click;
            // 
            // btnDERare
            // 
            btnDERare.Location = new Point(221, 362);
            btnDERare.Name = "btnDERare";
            btnDERare.Size = new Size(139, 38);
            btnDERare.TabIndex = 21;
            btnDERare.Text = "Rare";
            btnDERare.UseVisualStyleBackColor = true;
            btnDERare.Click += btnDERare_Click;
            // 
            // btnDEMedRare
            // 
            btnDEMedRare.Location = new Point(221, 406);
            btnDEMedRare.Name = "btnDEMedRare";
            btnDEMedRare.Size = new Size(139, 38);
            btnDEMedRare.TabIndex = 22;
            btnDEMedRare.Text = "Medium Rare";
            btnDEMedRare.UseVisualStyleBackColor = true;
            btnDEMedRare.Click += btnDEMedRare_Click;
            // 
            // btnDEMedium
            // 
            btnDEMedium.Location = new Point(221, 450);
            btnDEMedium.Name = "btnDEMedium";
            btnDEMedium.Size = new Size(139, 38);
            btnDEMedium.TabIndex = 23;
            btnDEMedium.Text = "Medium";
            btnDEMedium.UseVisualStyleBackColor = true;
            btnDEMedium.Click += btnDEMedium_Click;
            // 
            // btnDEWellDone
            // 
            btnDEWellDone.Location = new Point(221, 494);
            btnDEWellDone.Name = "btnDEWellDone";
            btnDEWellDone.Size = new Size(139, 38);
            btnDEWellDone.TabIndex = 24;
            btnDEWellDone.Text = "Well Done";
            btnDEWellDone.UseVisualStyleBackColor = true;
            btnDEWellDone.Click += btnDEWellDone_Click;
            // 
            // DishEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(btnDEWellDone);
            Controls.Add(btnDEMedium);
            Controls.Add(btnDEMedRare);
            Controls.Add(btnDERare);
            Controls.Add(btnDENoSauce);
            Controls.Add(btnDEVegetarian);
            Controls.Add(btnDESeperateSauce);
            Controls.Add(btnDEAllergicPeanuts);
            Controls.Add(lblDENotes);
            Controls.Add(tbxDENotes);
            Controls.Add(btnDEDone);
            Controls.Add(lblDECurrentDish);
            Controls.Add(lblDEOrderedCountText);
            Controls.Add(btnDishEditorDecreaseCount);
            Controls.Add(btnDishEditorIncreaseCount);
            Controls.Add(pnlMyOrderingLogo);
            Controls.Add(pnlMyOrderingHeaderBackground);
            ForeColor = SystemColors.ControlText;
            Name = "DishEditor";
            Text = "DishEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMyOrderReturn;
        private Panel pnlMyOrderingLogo;
        private Panel pnlMyOrderingHeaderBackground;
        private Button btnDishEditorIncreaseCount;
        private Button btnDishEditorDecreaseCount;
        private Label lblDEOrderedCountText;
        private Label lblDECurrentDish;
        private Button btnDEDone;
        private TextBox tbxDENotes;
        private Label lblDENotes;
        private Button btnDEAllergicPeanuts;
        private Button btnDESeperateSauce;
        private Button btnDEVegetarian;
        private Button btnDENoSauce;
        private Button btnDERare;
        private Button btnDEMedRare;
        private Button btnDEMedium;
        private Button btnDEWellDone;
    }
}
namespace ChapeauUI
{
    partial class myOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myOrderForm));
            btnMyOrderReturn = new Button();
            pnlOrderingLogo = new Panel();
            pnlOrderingHeaderBackground = new Panel();
            lblOrderingMyOrder = new Label();
            lvMyOrderList = new ListView();
            chMyOrderCount = new ColumnHeader();
            chMyOrderDishName = new ColumnHeader();
            chMyOrderPrice = new ColumnHeader();
            chMyOrderNotes = new ColumnHeader();
            btnMyOrderComment = new Button();
            pnlOrderingHeaderBackground.SuspendLayout();
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
            btnMyOrderReturn.Click += btnOrderingReturn_Click;
            // 
            // pnlOrderingLogo
            // 
            pnlOrderingLogo.BackColor = Color.White;
            pnlOrderingLogo.BackgroundImage = (Image)resources.GetObject("pnlOrderingLogo.BackgroundImage");
            pnlOrderingLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlOrderingLogo.Location = new Point(125, -3);
            pnlOrderingLogo.Name = "pnlOrderingLogo";
            pnlOrderingLogo.Size = new Size(132, 116);
            pnlOrderingLogo.TabIndex = 2;
            // 
            // pnlOrderingHeaderBackground
            // 
            pnlOrderingHeaderBackground.BackColor = Color.White;
            pnlOrderingHeaderBackground.Controls.Add(btnMyOrderReturn);
            pnlOrderingHeaderBackground.Location = new Point(0, 0);
            pnlOrderingHeaderBackground.Name = "pnlOrderingHeaderBackground";
            pnlOrderingHeaderBackground.Size = new Size(391, 113);
            pnlOrderingHeaderBackground.TabIndex = 3;
            // 
            // lblOrderingMyOrder
            // 
            lblOrderingMyOrder.AutoSize = true;
            lblOrderingMyOrder.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderingMyOrder.ForeColor = SystemColors.ControlLightLight;
            lblOrderingMyOrder.Location = new Point(32, 125);
            lblOrderingMyOrder.Name = "lblOrderingMyOrder";
            lblOrderingMyOrder.Size = new Size(94, 22);
            lblOrderingMyOrder.TabIndex = 4;
            lblOrderingMyOrder.Text = "My order: ";
            lblOrderingMyOrder.Click += label1_Click;
            // 
            // lvMyOrderList
            // 
            lvMyOrderList.Columns.AddRange(new ColumnHeader[] { chMyOrderCount, chMyOrderDishName, chMyOrderPrice, chMyOrderNotes });
            lvMyOrderList.FullRowSelect = true;
            lvMyOrderList.Location = new Point(32, 150);
            lvMyOrderList.Name = "lvMyOrderList";
            lvMyOrderList.Size = new Size(324, 401);
            lvMyOrderList.TabIndex = 5;
            lvMyOrderList.UseCompatibleStateImageBehavior = false;
            lvMyOrderList.View = View.Details;
            lvMyOrderList.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // btnMyOrderComment
            // 
            btnMyOrderComment.Location = new Point(32, 595);
            btnMyOrderComment.Name = "btnMyOrderComment";
            btnMyOrderComment.Size = new Size(127, 53);
            btnMyOrderComment.TabIndex = 6;
            btnMyOrderComment.Text = "Comment";
            btnMyOrderComment.UseVisualStyleBackColor = true;
            // 
            // myOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(384, 800);
            Controls.Add(btnMyOrderComment);
            Controls.Add(lvMyOrderList);
            Controls.Add(lblOrderingMyOrder);
            Controls.Add(pnlOrderingLogo);
            Controls.Add(pnlOrderingHeaderBackground);
            Name = "myOrderForm";
            Text = "My Order";
            Load += myOrderForm_Load;
            pnlOrderingHeaderBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMyOrderReturn;
        private Panel pnlOrderingLogo;
        private Panel pnlOrderingHeaderBackground;
        private Label lblOrderingMyOrder;
        private ListView lvMyOrderList;
        private ColumnHeader chMyOrderCount;
        private ColumnHeader chMyOrderDishName;
        private ColumnHeader chMyOrderPrice;
        private ColumnHeader chMyOrderNotes;
        private Button btnMyOrderComment;
    }
}
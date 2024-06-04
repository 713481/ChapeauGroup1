namespace ChapeauUI
{
    partial class OrderDetailsPayment
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            OrderDetailsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_03_142740;
            pictureBox1.Location = new Point(307, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 106);
            label1.Name = "label1";
            label1.Size = new Size(258, 46);
            label1.TabIndex = 3;
            label1.Text = "ORDER DETAILS";
            // 
            // panel1
            // 
            panel1.Controls.Add(OrderDetailsListView);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 468);
            panel1.TabIndex = 4;
            // 
            // OrderDetailsListView
            // 
            OrderDetailsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6 });
            OrderDetailsListView.Location = new Point(115, 155);
            OrderDetailsListView.Name = "OrderDetailsListView";
            OrderDetailsListView.Size = new Size(535, 259);
            OrderDetailsListView.TabIndex = 4;
            OrderDetailsListView.UseCompatibleStateImageBehavior = false;
            OrderDetailsListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Menu Item";
            columnHeader1.Width = 400;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Price";
            columnHeader6.Width = 150;
            // 
            // OrderDetailsPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(panel1);
            Name = "OrderDetailsPayment";
            Text = "OrderDetailsPayment";
            Load += OrderDetailsPayment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private ListView OrderDetailsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
    }
}
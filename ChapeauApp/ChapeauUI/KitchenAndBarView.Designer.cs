namespace ChapeauUI
{
    partial class KitchenAndBarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenAndBarView));
            pictureBoxChapau = new PictureBox();
            ListViewOpenOrderBar = new ListView();
            listViewOrderItemBar = new ListView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapau).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxChapau
            // 
            pictureBoxChapau.Image = (Image)resources.GetObject("pictureBoxChapau.Image");
            pictureBoxChapau.Location = new Point(30, 16);
            pictureBoxChapau.Margin = new Padding(3, 4, 3, 4);
            pictureBoxChapau.Name = "pictureBoxChapau";
            pictureBoxChapau.Size = new Size(159, 109);
            pictureBoxChapau.TabIndex = 0;
            pictureBoxChapau.TabStop = false;
            // 
            // ListViewOpenOrderBar
            // 
            ListViewOpenOrderBar.Location = new Point(289, 181);
            ListViewOpenOrderBar.Margin = new Padding(3, 4, 3, 4);
            ListViewOpenOrderBar.Name = "ListViewOpenOrderBar";
            ListViewOpenOrderBar.Size = new Size(863, 280);
            ListViewOpenOrderBar.TabIndex = 1;
            ListViewOpenOrderBar.UseCompatibleStateImageBehavior = false;
            // 
            // listViewOrderItemBar
            // 
            listViewOrderItemBar.Location = new Point(289, 536);
            listViewOrderItemBar.Margin = new Padding(3, 4, 3, 4);
            listViewOrderItemBar.Name = "listViewOrderItemBar";
            listViewOrderItemBar.Size = new Size(863, 285);
            listViewOrderItemBar.TabIndex = 2;
            listViewOrderItemBar.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // KitchenAndBarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 965);
            Controls.Add(label1);
            Controls.Add(listViewOrderItemBar);
            Controls.Add(ListViewOpenOrderBar);
            Controls.Add(pictureBoxChapau);
            Name = "KitchenAndBarView";
            Text = "KitchenAndBarView";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxChapau;
        private ListView ListViewOpenOrderBar;
        private ListView listViewOrderItemBar;
        private Label label1;
    }
}
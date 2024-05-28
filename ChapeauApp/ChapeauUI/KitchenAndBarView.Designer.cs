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
            ViewTableID = new ColumnHeader();
            OrderIDBar = new ColumnHeader();
            OrderTimeBar = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewOrderItemBar = new ListView();
            labelOrderBar = new Label();
            labelOrderItemBar = new Label();
            buttonSetToReady = new Button();
            SetToPreparedButton = new Button();
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
            ListViewOpenOrderBar.Columns.AddRange(new ColumnHeader[] { ViewTableID, OrderIDBar, OrderTimeBar, columnHeader4 });
            ListViewOpenOrderBar.Location = new Point(300, 145);
            ListViewOpenOrderBar.Margin = new Padding(3, 4, 3, 4);
            ListViewOpenOrderBar.Name = "ListViewOpenOrderBar";
            ListViewOpenOrderBar.Size = new Size(863, 280);
            ListViewOpenOrderBar.TabIndex = 1;
            ListViewOpenOrderBar.UseCompatibleStateImageBehavior = false;
            // 
            // ViewTableID
            // 
            ViewTableID.Text = "Table ID";
            // 
            // OrderIDBar
            // 
            OrderIDBar.Text = "Order ID";
            // 
            // OrderTimeBar
            // 
            OrderTimeBar.Text = "Order Time";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            // 
            // listViewOrderItemBar
            // 
            listViewOrderItemBar.Location = new Point(300, 501);
            listViewOrderItemBar.Margin = new Padding(3, 4, 3, 4);
            listViewOrderItemBar.Name = "listViewOrderItemBar";
            listViewOrderItemBar.Size = new Size(863, 285);
            listViewOrderItemBar.TabIndex = 2;
            listViewOrderItemBar.UseCompatibleStateImageBehavior = false;
            // 
            // labelOrderBar
            // 
            labelOrderBar.AutoSize = true;
            labelOrderBar.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderBar.Location = new Point(112, 145);
            labelOrderBar.Name = "labelOrderBar";
            labelOrderBar.Size = new Size(109, 45);
            labelOrderBar.TabIndex = 3;
            labelOrderBar.Text = "Order:";
            // 
            // labelOrderItemBar
            // 
            labelOrderItemBar.AutoSize = true;
            labelOrderItemBar.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderItemBar.Location = new Point(94, 501);
            labelOrderItemBar.Name = "labelOrderItemBar";
            labelOrderItemBar.Size = new Size(183, 45);
            labelOrderItemBar.TabIndex = 4;
            labelOrderItemBar.Text = "Order Item:";
            // 
            // buttonSetToReady
            // 
            buttonSetToReady.Location = new Point(112, 559);
            buttonSetToReady.Name = "buttonSetToReady";
            buttonSetToReady.Size = new Size(146, 77);
            buttonSetToReady.TabIndex = 5;
            buttonSetToReady.Text = "Set To Ready";
            buttonSetToReady.UseVisualStyleBackColor = true;
            // 
            // SetToPreparedButton
            // 
            SetToPreparedButton.Location = new Point(112, 670);
            SetToPreparedButton.Name = "SetToPreparedButton";
            SetToPreparedButton.Size = new Size(146, 79);
            SetToPreparedButton.TabIndex = 6;
            SetToPreparedButton.Text = "Set To Perpare";
            SetToPreparedButton.UseVisualStyleBackColor = true;
            // 
            // KitchenAndBarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 965);
            Controls.Add(SetToPreparedButton);
            Controls.Add(buttonSetToReady);
            Controls.Add(labelOrderItemBar);
            Controls.Add(labelOrderBar);
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
        private Label labelOrderBar;
        private Label labelOrderItemBar;
        private Button buttonSetToReady;
        private Button SetToPreparedButton;
        private ColumnHeader ViewTableID;
        private ColumnHeader OrderIDBar;
        private ColumnHeader OrderTimeBar;
        private ColumnHeader columnHeader4;
    }
}
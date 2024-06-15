namespace ChapeauUI
{
    partial class TableViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableViewForm));
            pnlTableViewLogo = new Panel();
            buttonLoggingOut = new Button();
            button2 = new Button();
            buttonShowGreen = new Button();
            buttonShowRed = new Button();
            labelShowAvailable = new Label();
            labelShowOccupied = new Label();
            TableViewsLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // pnlTableViewLogo
            // 
            pnlTableViewLogo.BackColor = Color.White;
            pnlTableViewLogo.BackgroundImage = (Image)resources.GetObject("pnlTableViewLogo.BackgroundImage");
            pnlTableViewLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlTableViewLogo.Location = new Point(111, 24);
            pnlTableViewLogo.Margin = new Padding(3, 4, 3, 4);
            pnlTableViewLogo.Name = "pnlTableViewLogo";
            pnlTableViewLogo.Size = new Size(105, 86);
            pnlTableViewLogo.TabIndex = 17;
            // 
            // buttonLoggingOut
            // 
            buttonLoggingOut.Location = new Point(247, 37);
            buttonLoggingOut.Name = "buttonLoggingOut";
            buttonLoggingOut.Size = new Size(94, 29);
            buttonLoggingOut.TabIndex = 0;
            buttonLoggingOut.Text = "Logout";
            buttonLoggingOut.UseVisualStyleBackColor = true;
            buttonLoggingOut.Click += buttonLoggingOut_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 92);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonShowGreen
            // 
            buttonShowGreen.BackColor = Color.Lime;
            buttonShowGreen.Location = new Point(36, 156);
            buttonShowGreen.Name = "buttonShowGreen";
            buttonShowGreen.Size = new Size(34, 29);
            buttonShowGreen.TabIndex = 2;
            buttonShowGreen.UseVisualStyleBackColor = false;
            // 
            // buttonShowRed
            // 
            buttonShowRed.BackColor = Color.Red;
            buttonShowRed.Location = new Point(129, 156);
            buttonShowRed.Name = "buttonShowRed";
            buttonShowRed.Size = new Size(34, 29);
            buttonShowRed.TabIndex = 3;
            buttonShowRed.UseVisualStyleBackColor = false;
            // 
            // labelShowAvailable
            // 
            labelShowAvailable.AutoSize = true;
            labelShowAvailable.Location = new Point(76, 160);
            labelShowAvailable.Name = "labelShowAvailable";
            labelShowAvailable.Size = new Size(37, 20);
            labelShowAvailable.TabIndex = 18;
            labelShowAvailable.Text = "Free";
            // 
            // labelShowOccupied
            // 
            labelShowOccupied.AutoSize = true;
            labelShowOccupied.Location = new Point(169, 160);
            labelShowOccupied.Name = "labelShowOccupied";
            labelShowOccupied.Size = new Size(72, 20);
            labelShowOccupied.TabIndex = 19;
            labelShowOccupied.Text = "Occupied";
            // 
            // TableViewsLayoutPanel
            // 
            TableViewsLayoutPanel.AutoSize = true;
            TableViewsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableViewsLayoutPanel.ColumnCount = 2;
            TableViewsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableViewsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableViewsLayoutPanel.Location = new Point(40, 212);
            TableViewsLayoutPanel.Name = "TableViewsLayoutPanel";
            TableViewsLayoutPanel.Padding = new Padding(20);
            TableViewsLayoutPanel.RowCount = 1;
            TableViewsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableViewsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableViewsLayoutPanel.Size = new Size(40, 40);
            TableViewsLayoutPanel.TabIndex = 20;
            // 
            // TableViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(425, 806);
            Controls.Add(TableViewsLayoutPanel);
            Controls.Add(labelShowOccupied);
            Controls.Add(labelShowAvailable);
            Controls.Add(buttonLoggingOut);
            Controls.Add(button2);
            Controls.Add(buttonShowGreen);
            Controls.Add(buttonShowRed);
            Controls.Add(pnlTableViewLogo);
            Name = "TableViewForm";
            Text = "TableViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTableViewLogo;
        private Button buttonLoggingOut;
        private Button button2;
        private Button buttonShowGreen;
        private Button buttonShowRed;
        private Label labelShowAvailable;
        private Label labelShowOccupied;
        private TableLayoutPanel TableViewsLayoutPanel;
    }
}
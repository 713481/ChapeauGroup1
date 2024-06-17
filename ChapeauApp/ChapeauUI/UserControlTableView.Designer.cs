namespace ChapeauUI
{
    partial class UserControlTableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNumberOfTable = new Label();
            SuspendLayout();
            // 
            // labelNumberOfTable
            // 
            labelNumberOfTable.BackColor = Color.Transparent;
            labelNumberOfTable.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberOfTable.Location = new Point(0, 0);
            labelNumberOfTable.Name = "labelNumberOfTable";
            labelNumberOfTable.Size = new Size(86, 87);
            labelNumberOfTable.TabIndex = 0;
            labelNumberOfTable.Text = "1";
            labelNumberOfTable.TextAlign = ContentAlignment.MiddleCenter;
            labelNumberOfTable.Click += labelNumberOfTable_Click;
            // 
            // UserControlTableView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelNumberOfTable);
            Name = "UserControlTableView";
            Size = new Size(86, 87);
            ResumeLayout(false);
        }

        #endregion

        private Label labelNumberOfTable;
    }
}

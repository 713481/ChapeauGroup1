namespace ChapeauUI
{
    partial class TableStatusForm
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
            buttonReturnToTableView = new Button();
            buttonOccupyingTables = new Button();
            buttonFreeingTable = new Button();
            listViewTableStatusOrderList = new ListView();
            TableStatusOrderNoLists = new ColumnHeader();
            TableStatusOnOrderTables = new ColumnHeader();
            TableStatusWatingTimeForOrders = new ColumnHeader();
            labelTableBox = new Label();
            labelTableShowNumbers = new Label();
            TableStatusOrderbutton = new Button();
            TableStatusPaymentButton = new Button();
            SuspendLayout();
            // 
            // buttonReturnToTableView
            // 
            buttonReturnToTableView.Location = new Point(290, 41);
            buttonReturnToTableView.Name = "buttonReturnToTableView";
            buttonReturnToTableView.Size = new Size(94, 29);
            buttonReturnToTableView.TabIndex = 0;
            buttonReturnToTableView.Text = "Return";
            buttonReturnToTableView.UseVisualStyleBackColor = true;
            buttonReturnToTableView.Click += buttonReturnToTableView_Click;
            // 
            // buttonOccupyingTables
            // 
            buttonOccupyingTables.BackColor = Color.FromArgb(128, 255, 128);
            buttonOccupyingTables.Location = new Point(72, 339);
            buttonOccupyingTables.Name = "buttonOccupyingTables";
            buttonOccupyingTables.Size = new Size(94, 29);
            buttonOccupyingTables.TabIndex = 1;
            buttonOccupyingTables.Text = "Occupy";
            buttonOccupyingTables.UseVisualStyleBackColor = false;
            // 
            // buttonFreeingTable
            // 
            buttonFreeingTable.BackColor = Color.FromArgb(255, 128, 128);
            buttonFreeingTable.Location = new Point(72, 386);
            buttonFreeingTable.Name = "buttonFreeingTable";
            buttonFreeingTable.Size = new Size(94, 29);
            buttonFreeingTable.TabIndex = 2;
            buttonFreeingTable.Text = "Free Table";
            buttonFreeingTable.UseVisualStyleBackColor = false;
            // 
            // listViewTableStatusOrderList
            // 
            listViewTableStatusOrderList.Columns.AddRange(new ColumnHeader[] { TableStatusOrderNoLists, TableStatusOnOrderTables, TableStatusWatingTimeForOrders });
            listViewTableStatusOrderList.Location = new Point(72, 82);
            listViewTableStatusOrderList.Name = "listViewTableStatusOrderList";
            listViewTableStatusOrderList.Size = new Size(286, 224);
            listViewTableStatusOrderList.TabIndex = 3;
            listViewTableStatusOrderList.UseCompatibleStateImageBehavior = false;
            listViewTableStatusOrderList.View = View.Details;
            // 
            // TableStatusOrderNoLists
            // 
            TableStatusOrderNoLists.Text = "Order No.";
            TableStatusOrderNoLists.Width = 80;
            // 
            // TableStatusOnOrderTables
            // 
            TableStatusOnOrderTables.Text = "Status";
            // 
            // TableStatusWatingTimeForOrders
            // 
            TableStatusWatingTimeForOrders.Text = "Waiting Time";
            TableStatusWatingTimeForOrders.Width = 140;
            // 
            // labelTableBox
            // 
            labelTableBox.AutoSize = true;
            labelTableBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableBox.Location = new Point(124, 38);
            labelTableBox.Name = "labelTableBox";
            labelTableBox.Size = new Size(87, 41);
            labelTableBox.TabIndex = 4;
            labelTableBox.Text = "Table";
            // 
            // labelTableShowNumbers
            // 
            labelTableShowNumbers.AutoSize = true;
            labelTableShowNumbers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableShowNumbers.Location = new Point(217, 41);
            labelTableShowNumbers.Name = "labelTableShowNumbers";
            labelTableShowNumbers.Size = new Size(32, 38);
            labelTableShowNumbers.TabIndex = 5;
            labelTableShowNumbers.Text = "1";
            // 
            // TableStatusOrderbutton
            // 
            TableStatusOrderbutton.Location = new Point(250, 339);
            TableStatusOrderbutton.Name = "TableStatusOrderbutton";
            TableStatusOrderbutton.Size = new Size(94, 29);
            TableStatusOrderbutton.TabIndex = 6;
            TableStatusOrderbutton.Text = "New Order";
            TableStatusOrderbutton.UseVisualStyleBackColor = true;
            // 
            // TableStatusPaymentButton
            // 
            TableStatusPaymentButton.Location = new Point(250, 386);
            TableStatusPaymentButton.Name = "TableStatusPaymentButton";
            TableStatusPaymentButton.Size = new Size(94, 29);
            TableStatusPaymentButton.TabIndex = 7;
            TableStatusPaymentButton.Text = "Payment";
            TableStatusPaymentButton.UseVisualStyleBackColor = true;
            // 
            // TableStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(442, 450);
            Controls.Add(TableStatusPaymentButton);
            Controls.Add(TableStatusOrderbutton);
            Controls.Add(labelTableShowNumbers);
            Controls.Add(labelTableBox);
            Controls.Add(listViewTableStatusOrderList);
            Controls.Add(buttonFreeingTable);
            Controls.Add(buttonOccupyingTables);
            Controls.Add(buttonReturnToTableView);
            Name = "TableStatus";
            Text = "TableStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturnToTableView;
        private Button buttonOccupyingTables;
        private Button buttonFreeingTable;
        private ListView listViewTableStatusOrderList;
        private ColumnHeader TableStatusOrderNoLists;
        private ColumnHeader TableStatusOnOrderTables;
        private ColumnHeader TableStatusWatingTimeForOrders;
        private Label labelTableBox;
        private Label labelTableShowNumbers;
        private Button TableStatusOrderbutton;
        private Button TableStatusPaymentButton;
    }
}
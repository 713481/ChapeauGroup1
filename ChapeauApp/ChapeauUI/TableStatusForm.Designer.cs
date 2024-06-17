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
            components = new System.ComponentModel.Container();
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
            button1ChangingStatusToServed = new Button();
            timerRefreshs = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonReturnToTableView
            // 
            buttonReturnToTableView.Location = new Point(280, 12);
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
            buttonOccupyingTables.Location = new Point(72, 349);
            buttonOccupyingTables.Name = "buttonOccupyingTables";
            buttonOccupyingTables.Size = new Size(94, 29);
            buttonOccupyingTables.TabIndex = 1;
            buttonOccupyingTables.Text = "Occupy";
            buttonOccupyingTables.UseVisualStyleBackColor = false;
            buttonOccupyingTables.Click += buttonOccupyingTables_Click;
            // 
            // buttonFreeingTable
            // 
            buttonFreeingTable.BackColor = Color.FromArgb(255, 128, 128);
            buttonFreeingTable.Location = new Point(72, 396);
            buttonFreeingTable.Name = "buttonFreeingTable";
            buttonFreeingTable.Size = new Size(94, 29);
            buttonFreeingTable.TabIndex = 2;
            buttonFreeingTable.Text = "Free Table";
            buttonFreeingTable.UseVisualStyleBackColor = false;
            buttonFreeingTable.Click += buttonFreeingTable_Click;
            // 
            // listViewTableStatusOrderList
            // 
            listViewTableStatusOrderList.Columns.AddRange(new ColumnHeader[] { TableStatusOrderNoLists, TableStatusOnOrderTables, TableStatusWatingTimeForOrders });
            listViewTableStatusOrderList.FullRowSelect = true;
            listViewTableStatusOrderList.Location = new Point(72, 62);
            listViewTableStatusOrderList.Name = "listViewTableStatusOrderList";
            listViewTableStatusOrderList.Size = new Size(286, 224);
            listViewTableStatusOrderList.TabIndex = 3;
            listViewTableStatusOrderList.UseCompatibleStateImageBehavior = false;
            listViewTableStatusOrderList.View = View.Details;
            // 
            // TableStatusOrderNoLists
            // 
            TableStatusOrderNoLists.Text = "Item No.";
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
            labelTableBox.Location = new Point(124, 18);
            labelTableBox.Name = "labelTableBox";
            labelTableBox.Size = new Size(87, 41);
            labelTableBox.TabIndex = 4;
            labelTableBox.Text = "Table";
            // 
            // labelTableShowNumbers
            // 
            labelTableShowNumbers.AutoSize = true;
            labelTableShowNumbers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableShowNumbers.Location = new Point(217, 21);
            labelTableShowNumbers.Name = "labelTableShowNumbers";
            labelTableShowNumbers.Size = new Size(32, 38);
            labelTableShowNumbers.TabIndex = 5;
            labelTableShowNumbers.Text = "1";
            // 
            // TableStatusOrderbutton
            // 
            TableStatusOrderbutton.Location = new Point(250, 349);
            TableStatusOrderbutton.Name = "TableStatusOrderbutton";
            TableStatusOrderbutton.Size = new Size(94, 29);
            TableStatusOrderbutton.TabIndex = 6;
            TableStatusOrderbutton.Text = "New Order";
            TableStatusOrderbutton.UseVisualStyleBackColor = true;
            TableStatusOrderbutton.Click += TableStatusOrderbutton_Click;
            // 
            // TableStatusPaymentButton
            // 
            TableStatusPaymentButton.Location = new Point(250, 396);
            TableStatusPaymentButton.Name = "TableStatusPaymentButton";
            TableStatusPaymentButton.Size = new Size(94, 29);
            TableStatusPaymentButton.TabIndex = 7;
            TableStatusPaymentButton.Text = "Payment";
            TableStatusPaymentButton.UseVisualStyleBackColor = true;
            TableStatusPaymentButton.Click += TableStatusPaymentButton_Click;
            // 
            // button1ChangingStatusToServed
            // 
            button1ChangingStatusToServed.Location = new Point(166, 314);
            button1ChangingStatusToServed.Name = "button1ChangingStatusToServed";
            button1ChangingStatusToServed.Size = new Size(94, 29);
            button1ChangingStatusToServed.TabIndex = 8;
            button1ChangingStatusToServed.Text = "Serve";
            button1ChangingStatusToServed.UseVisualStyleBackColor = true;
            button1ChangingStatusToServed.Click += button1ChangingStatusToServed_Click;
            // 
            // timerRefreshs
            // 
            timerRefreshs.Tick += timerRefreshs_Tick;
            // 
            // TableStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(442, 450);
            Controls.Add(button1ChangingStatusToServed);
            Controls.Add(TableStatusPaymentButton);
            Controls.Add(TableStatusOrderbutton);
            Controls.Add(labelTableShowNumbers);
            Controls.Add(labelTableBox);
            Controls.Add(listViewTableStatusOrderList);
            Controls.Add(buttonFreeingTable);
            Controls.Add(buttonOccupyingTables);
            Controls.Add(buttonReturnToTableView);
            Name = "TableStatusForm";
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
        private Button button1ChangingStatusToServed;
        private System.Windows.Forms.Timer timerRefreshs;
    }
}
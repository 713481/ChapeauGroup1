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
            lblKitchenOrders = new Label();
            lblKitchenItems = new Label();
            ListViewOrdersKitchen = new ListView();
            KITCHENORDERID = new ColumnHeader();
            KITCHENTABLEID = new ColumnHeader();
            KITCHENORDERSTIME = new ColumnHeader();
            KITCHENWAITINGTIME = new ColumnHeader();
            listViewKitchenOrderItem = new ListView();
            BARORDERID = new ColumnHeader();
            BARITEMNAME = new ColumnHeader();
            BARORDERCOUNT = new ColumnHeader();
            BARITEMSTATUS = new ColumnHeader();
            BARORDERTIME = new ColumnHeader();
            ORDERDESCRIPTION = new ColumnHeader();
            lblViewKitchenBar = new Label();
            butSetToReady = new Button();
            pictureBoxChaupauKitchenBar = new PictureBox();
            butLogOutKitchen = new Button();
            butChangeStatus = new Button();
            HistoryButton = new Button();
            RunningOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChaupauKitchenBar).BeginInit();
            SuspendLayout();
            // 
            // lblKitchenOrders
            // 
            lblKitchenOrders.AutoSize = true;
            lblKitchenOrders.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKitchenOrders.Location = new Point(23, 206);
            lblKitchenOrders.Name = "lblKitchenOrders";
            lblKitchenOrders.Size = new Size(169, 57);
            lblKitchenOrders.TabIndex = 0;
            lblKitchenOrders.Text = "Orders:";
            // 
            // lblKitchenItems
            // 
            lblKitchenItems.AutoSize = true;
            lblKitchenItems.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKitchenItems.Location = new Point(13, 594);
            lblKitchenItems.Name = "lblKitchenItems";
            lblKitchenItems.Size = new Size(289, 57);
            lblKitchenItems.TabIndex = 1;
            lblKitchenItems.Text = "Orders Items:";
            // 
            // ListViewOrdersKitchen
            // 
            ListViewOrdersKitchen.BackColor = SystemColors.MenuBar;
            ListViewOrdersKitchen.Columns.AddRange(new ColumnHeader[] { KITCHENORDERID, KITCHENTABLEID, KITCHENORDERSTIME, KITCHENWAITINGTIME });
            ListViewOrdersKitchen.FullRowSelect = true;
            ListViewOrdersKitchen.Location = new Point(308, 206);
            ListViewOrdersKitchen.Name = "ListViewOrdersKitchen";
            ListViewOrdersKitchen.Size = new Size(527, 293);
            ListViewOrdersKitchen.TabIndex = 2;
            ListViewOrdersKitchen.UseCompatibleStateImageBehavior = false;
            ListViewOrdersKitchen.View = View.Details;
            ListViewOrdersKitchen.SelectedIndexChanged += ListViewOrdersKitchen_SelectedIndexChanged;
            // 
            // KITCHENORDERID
            // 
            KITCHENORDERID.Text = "Order ID";
            KITCHENORDERID.Width = 130;
            // 
            // KITCHENTABLEID
            // 
            KITCHENTABLEID.Text = "Table ID";
            KITCHENTABLEID.Width = 130;
            // 
            // KITCHENORDERSTIME
            // 
            KITCHENORDERSTIME.Text = "Order Time";
            KITCHENORDERSTIME.Width = 130;
            // 
            // KITCHENWAITINGTIME
            // 
            KITCHENWAITINGTIME.Text = "Waiting Time";
            KITCHENWAITINGTIME.Width = 130;
            // 
            // listViewKitchenOrderItem
            // 
            listViewKitchenOrderItem.BackColor = SystemColors.MenuBar;
            listViewKitchenOrderItem.Columns.AddRange(new ColumnHeader[] { BARORDERID, BARITEMNAME, BARORDERCOUNT, BARITEMSTATUS, BARORDERTIME, ORDERDESCRIPTION });
            listViewKitchenOrderItem.FullRowSelect = true;
            listViewKitchenOrderItem.Location = new Point(308, 594);
            listViewKitchenOrderItem.Name = "listViewKitchenOrderItem";
            listViewKitchenOrderItem.Size = new Size(957, 277);
            listViewKitchenOrderItem.TabIndex = 3;
            listViewKitchenOrderItem.UseCompatibleStateImageBehavior = false;
            listViewKitchenOrderItem.View = View.Details;
            // 
            // BARORDERID
            // 
            BARORDERID.Text = "Order ID";
            BARORDERID.Width = 130;
            // 
            // BARITEMNAME
            // 
            BARITEMNAME.Text = "Item Name";
            BARITEMNAME.Width = 230;
            // 
            // BARORDERCOUNT
            // 
            BARORDERCOUNT.Text = "Order Count";
            BARORDERCOUNT.Width = 130;
            // 
            // BARITEMSTATUS
            // 
            BARITEMSTATUS.Text = "Item Status";
            BARITEMSTATUS.Width = 130;
            // 
            // BARORDERTIME
            // 
            BARORDERTIME.DisplayIndex = 5;
            BARORDERTIME.Text = "Description";
            BARORDERTIME.Width = 200;
            // 
            // ORDERDESCRIPTION
            // 
            ORDERDESCRIPTION.DisplayIndex = 4;
            ORDERDESCRIPTION.Text = "Order Time";
            ORDERDESCRIPTION.Width = 130;
            // 
            // lblViewKitchenBar
            // 
            lblViewKitchenBar.AutoSize = true;
            lblViewKitchenBar.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblViewKitchenBar.Location = new Point(488, 110);
            lblViewKitchenBar.Name = "lblViewKitchenBar";
            lblViewKitchenBar.Size = new Size(143, 67);
            lblViewKitchenBar.TabIndex = 4;
            lblViewKitchenBar.Text = "View";
            // 
            // butSetToReady
            // 
            butSetToReady.BackColor = Color.LawnGreen;
            butSetToReady.Location = new Point(71, 796);
            butSetToReady.Name = "butSetToReady";
            butSetToReady.Size = new Size(218, 75);
            butSetToReady.TabIndex = 5;
            butSetToReady.Text = "Set To Ready";
            butSetToReady.UseVisualStyleBackColor = false;
            butSetToReady.Click += butSetToReady_Click;
            // 
            // pictureBoxChaupauKitchenBar
            // 
            pictureBoxChaupauKitchenBar.Image = (Image)resources.GetObject("pictureBoxChaupauKitchenBar.Image");
            pictureBoxChaupauKitchenBar.Location = new Point(22, 12);
            pictureBoxChaupauKitchenBar.Name = "pictureBoxChaupauKitchenBar";
            pictureBoxChaupauKitchenBar.Size = new Size(134, 77);
            pictureBoxChaupauKitchenBar.TabIndex = 6;
            pictureBoxChaupauKitchenBar.TabStop = false;
            // 
            // butLogOutKitchen
            // 
            butLogOutKitchen.BackColor = Color.LightCoral;
            butLogOutKitchen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            butLogOutKitchen.Location = new Point(1061, 12);
            butLogOutKitchen.Name = "butLogOutKitchen";
            butLogOutKitchen.Size = new Size(165, 67);
            butLogOutKitchen.TabIndex = 7;
            butLogOutKitchen.Text = "Log Out";
            butLogOutKitchen.UseVisualStyleBackColor = false;
            butLogOutKitchen.Click += butLogOutKitchen_Click;
            // 
            // butChangeStatus
            // 
            butChangeStatus.BackColor = Color.Bisque;
            butChangeStatus.Location = new Point(71, 683);
            butChangeStatus.Name = "butChangeStatus";
            butChangeStatus.Size = new Size(218, 81);
            butChangeStatus.TabIndex = 8;
            butChangeStatus.Text = "Set To Prepare";
            butChangeStatus.UseVisualStyleBackColor = false;
            butChangeStatus.Click += butChangeStatus_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.BackColor = Color.Cornsilk;
            HistoryButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryButton.Location = new Point(858, 12);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(183, 67);
            HistoryButton.TabIndex = 9;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = false;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // RunningOrderButton
            // 
            RunningOrderButton.BackColor = SystemColors.ScrollBar;
            RunningOrderButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RunningOrderButton.Location = new Point(647, 12);
            RunningOrderButton.Name = "RunningOrderButton";
            RunningOrderButton.Size = new Size(188, 67);
            RunningOrderButton.TabIndex = 10;
            RunningOrderButton.Text = "Running Order";
            RunningOrderButton.UseVisualStyleBackColor = false;
            RunningOrderButton.Click += ReturnButton_Click;
            // 
            // KitchenAndBarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1277, 893);
            Controls.Add(RunningOrderButton);
            Controls.Add(HistoryButton);
            Controls.Add(butChangeStatus);
            Controls.Add(butLogOutKitchen);
            Controls.Add(pictureBoxChaupauKitchenBar);
            Controls.Add(butSetToReady);
            Controls.Add(lblViewKitchenBar);
            Controls.Add(listViewKitchenOrderItem);
            Controls.Add(ListViewOrdersKitchen);
            Controls.Add(lblKitchenItems);
            Controls.Add(lblKitchenOrders);
            Name = "KitchenAndBarView";
            Text = "KitchenAndBarView";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChaupauKitchenBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitchenOrders;
        private Label lblKitchenItems;
        private ListView ListViewOrdersKitchen;
        private ListView listViewKitchenOrderItem;
        private Label lblViewKitchenBar;
        private Button butSetToReady;
        private ColumnHeader KITCHENORDERID;
        private ColumnHeader KITCHENTABLEID;
        private ColumnHeader KITCHENORDERSTIME;
        private ColumnHeader BARORDERID;
        private ColumnHeader BARITEMNAME;
        private ColumnHeader BARORDERCOUNT;
        private ColumnHeader BARITEMSTATUS;
        private ColumnHeader ORDERDESCRIPTION;
        private ColumnHeader BARORDERTIME;
        private ColumnHeader KITCHENWAITINGTIME;
        private PictureBox pictureBoxChaupauKitchenBar;
        private Button butLogOutKitchen;
        private Button butChangeStatus;
        private Button HistoryButton;
        private Button RunningOrderButton;
    }
}
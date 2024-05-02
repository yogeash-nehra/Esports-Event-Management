namespace Assignment1
{
    partial class EventForm
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
            this.panelAddEvent = new System.Windows.Forms.Panel();
            this.txtAddStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.comboAddArenaName = new System.Windows.Forms.ComboBox();
            this.txtaddCapacity = new System.Windows.Forms.DomainUpDown();
            this.comboAddStatus = new System.Windows.Forms.ComboBox();
            this.txtAddArenaID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddEventName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArenaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArenaID = new System.Windows.Forms.TextBox();
            this.lblArenaID = new System.Windows.Forms.Label();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpdateEventName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpdateEventID = new System.Windows.Forms.TextBox();
            this.txtUpdateArenaID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUpdateArenaName = new System.Windows.Forms.TextBox();
            this.panelUpdateevent = new System.Windows.Forms.Panel();
            this.txtUpdateEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateCapacity = new System.Windows.Forms.DomainUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelAddEvent.SuspendLayout();
            this.panelUpdateevent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddEvent
            // 
            this.panelAddEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddEvent.Controls.Add(this.txtAddStartTime);
            this.panelAddEvent.Controls.Add(this.btnCancel);
            this.panelAddEvent.Controls.Add(this.btnSaveEvent);
            this.panelAddEvent.Controls.Add(this.comboAddArenaName);
            this.panelAddEvent.Controls.Add(this.txtaddCapacity);
            this.panelAddEvent.Controls.Add(this.txtAddArenaID);
            this.panelAddEvent.Controls.Add(this.label9);
            this.panelAddEvent.Controls.Add(this.comboAddStatus);
            this.panelAddEvent.Controls.Add(this.label10);
            this.panelAddEvent.Controls.Add(this.txtAddEventName);
            this.panelAddEvent.Controls.Add(this.label7);
            this.panelAddEvent.Controls.Add(this.label11);
            this.panelAddEvent.Controls.Add(this.label8);
            this.panelAddEvent.Location = new System.Drawing.Point(387, 43);
            this.panelAddEvent.Name = "panelAddEvent";
            this.panelAddEvent.Size = new System.Drawing.Size(435, 466);
            this.panelAddEvent.TabIndex = 48;
            this.panelAddEvent.Visible = false;
            // 
            // txtAddStartTime
            // 
            this.txtAddStartTime.Checked = false;
            this.txtAddStartTime.CustomFormat = "HH:mm";
            this.txtAddStartTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtAddStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAddStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddStartTime.Location = new System.Drawing.Point(169, 307);
            this.txtAddStartTime.Name = "txtAddStartTime";
            this.txtAddStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddStartTime.Size = new System.Drawing.Size(232, 26);
            this.txtAddStartTime.TabIndex = 32;
            this.txtAddStartTime.Value = new System.DateTime(2024, 5, 1, 11, 8, 50, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 42);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(33, 390);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(167, 42);
            this.btnSaveEvent.TabIndex = 30;
            this.btnSaveEvent.Text = "Save Meeting";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // comboAddArenaName
            // 
            this.comboAddArenaName.FormattingEnabled = true;
            this.comboAddArenaName.Location = new System.Drawing.Point(222, 110);
            this.comboAddArenaName.Name = "comboAddArenaName";
            this.comboAddArenaName.Size = new System.Drawing.Size(178, 28);
            this.comboAddArenaName.TabIndex = 29;
            // 
            // txtaddCapacity
            // 
            this.txtaddCapacity.Location = new System.Drawing.Point(166, 246);
            this.txtaddCapacity.Name = "txtaddCapacity";
            this.txtaddCapacity.Size = new System.Drawing.Size(100, 26);
            this.txtaddCapacity.TabIndex = 28;
            // 
            // comboAddStatus
            // 
            this.comboAddStatus.FormattingEnabled = true;
            this.comboAddStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Unconfirmed",
            "Cancelled"});
            this.comboAddStatus.Location = new System.Drawing.Point(166, 178);
            this.comboAddStatus.Name = "comboAddStatus";
            this.comboAddStatus.Size = new System.Drawing.Size(234, 28);
            this.comboAddStatus.TabIndex = 27;
            // 
            // txtAddArenaID
            // 
            this.txtAddArenaID.FormattingEnabled = true;
            this.txtAddArenaID.Location = new System.Drawing.Point(166, 110);
            this.txtAddArenaID.Name = "txtAddArenaID";
            this.txtAddArenaID.Size = new System.Drawing.Size(50, 28);
            this.txtAddArenaID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Capacity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Event Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Arena:";
            // 
            // txtAddEventName
            // 
            this.txtAddEventName.Location = new System.Drawing.Point(166, 44);
            this.txtAddEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddEventName.Name = "txtAddEventName";
            this.txtAddEventName.Size = new System.Drawing.Size(234, 26);
            this.txtAddEventName.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Event Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(806, 613);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(188, 52);
            this.btnReturn.TabIndex = 47;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtEventDate
            // 
            this.txtEventDate.Checked = false;
            this.txtEventDate.CustomFormat = "";
            this.txtEventDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtEventDate.Enabled = false;
            this.txtEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEventDate.Location = new System.Drawing.Point(542, 428);
            this.txtEventDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(196, 26);
            this.txtEventDate.TabIndex = 35;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(542, 121);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(196, 26);
            this.txtEventName.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Event Name:";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(542, 53);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(196, 26);
            this.txtEventID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Event ID:";
            // 
            // txtArenaName
            // 
            this.txtArenaName.Location = new System.Drawing.Point(544, 240);
            this.txtArenaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.ReadOnly = true;
            this.txtArenaName.Size = new System.Drawing.Size(196, 26);
            this.txtArenaName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Arena Name:";
            // 
            // txtArenaID
            // 
            this.txtArenaID.Location = new System.Drawing.Point(544, 177);
            this.txtArenaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArenaID.Name = "txtArenaID";
            this.txtArenaID.ReadOnly = true;
            this.txtArenaID.Size = new System.Drawing.Size(196, 26);
            this.txtArenaID.TabIndex = 27;
            // 
            // lblArenaID
            // 
            this.lblArenaID.AutoSize = true;
            this.lblArenaID.Location = new System.Drawing.Point(429, 187);
            this.lblArenaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArenaID.Name = "lblArenaID";
            this.lblArenaID.Size = new System.Drawing.Size(77, 20);
            this.lblArenaID.TabIndex = 26;
            this.lblArenaID.Text = "Arena ID:";
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.ItemHeight = 20;
            this.lstEvent.Location = new System.Drawing.Point(65, 47);
            this.lstEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(256, 424);
            this.lstEvent.TabIndex = 25;
            this.lstEvent.SelectedIndexChanged += new System.EventHandler(this.lstEvent_SelectedIndexChanged);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(806, 533);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(188, 52);
            this.btnDeleteEvent.TabIndex = 44;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Location = new System.Drawing.Point(609, 533);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(188, 52);
            this.btnUpdateEvent.TabIndex = 43;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(412, 533);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(188, 52);
            this.btnAddEvent.TabIndex = 42;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(216, 533);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 52);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(20, 533);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(188, 52);
            this.btnPrevious.TabIndex = 40;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(542, 359);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(196, 26);
            this.txtCapacity.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Capacity:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(542, 295);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(196, 26);
            this.txtStatus.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Event Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 77);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Event Name:";
            // 
            // txtUpdateEventName
            // 
            this.txtUpdateEventName.Location = new System.Drawing.Point(164, 74);
            this.txtUpdateEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateEventName.Name = "txtUpdateEventName";
            this.txtUpdateEventName.Size = new System.Drawing.Size(234, 26);
            this.txtUpdateEventName.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 129);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Arena ID:";
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(33, 390);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(167, 42);
            this.btnUpdateSave.TabIndex = 30;
            this.btnUpdateSave.Text = "Save Changes";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(222, 390);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(149, 42);
            this.btnUpdateCancel.TabIndex = 31;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Event ID:";
            // 
            // txtUpdateEventID
            // 
            this.txtUpdateEventID.Location = new System.Drawing.Point(166, 22);
            this.txtUpdateEventID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateEventID.Name = "txtUpdateEventID";
            this.txtUpdateEventID.ReadOnly = true;
            this.txtUpdateEventID.Size = new System.Drawing.Size(234, 26);
            this.txtUpdateEventID.TabIndex = 34;
            // 
            // txtUpdateArenaID
            // 
            this.txtUpdateArenaID.Location = new System.Drawing.Point(164, 123);
            this.txtUpdateArenaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateArenaID.Name = "txtUpdateArenaID";
            this.txtUpdateArenaID.ReadOnly = true;
            this.txtUpdateArenaID.Size = new System.Drawing.Size(234, 26);
            this.txtUpdateArenaID.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(57, 178);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Arena Name:";
            // 
            // txtUpdateArenaName
            // 
            this.txtUpdateArenaName.Location = new System.Drawing.Point(164, 172);
            this.txtUpdateArenaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateArenaName.Name = "txtUpdateArenaName";
            this.txtUpdateArenaName.ReadOnly = true;
            this.txtUpdateArenaName.Size = new System.Drawing.Size(234, 26);
            this.txtUpdateArenaName.TabIndex = 38;
            // 
            // panelUpdateevent
            // 
            this.panelUpdateevent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateevent.Controls.Add(this.txtUpdateEventDate);
            this.panelUpdateevent.Controls.Add(this.txtUpdateCapacity);
            this.panelUpdateevent.Controls.Add(this.label12);
            this.panelUpdateevent.Controls.Add(this.txtUpdateStatus);
            this.panelUpdateevent.Controls.Add(this.label13);
            this.panelUpdateevent.Controls.Add(this.label14);
            this.panelUpdateevent.Controls.Add(this.txtUpdateArenaName);
            this.panelUpdateevent.Controls.Add(this.label18);
            this.panelUpdateevent.Controls.Add(this.txtUpdateArenaID);
            this.panelUpdateevent.Controls.Add(this.txtUpdateEventID);
            this.panelUpdateevent.Controls.Add(this.label17);
            this.panelUpdateevent.Controls.Add(this.btnUpdateCancel);
            this.panelUpdateevent.Controls.Add(this.btnUpdateSave);
            this.panelUpdateevent.Controls.Add(this.label15);
            this.panelUpdateevent.Controls.Add(this.txtUpdateEventName);
            this.panelUpdateevent.Controls.Add(this.label16);
            this.panelUpdateevent.Location = new System.Drawing.Point(383, 47);
            this.panelUpdateevent.Name = "panelUpdateevent";
            this.panelUpdateevent.Size = new System.Drawing.Size(435, 466);
            this.panelUpdateevent.TabIndex = 49;
            this.panelUpdateevent.Visible = false;
            // 
            // txtUpdateEventDate
            // 
            this.txtUpdateEventDate.Checked = false;
            this.txtUpdateEventDate.CustomFormat = "HH:mm";
            this.txtUpdateEventDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtUpdateEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtUpdateEventDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUpdateEventDate.Location = new System.Drawing.Point(161, 330);
            this.txtUpdateEventDate.Name = "txtUpdateEventDate";
            this.txtUpdateEventDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUpdateEventDate.Size = new System.Drawing.Size(232, 26);
            this.txtUpdateEventDate.TabIndex = 44;
            this.txtUpdateEventDate.Value = new System.DateTime(2024, 5, 1, 11, 8, 50, 0);
            // 
            // txtUpdateCapacity
            // 
            this.txtUpdateCapacity.Location = new System.Drawing.Point(158, 269);
            this.txtUpdateCapacity.Name = "txtUpdateCapacity";
            this.txtUpdateCapacity.Size = new System.Drawing.Size(100, 26);
            this.txtUpdateCapacity.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 336);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Event Date:";
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.FormattingEnabled = true;
            this.txtUpdateStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Unconfirmed",
            "Cancelled"});
            this.txtUpdateStatus.Location = new System.Drawing.Point(161, 220);
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.Size = new System.Drawing.Size(234, 28);
            this.txtUpdateStatus.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 269);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Capacity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 223);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Status:";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 704);
            this.Controls.Add(this.panelAddEvent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panelUpdateevent);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArenaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArenaID);
            this.Controls.Add(this.lblArenaID);
            this.Controls.Add(this.lstEvent);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Maintenance";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panelAddEvent.ResumeLayout(false);
            this.panelAddEvent.PerformLayout();
            this.panelUpdateevent.ResumeLayout(false);
            this.panelUpdateevent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddEvent;
        private System.Windows.Forms.DateTimePicker txtAddStartTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.ComboBox comboAddArenaName;
        private System.Windows.Forms.DomainUpDown txtaddCapacity;
        private System.Windows.Forms.ComboBox comboAddStatus;
        private System.Windows.Forms.ComboBox txtAddArenaID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddEventName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker txtEventDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArenaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArenaID;
        private System.Windows.Forms.Label lblArenaID;
        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUpdateEventName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpdateEventID;
        private System.Windows.Forms.TextBox txtUpdateArenaID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUpdateArenaName;
        private System.Windows.Forms.Panel panelUpdateevent;
        private System.Windows.Forms.DateTimePicker txtUpdateEventDate;
        private System.Windows.Forms.DomainUpDown txtUpdateCapacity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtUpdateStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
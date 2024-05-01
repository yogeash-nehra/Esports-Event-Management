namespace Assignment1
{
    partial class ChallengeForm
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
            this.lstChallenge = new System.Windows.Forms.ListBox();
            this.lblChallengeID = new System.Windows.Forms.Label();
            this.txtChallengeID = new System.Windows.Forms.TextBox();
            this.txtChallengeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddChlng = new System.Windows.Forms.Button();
            this.btnUpdateChlnge = new System.Windows.Forms.Button();
            this.btnDeleteChlnge = new System.Windows.Forms.Button();
            this.btnChlngeFinish = new System.Windows.Forms.Button();
            this.btnChlngeComplete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelAddChallenge = new System.Windows.Forms.Panel();
            this.txtAddStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChlnge = new System.Windows.Forms.Button();
            this.comboAddEventName = new System.Windows.Forms.ComboBox();
            this.addCapacity = new System.Windows.Forms.DomainUpDown();
            this.comboAddStatus = new System.Windows.Forms.ComboBox();
            this.comboAddEventID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddChallengeName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelAddChallenge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstChallenge
            // 
            this.lstChallenge.FormattingEnabled = true;
            this.lstChallenge.ItemHeight = 20;
            this.lstChallenge.Location = new System.Drawing.Point(48, 54);
            this.lstChallenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstChallenge.Name = "lstChallenge";
            this.lstChallenge.Size = new System.Drawing.Size(256, 424);
            this.lstChallenge.TabIndex = 0;
            // 
            // lblChallengeID
            // 
            this.lblChallengeID.AutoSize = true;
            this.lblChallengeID.Location = new System.Drawing.Point(410, 55);
            this.lblChallengeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChallengeID.Name = "lblChallengeID";
            this.lblChallengeID.Size = new System.Drawing.Size(105, 20);
            this.lblChallengeID.TabIndex = 1;
            this.lblChallengeID.Text = "Challenge ID:";
            // 
            // txtChallengeID
            // 
            this.txtChallengeID.Location = new System.Drawing.Point(525, 45);
            this.txtChallengeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChallengeID.Name = "txtChallengeID";
            this.txtChallengeID.ReadOnly = true;
            this.txtChallengeID.Size = new System.Drawing.Size(196, 26);
            this.txtChallengeID.TabIndex = 2;
            // 
            // txtChallengeName
            // 
            this.txtChallengeName.Location = new System.Drawing.Point(525, 108);
            this.txtChallengeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChallengeName.Name = "txtChallengeName";
            this.txtChallengeName.ReadOnly = true;
            this.txtChallengeName.Size = new System.Drawing.Size(196, 26);
            this.txtChallengeName.TabIndex = 4;
            this.txtChallengeName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Challenge Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(525, 172);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(196, 26);
            this.txtEventID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event ID:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(525, 240);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(196, 26);
            this.txtEventName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Event Name:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Checked = false;
            this.txtStartTime.CustomFormat = "HH:mm";
            this.txtStartTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartTime.Location = new System.Drawing.Point(525, 312);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(196, 26);
            this.txtStartTime.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Time:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(525, 385);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(196, 26);
            this.txtStatus.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(525, 449);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(196, 26);
            this.txtCapacity.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacity:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(44, 542);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(188, 52);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(240, 542);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 52);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddChlng
            // 
            this.btnAddChlng.Location = new System.Drawing.Point(436, 542);
            this.btnAddChlng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddChlng.Name = "btnAddChlng";
            this.btnAddChlng.Size = new System.Drawing.Size(188, 52);
            this.btnAddChlng.TabIndex = 17;
            this.btnAddChlng.Text = "Add Challenge";
            this.btnAddChlng.UseVisualStyleBackColor = true;
            this.btnAddChlng.Click += new System.EventHandler(this.btnAddChlng_Click);
            // 
            // btnUpdateChlnge
            // 
            this.btnUpdateChlnge.Location = new System.Drawing.Point(633, 542);
            this.btnUpdateChlnge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateChlnge.Name = "btnUpdateChlnge";
            this.btnUpdateChlnge.Size = new System.Drawing.Size(188, 52);
            this.btnUpdateChlnge.TabIndex = 18;
            this.btnUpdateChlnge.Text = "Update Challenge";
            this.btnUpdateChlnge.UseVisualStyleBackColor = true;
            this.btnUpdateChlnge.Click += new System.EventHandler(this.btnUpdateChlnge_Click);
            // 
            // btnDeleteChlnge
            // 
            this.btnDeleteChlnge.Location = new System.Drawing.Point(830, 542);
            this.btnDeleteChlnge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteChlnge.Name = "btnDeleteChlnge";
            this.btnDeleteChlnge.Size = new System.Drawing.Size(188, 52);
            this.btnDeleteChlnge.TabIndex = 19;
            this.btnDeleteChlnge.Text = "Delete Challenge";
            this.btnDeleteChlnge.UseVisualStyleBackColor = true;
            this.btnDeleteChlnge.Click += new System.EventHandler(this.btnDeleteChlnge_Click);
            // 
            // btnChlngeFinish
            // 
            this.btnChlngeFinish.Location = new System.Drawing.Point(44, 622);
            this.btnChlngeFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChlngeFinish.Name = "btnChlngeFinish";
            this.btnChlngeFinish.Size = new System.Drawing.Size(286, 52);
            this.btnChlngeFinish.TabIndex = 20;
            this.btnChlngeFinish.Text = "Mark Challenge as Finished";
            this.btnChlngeFinish.UseVisualStyleBackColor = true;
            this.btnChlngeFinish.Click += new System.EventHandler(this.btnChlngeFinish_Click);
            // 
            // btnChlngeComplete
            // 
            this.btnChlngeComplete.Location = new System.Drawing.Point(399, 622);
            this.btnChlngeComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChlngeComplete.Name = "btnChlngeComplete";
            this.btnChlngeComplete.Size = new System.Drawing.Size(297, 52);
            this.btnChlngeComplete.TabIndex = 21;
            this.btnChlngeComplete.Text = "Mark Challenge as Complete";
            this.btnChlngeComplete.UseVisualStyleBackColor = true;
            this.btnChlngeComplete.Click += new System.EventHandler(this.btnChlngeComplete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(830, 622);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(188, 52);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelAddChallenge
            // 
            this.panelAddChallenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddChallenge.Controls.Add(this.txtAddStartTime);
            this.panelAddChallenge.Controls.Add(this.btnCancel);
            this.panelAddChallenge.Controls.Add(this.btnSaveChlnge);
            this.panelAddChallenge.Controls.Add(this.comboAddEventName);
            this.panelAddChallenge.Controls.Add(this.addCapacity);
            this.panelAddChallenge.Controls.Add(this.comboAddStatus);
            this.panelAddChallenge.Controls.Add(this.comboAddEventID);
            this.panelAddChallenge.Controls.Add(this.label7);
            this.panelAddChallenge.Controls.Add(this.label8);
            this.panelAddChallenge.Controls.Add(this.label9);
            this.panelAddChallenge.Controls.Add(this.label10);
            this.panelAddChallenge.Controls.Add(this.txtAddChallengeName);
            this.panelAddChallenge.Controls.Add(this.label11);
            this.panelAddChallenge.Location = new System.Drawing.Point(574, 12);
            this.panelAddChallenge.Name = "panelAddChallenge";
            this.panelAddChallenge.Size = new System.Drawing.Size(435, 466);
            this.panelAddChallenge.TabIndex = 23;
            this.panelAddChallenge.Visible = false;
            // 
            // txtAddStartTime
            // 
            this.txtAddStartTime.Checked = false;
            this.txtAddStartTime.CustomFormat = "HH:mm";
            this.txtAddStartTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtAddStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtAddStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddStartTime.Location = new System.Drawing.Point(166, 175);
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
            // btnSaveChlnge
            // 
            this.btnSaveChlnge.Location = new System.Drawing.Point(33, 390);
            this.btnSaveChlnge.Name = "btnSaveChlnge";
            this.btnSaveChlnge.Size = new System.Drawing.Size(167, 42);
            this.btnSaveChlnge.TabIndex = 30;
            this.btnSaveChlnge.Text = "Save Challenge";
            this.btnSaveChlnge.UseVisualStyleBackColor = true;
            this.btnSaveChlnge.Click += new System.EventHandler(this.btnSaveChlnge_Click);
            // 
            // comboAddEventName
            // 
            this.comboAddEventName.FormattingEnabled = true;
            this.comboAddEventName.Location = new System.Drawing.Point(222, 110);
            this.comboAddEventName.Name = "comboAddEventName";
            this.comboAddEventName.Size = new System.Drawing.Size(178, 28);
            this.comboAddEventName.TabIndex = 29;
            // 
            // addCapacity
            // 
            this.addCapacity.Location = new System.Drawing.Point(166, 311);
            this.addCapacity.Name = "addCapacity";
            this.addCapacity.Size = new System.Drawing.Size(100, 26);
            this.addCapacity.TabIndex = 28;
            // 
            // comboAddStatus
            // 
            this.comboAddStatus.FormattingEnabled = true;
            this.comboAddStatus.Location = new System.Drawing.Point(166, 243);
            this.comboAddStatus.Name = "comboAddStatus";
            this.comboAddStatus.Size = new System.Drawing.Size(234, 28);
            this.comboAddStatus.TabIndex = 27;
            // 
            // comboAddEventID
            // 
            this.comboAddEventID.FormattingEnabled = true;
            this.comboAddEventID.Location = new System.Drawing.Point(166, 110);
            this.comboAddEventID.Name = "comboAddEventID";
            this.comboAddEventID.Size = new System.Drawing.Size(50, 28);
            this.comboAddEventID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Capacity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Start Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Event ID:";
            // 
            // txtAddChallengeName
            // 
            this.txtAddChallengeName.Location = new System.Drawing.Point(166, 44);
            this.txtAddChallengeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddChallengeName.Name = "txtAddChallengeName";
            this.txtAddChallengeName.Size = new System.Drawing.Size(234, 26);
            this.txtAddChallengeName.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Challenge Name:";
            // 
            // ChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelAddChallenge);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnChlngeComplete);
            this.Controls.Add(this.btnChlngeFinish);
            this.Controls.Add(this.btnDeleteChlnge);
            this.Controls.Add(this.btnUpdateChlnge);
            this.Controls.Add(this.btnAddChlng);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChallengeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChallengeID);
            this.Controls.Add(this.lblChallengeID);
            this.Controls.Add(this.lstChallenge);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChallengeForm";
            this.Text = "Challenge Maintenance";
            this.panelAddChallenge.ResumeLayout(false);
            this.panelAddChallenge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChallenge;
        private System.Windows.Forms.Label lblChallengeID;
        private System.Windows.Forms.TextBox txtChallengeID;
        private System.Windows.Forms.TextBox txtChallengeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddChlng;
        private System.Windows.Forms.Button btnUpdateChlnge;
        private System.Windows.Forms.Button btnDeleteChlnge;
        private System.Windows.Forms.Button btnChlngeFinish;
        private System.Windows.Forms.Button btnChlngeComplete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panelAddChallenge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddChallengeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown addCapacity;
        private System.Windows.Forms.ComboBox comboAddStatus;
        private System.Windows.Forms.ComboBox comboAddEventID;
        private System.Windows.Forms.ComboBox comboAddEventName;
        private System.Windows.Forms.Button btnSaveChlnge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker txtAddStartTime;
    }
}
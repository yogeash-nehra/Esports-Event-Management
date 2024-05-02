namespace Assignment1
{
    partial class CompetitorChallengeForm
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
            this.components = new System.ComponentModel.Container();
            this.dgChallenge = new System.Windows.Forms.DataGridView();
            this.dsNZST = new Assignment1.dsNZST();
            this.dsNZSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHALLENGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgCompetitor = new System.Windows.Forms.DataGridView();
            this.cOMPETITORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgEntry = new System.Windows.Forms.DataGridView();
            this.eNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNTRYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddEntry = new FontAwesome.Sharp.IconButton();
            this.btnRemoveEntry = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgChallenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHALLENGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETITORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRYBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChallenge
            // 
            this.dgChallenge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChallenge.Location = new System.Drawing.Point(32, 60);
            this.dgChallenge.Name = "dgChallenge";
            this.dgChallenge.RowHeadersWidth = 62;
            this.dgChallenge.RowTemplate.Height = 28;
            this.dgChallenge.Size = new System.Drawing.Size(893, 348);
            this.dgChallenge.TabIndex = 0;
            this.dgChallenge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChallenge_CellContentClick);
            // 
            // dsNZST
            // 
            this.dsNZST.DataSetName = "dsNZST";
            this.dsNZST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsNZSTBindingSource
            // 
            this.dsNZSTBindingSource.DataSource = this.dsNZST;
            this.dsNZSTBindingSource.Position = 0;
            // 
            // cHALLENGEBindingSource
            // 
            this.cHALLENGEBindingSource.DataMember = "CHALLENGE";
            this.cHALLENGEBindingSource.DataSource = this.dsNZSTBindingSource;
            // 
            // dgCompetitor
            // 
            this.dgCompetitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompetitor.Location = new System.Drawing.Point(32, 462);
            this.dgCompetitor.Name = "dgCompetitor";
            this.dgCompetitor.RowHeadersWidth = 62;
            this.dgCompetitor.RowTemplate.Height = 28;
            this.dgCompetitor.Size = new System.Drawing.Size(893, 317);
            this.dgCompetitor.TabIndex = 1;
            // 
            // cOMPETITORBindingSource
            // 
            this.cOMPETITORBindingSource.DataMember = "COMPETITOR";
            this.cOMPETITORBindingSource.DataSource = this.dsNZSTBindingSource;
            // 
            // dgEntry
            // 
            this.dgEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntry.Location = new System.Drawing.Point(998, 60);
            this.dgEntry.Name = "dgEntry";
            this.dgEntry.RowHeadersWidth = 62;
            this.dgEntry.RowTemplate.Height = 28;
            this.dgEntry.Size = new System.Drawing.Size(603, 348);
            this.dgEntry.TabIndex = 2;
            // 
            // eNTRYBindingSource
            // 
            this.eNTRYBindingSource.DataMember = "ENTRY";
            this.eNTRYBindingSource.DataSource = this.dsNZSTBindingSource;
            // 
            // eNTRYBindingSource1
            // 
            this.eNTRYBindingSource1.DataMember = "ENTRY";
            this.eNTRYBindingSource1.DataSource = this.dsNZSTBindingSource;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddEntry.IconColor = System.Drawing.Color.Black;
            this.btnAddEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEntry.Location = new System.Drawing.Point(1029, 696);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(170, 61);
            this.btnAddEntry.TabIndex = 3;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemoveEntry.IconColor = System.Drawing.Color.Black;
            this.btnRemoveEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveEntry.Location = new System.Drawing.Point(1205, 696);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(170, 61);
            this.btnRemoveEntry.TabIndex = 4;
            this.btnRemoveEntry.Text = "Remove Entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(1381, 696);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 61);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1110, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(1176, 476);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(211, 26);
            this.txtEventName.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1176, 529);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(211, 26);
            this.txtStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Challenge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Competitor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Entry";
            // 
            // CompetitorChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 819);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.dgEntry);
            this.Controls.Add(this.dgCompetitor);
            this.Controls.Add(this.dgChallenge);
            this.Name = "CompetitorChallengeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Competitor into Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.dgChallenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHALLENGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETITORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRYBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChallenge;
        private System.Windows.Forms.BindingSource cOMPETITORBindingSource;
        private System.Windows.Forms.BindingSource dsNZSTBindingSource;
        private dsNZST dsNZST;
        private System.Windows.Forms.BindingSource cHALLENGEBindingSource;
        private System.Windows.Forms.DataGridView dgCompetitor;
        private System.Windows.Forms.DataGridView dgEntry;
        private System.Windows.Forms.BindingSource eNTRYBindingSource1;
        private System.Windows.Forms.BindingSource eNTRYBindingSource;
        private FontAwesome.Sharp.IconButton btnAddEntry;
        private FontAwesome.Sharp.IconButton btnRemoveEntry;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace Assignment1
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.button5);
            this.grpMaintenance.Controls.Add(this.button4);
            this.grpMaintenance.Controls.Add(this.button3);
            this.grpMaintenance.Controls.Add(this.button2);
            this.grpMaintenance.Controls.Add(this.button1);
            this.grpMaintenance.Location = new System.Drawing.Point(48, 52);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(300, 372);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "Enter Competetior into Challenge ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Competetior Maintenance";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Challenge Maintenance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Event Maintenance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Arena Maintenance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.button8);
            this.grpReporting.Controls.Add(this.button7);
            this.grpReporting.Controls.Add(this.button6);
            this.grpReporting.Location = new System.Drawing.Point(444, 65);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(298, 358);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(50, 294);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(207, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(207, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "Competitor Report";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(50, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Event Report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}


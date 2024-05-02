namespace Assignment1
{
    partial class EventReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventReportForm));
            this.btnPrintPreviewEvent = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintPreviewEvent
            // 
            this.btnPrintPreviewEvent.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrintPreviewEvent.IconColor = System.Drawing.Color.Black;
            this.btnPrintPreviewEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrintPreviewEvent.Location = new System.Drawing.Point(42, 54);
            this.btnPrintPreviewEvent.Name = "btnPrintPreviewEvent";
            this.btnPrintPreviewEvent.Size = new System.Drawing.Size(163, 51);
            this.btnPrintPreviewEvent.TabIndex = 0;
            this.btnPrintPreviewEvent.Text = "Print Preview";
            this.btnPrintPreviewEvent.UseVisualStyleBackColor = true;
            this.btnPrintPreviewEvent.Click += new System.EventHandler(this.btnPrintPreviewEvent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(289, 54);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(163, 51);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // EventReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 214);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintPreviewEvent);
            this.Name = "EventReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Report ";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPrintPreviewEvent;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class ArenaReportForm : Form
    {
        DataModule DM;
        MainForm frmMenu;
        CurrencyManager currencyManager;
        private string arena_Report;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private int currentPage = 0;
        private string[] pages;
        private bool hasEvent =false;
        public ArenaReportForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;
            printDocument = new PrintDocument();
            toBePrinted();
            printDocument.PrintPage += printDocument_PrintPage;

        }

        private void toBePrinted()
        {
            // Prints report about all the events happening in all the arena

            foreach (DataRow row in DM.dsNZST.Tables["Arena"].Rows)
            {
                arena_Report += " \r\n \r\n \r\n";
                hasEvent = false;

                arena_Report += "Arena ID:   " + row["ArenaID"] + " \r\n";
                arena_Report += "Arena Name:    " + row["ArenaName"] + " \r\n";
                arena_Report += "Arena Address: \r\n";
                arena_Report += row["StreetAddress"] + " \r\n";
                arena_Report += row["Suburb"] + " \r\n";
                arena_Report += row["City"] + " \r\n";
                arena_Report += " \r\n \r\n";
                foreach (DataRow row2 in DM.dsNZST.Tables["Event"].Rows)
                {
                    if (row["ArenaID"].ToString() == row2["ArenaID"].ToString())
                    {
                        hasEvent = true;
                        arena_Report += "Event Name: "+ row2["EventName"] +"\r\n";
                        arena_Report += "Event Date: " + ((DateTime)row2["EventDate"]).ToString("dd/MM/yyyy") + " \r\n \r\n";

                    }
                }
                arena_Report += " \r\n \r\n";
                if (!hasEvent)
                {
                    arena_Report += "This Arena has no upcoming Events. \r\nPlease check later for updates !!";
                }
                arena_Report += " \r\n \r\n [Next]";
            }
            // Split comp Report into pages
            pages = arena_Report.Split(new string[] { "[Next]" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //return btn
            Close();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            Graphics g = e.Graphics;

            // Split and print the current page
            if (currentPage < pages.Length)
            {
                string[] lines = pages[currentPage].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                    y += lineHeight;
                }
                // Next Page
                currentPage++;
                e.HasMorePages = currentPage < pages.Length;

            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //Print Preview
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
        }
    }
}

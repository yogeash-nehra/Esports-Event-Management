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
    public partial class EventReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private string event_Report;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private int currentPage = 0;
        private string[] pages;
        public EventReportForm(DataModule DM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = DM;
            this.frmMenu = mnu;
            printDocument = new PrintDocument();
            toBePrinted();
            printDocument.PrintPage += printDocument_PrintPage;
        }

        private void toBePrinted()
        {
            event_Report += "";

            //For each loop to get data
            foreach (DataRow row in DM.dsNZST.Tables["Event"].Rows)
            {
                event_Report += "\r\n \r\n \r\n";
                event_Report += "Event Id:    " + row["EventID"] + "\r\n";
                event_Report += " \r\n";
                event_Report += " \r\n";
                event_Report += row["EventName"] +"\r\n";
                foreach(DataRow row2 in DM.dsNZST.Tables["Arena"].Rows)
                {
                    if (row["ArenaID"].ToString() == row2["ArenaID"].ToString())
                    {
                        //Arena Name, Street Address, Suburb, City
                        event_Report += row2["ArenaName"] + "\r\n";
                        event_Report += row2["StreetAddress"] + "\r\n";
                        event_Report += row2["Suburb"] + "\r\n";
                        event_Report += row2["City"] + "\r\n";
                    }                    
                }
                event_Report += " \r\n";
                event_Report += "EventDate: " + ((DateTime)row["EventDate"]).ToString("dd/MM/yyyy") + " \r\n";
                event_Report += " \r\n";
                event_Report += "Challenges: \r\n";
                event_Report += " \r\n";
                event_Report += string.Format("{0,-25} {1,-35} {2}", "ID", "Name", "Time") + " \r\n";
                event_Report += " \r\n";
                string challengeString = "";
                foreach (DataRow row3 in DM.dsNZST.Tables["Challenge"].Rows)
                {
                    if (row["EventID"].ToString() == row3["EventID"].ToString())
                    {
                        //Challenge ID, Challenge Name, Challenge Start time
                        challengeString += string.Format("{0,-25} {1,-35} {2}", 
                            row3["ChallengeID"], 
                            row3["ChallengeName"], 
                            ((DateTime)row3["StartTime"]).ToString("HH:mm")) + "\r\n";
                    }
                }
                event_Report += challengeString + "\r\n";
                event_Report += "\r\n[Next]";

                // Split  Report into pages
                pages = event_Report.Split(new string[] { "[Next]" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return btn
            Close();
        }

        private void btnPrintPreviewEvent_Click(object sender, EventArgs e)
        {
            //Print Preview
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();

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
    }
}

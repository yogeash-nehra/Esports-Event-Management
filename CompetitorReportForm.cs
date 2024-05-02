using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Assignment1
{
    public partial class CompetitorReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private string comp_Report;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private int currentPage = 0;
        private string[] pages;

        public CompetitorReportForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;
            printDocument = new PrintDocument();
            toBePrinted();
            printDocument.PrintPage += printDocument_PrintPage;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void toBePrinted()
        {
            comp_Report = "";

            // For Each loop to get the data
            foreach (DataRow row in DM.dsNZST.Tables["Competitor"].Rows)
            {
                comp_Report += "\r\n \r\n \r\n";
                comp_Report += "Competitor ID:   " + row["CompetitorID"] + "\r\n";
                comp_Report += "\r\n";
                comp_Report += "Username:      " + row["Username"] + "\r\n";
                comp_Report += "Name:    " + row["Firstname"] + " " + row["LastName"] + "\r\n";
                comp_Report += "Gender:  " + row["Gender"] + "\r\n";
                comp_Report += "Date of Birth:  " + row["DateOfBirth"] + "\r\n";
                comp_Report += "Email:      " + row["EmailAddress"] + "\r\n";
                comp_Report += "\r\n";
                comp_Report += "Entries: " + "\r\n";
                comp_Report += "\r\n";
                string challengeString = "";
                comp_Report += string.Format("{0,-25} {1,-35} {2}", "Challenge ID", "Challenge Name", "Start Time") + "\r\n";
                comp_Report += "\r\n";

                foreach (DataRow row2 in DM.dsNZST.Tables["Entry"].Rows)
                {
                    if (row["CompetitorID"].ToString() == row2["CompetitorID"].ToString())
                    {
                        //ChallengeID, ChallengeName, StartTime
                        string reqChallengeID = row2["ChallengeID"].ToString();
                        foreach (DataRow row3 in DM.dsNZST.Tables["Challenge"].Rows)
                        {
                            if (row3["ChallengeID"].ToString() == reqChallengeID)
                            {
                                DateTime startTime = (DateTime)row3["StartTime"];
                                string formattedStartTime = startTime.ToString("HH:mm");
                                challengeString += string.Format("{0,-25} {1,-35} {2}",
                                    row3["ChallengeID"],
                                    row3["ChallengeName"],
                                    ((DateTime)row3["StartTime"]).ToString("HH:mm")) + "\r\n";
                            }
                        }

                    }
                }
                comp_Report += challengeString + "\r\n";
                comp_Report += "\r\n[Next]";
            }

            // Split comp Report into pages
            pages = comp_Report.Split(new string[] { "[Next]" }, StringSplitOptions.RemoveEmptyEntries);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class CompetitorReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private string comp_Report;

        
        public CompetitorReportForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void toBePrinted() {
            
            comp_Report = "";

            foreach (DataRow row in DM.dsNZST.Tables["Competitor"].Rows)
            {
                comp_Report += "Competitor ID: " + row["CompetitorID"] + "\r\n";
                comp_Report += "Username:   " + row["Username"] +"\r\n";

            }
        }
    }
}

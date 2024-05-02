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
    public partial class CompetitorChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManagerEntry;
        private CurrencyManager currencyManagerCompetitor;
        private CurrencyManager currencyManagerChallenge;
        public CompetitorChallengeForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;

            currencyManagerEntry = (CurrencyManager)this.BindingContext[DM.dsNZST, "Entry"];
            currencyManagerCompetitor = (CurrencyManager)this.BindingContext[DM.dsNZST, "Competitor"];
            currencyManagerChallenge = (CurrencyManager)this.BindingContext[DM.dsNZST, "Challenge"];

            BindControls();
        }

        private void BindControls()
        {

            dgChallenge.DataSource = DM.dsNZST;
            dgChallenge.DataMember = "Challenge";

            dgCompetitor.DataSource = DM.dsNZST;
            dgCompetitor.DataMember = "Competitor";

            dgEntry.DataSource = DM.dsNZST;
            dgEntry.DataMember = "Entry";
        }
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            //Add entry Button
            try
            {
                DataRow newEntryrow = DM.dtChallengeCompetitor.NewRow();
                if (DM.dtChallenge.Rows[currencyManagerChallenge.Position]["Status"].ToString() == "Scheduled")
                {
                    newEntryrow = DM.dtChallengeCompetitor.NewRow();
                    newEntryrow["ChallengeID"] = dgChallenge["ChallengeID", currencyManagerChallenge.Position].Value;
                    newEntryrow["CompetitorID"] = dgCompetitor["CompetitorID", currencyManagerChallenge.Position].Value;
                    newEntryrow["Status"] = "Confirmed";
                    DM.dsNZST.Tables["Entry"].Rows.Add(newEntryrow);
                    DM.UpdateChallengeCompetitor();

                    MessageBox.Show("Competitor Successfully enterd into Challenge", "Success");
                    //update database 
                }
                else
                {
                    MessageBox.Show("You can only enter into Challenges that are Scheduled.", "Error");
                }
                //add a new row to dataset 
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This Competitor is already enterd into the Challenge", "Error");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Remove Entry Btn
            DataRow deleteEntryRow = DM.dtChallengeCompetitor.Rows[currencyManagerEntry.Position];
            deleteEntryRow.Delete();
            MessageBox.Show("Entry Successfully removed", "Success");
            DM.UpdateChallenge();
            DM.UpdateChallengeCompetitor();
            DM.UpdateCompetitor();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            //return btn
            Close();
        }

        private void dgChallenge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEventName.Text = DM.dtChallenge.Rows[currencyManagerChallenge.Position]["ChallengeName"].ToString();
            txtStatus.Text = DM.dtChallenge.Rows[currencyManagerChallenge.Position]["Status"].ToString();
        }
    }
}

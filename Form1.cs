using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{

    public partial class MainForm : Form
    {
        private DataModule DM;      //Reference to Data Module Form (class)
        // Reference to all Forms
        private ArenaForm frmArena; 
        private EventForm frmEvent;
        private ChallengeForm frmChallenge;
        private CompetitorForm frmCompetitor;
        private CompetitorChallengeForm frmCompetitorChallenge;
        private EventReportForm frmEventReport;
        private CompetitorReportForm frmCompetitorReport;





        private OleDbDataReader reader;
        private OleDbCommand command;
        private OleDbConnection connection;
        string connectionString;
        private DataSet dsArena;
        private OleDbDataAdapter daArena;
        private CurrencyManager cmArena;

        private OleDbCommandBuilder commandBuilder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Event Report
            if (frmEventReport == null)
            {
                frmEventReport = new EventReportForm(DM,this);
            }
            frmEventReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Arena Form
            if (frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            frmArena.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Exit Button
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Event Form
            if (frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Challenge Form
            if (frmChallenge == null)
            {
                frmChallenge = new ChallengeForm(DM, this);
            }
            frmChallenge.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Competitors Report
            if (frmCompetitorReport==null)
            {
                frmCompetitorReport = new CompetitorReportForm(DM, this);
            }
            frmCompetitorReport.ShowDialog();
        }
    }
}

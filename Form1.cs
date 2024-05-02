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
        private ArenaReportForm frmArenaReport;





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
            //Enter Competitor into Challenge
            if (frmCompetitorChallenge == null)
            {
                frmCompetitorChallenge = new CompetitorChallengeForm(DM, this);
            }
            frmCompetitorChallenge.ShowDialog();
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
            // Event Maintenance Form
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Competitor Maintenance Form
            if (frmCompetitor == null)
            {
                frmCompetitor = new CompetitorForm(DM, this);
            }
            frmCompetitor.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Arena Report btn
            if (frmArenaReport == null)
            {
                frmArenaReport = new ArenaReportForm(DM, this);
            }
            frmArenaReport.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Arena Form
            if (frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            frmArena.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Event Maintenance Form
            if (frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Challenge Maintenance Form
            if (frmChallenge == null)
            {
                frmChallenge = new ChallengeForm(DM, this);
            }
            frmChallenge.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //Competitor Maintenance Form
            if (frmCompetitor == null)
            {
                frmCompetitor = new CompetitorForm(DM, this);
            }
            frmCompetitor.ShowDialog();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            //Exit
            Close();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            //Arena Report btn
            if (frmArenaReport == null)
            {
                frmArenaReport = new ArenaReportForm(DM, this);
            }
            frmArenaReport.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            //Enter Competitor into Challenge
            if (frmCompetitorChallenge == null)
            {
                frmCompetitorChallenge = new CompetitorChallengeForm(DM, this);
            }
            frmCompetitorChallenge.ShowDialog();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            // Competitors Report
            if (frmCompetitorReport == null)
            {
                frmCompetitorReport = new CompetitorReportForm(DM, this);
            }
            frmCompetitorReport.ShowDialog();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            // Event Report
            if (frmEventReport == null)
            {
                frmEventReport = new EventReportForm(DM, this);
            }
            frmEventReport.ShowDialog();
        }
    }
}

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
    public partial class DataModule : Form
    {
        public DataTable dtArena;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtChallengeCompetitor;
        public DataTable dtEvent;

        private View arenaView;
        private View challengeView;
        private View challengeCompetitorView;
        private View competitorView;
        private View eventView;



        public DataModule()
        {
            InitializeComponent();
            daArena.Fill(dsNZST);
            daChallenge.Fill(dsNZST);
            daChallengeCompetitor.Fill(dsNZST);
            daCompetitor.Fill(dsNZST);
            daEvent.Fill(dsNZST);

            dtArena = dsNZST.Tables["Arena"];
            dtChallenge = dsNZST.Tables["Challenge"];
            dtChallengeCompetitor = dsNZST.Tables["ChallengeCompetitor"];
            dtCompetitor = dsNZST.Tables["Competitor"];
            dtEvent = dsNZST.Tables["Event"];

            dsNZST.EnforceConstraints = true;

        }

        public void UpdateArena() { 
            daArena.Update(dtArena);
        }

        public void UpdateChallenge() { 
            daChallenge.Update(dtChallenge);
        }

    }
}

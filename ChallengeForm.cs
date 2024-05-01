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
    public partial class ChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager currenyManagerEvent;

        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            addCapacity.KeyDown += AddCapacity_KeyDown;
        }

        private void BindControls() 
        {

            //Binding data to textboxes
            txtChallengeID.DataBindings.Add("Text", DM.dsNZST, "Challenge.ChallengeID");
            txtChallengeName.DataBindings.Add("Text", DM.dsNZST, "Challenge.ChallengeName");
            txtEventID.DataBindings.Add("Text", DM.dsNZST, "Challenge.EventID");
            txtStartTime.DataBindings.Add("Text", DM.dsNZST, "Challenge.StartTime");
            txtStatus.DataBindings.Add("Text", DM.dsNZST, "Challenge.Status");
            txtCapacity.DataBindings.Add("Text", DM.dsNZST, "Challenge.Capacity");

            //Binding list with Challenge ID
            lstChallenge.DataSource = DM.dsNZST;
            lstChallenge.DisplayMember = "Challenge.ChallengeID";
            lstChallenge.ValueMember = "Challenge.ChallengeID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZST, "Challenge"];



            //get the Event Name matching the event ID for the challenge
            getEventName();
        }
        private void getEventName() {
            //get the Event Name matching the event ID for the challenge
            DataTable eventTable = DM.dsNZST.Tables["Event"];
            foreach (DataRow row in eventTable.Rows)
            {
                if (row["EventID"].ToString() == DM.dtChallenge.Rows[currencyManager.Position]["EventID"].ToString())
                {
                    txtEventName.Text = row["EventName"].ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Return buttn
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Previous Button
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
            getEventName();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Next Button
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
            getEventName();
        }

        private void btnAddChlng_Click(object sender, EventArgs e)
        {
            // Add Challenge Button
            panelAddChallenge.Visible = true;

            lstChallenge.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateChlnge.Enabled = false;
            btnDeleteChlnge.Enabled = false;
            btnChlngeFinish.Enabled = false;
            btnChlngeComplete.Enabled = false;
            btnReturn.Enabled = false;

            // Binding Combo box
            comboAddEventID.DataSource = DM.dsNZST.Tables["Event"];
            comboAddEventID.DisplayMember = "EventID";

            comboAddEventName.DataSource = DM.dsNZST.Tables["Event"];
            comboAddEventName.DisplayMember = "EventName";

            comboAddStatus.Items.Add("Scheduled");
            comboAddStatus.Items.Add("Completed");
            comboAddStatus.Items.Add("Finished");
            comboAddStatus.SelectedIndex= 0;

            txtAddStartTime.Format = DateTimePickerFormat.Custom;
            txtAddStartTime.CustomFormat = "HH:mm";


        }

        private void btnUpdateChlnge_Click(object sender, EventArgs e)
        {
            // Update Challenge Button
        }

        private void btnDeleteChlnge_Click(object sender, EventArgs e)
        {
            // Delete Challenge Button
        }

        private void btnChlngeFinish_Click(object sender, EventArgs e)
        {
            // Mark Challenge as Finished Button
        }

        private void btnChlngeComplete_Click(object sender, EventArgs e)
        {
            // Mark Challenge as Complete Button
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAddChallenge.Visible = false;

            lstChallenge.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateChlnge.Enabled = true;
            btnDeleteChlnge.Enabled = true;
            btnChlngeFinish.Enabled = true;
            btnChlngeComplete.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveChlnge_Click(object sender, EventArgs e)
        {
            DataRow addChallenge = DM.dtChallenge.NewRow();

            if (txtAddChallengeName.Text == "" || txtAddStartTime.Text == "" || txtCapacity.Text =="0") {
                MessageBox.Show("Please enter values for all text fields", "Error");
            }
            else
            {
                addChallenge["ChallengeName"] = txtAddChallengeName.Text;
                addChallenge["EventID"] = comboAddEventID.SelectedIndex;
                addChallenge["StartTime"] = txtAddStartTime.Text;
                addChallenge["Status"] = comboAddStatus.Text;
                addChallenge["Capacity"] = addCapacity.Text;

                DM.dtChallenge.Rows.Add(addChallenge);
                DM.UpdateChallenge();
                MessageBox.Show("Challenge added successfully", "Success");
            }

        }
        private void AddCapacity_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}

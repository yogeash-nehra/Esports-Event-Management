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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }
        private void getEventName()
        {
            try
            {
                //get the Event Name matching the event ID for the challenge
                DataTable eventTable = DM.dsNZST.Tables["Event"];
                foreach (DataRow row in eventTable.Rows)
                {
                    if (row["EventID"].ToString() == DM.dtChallenge.Rows[currencyManager.Position]["EventID"].ToString())
                    {
                        txtEventName.Text = row["EventName"].ToString();
                        txtUpdateEventName.Text = row["EventName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
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
            try
            {
                txtAddChallengeName.Text = "";
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

                txtAddStartTime.Format = DateTimePickerFormat.Custom;
                txtAddStartTime.CustomFormat = "HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }

        }

        private void btnUpdateChlnge_Click(object sender, EventArgs e)
        {
            getEventName();
            // Update Challenge Button
            panelUpdateChallenge.Visible = true;

            lstChallenge.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateChlnge.Enabled = false;
            btnDeleteChlnge.Enabled = false;
            btnChlngeFinish.Enabled = false;
            btnChlngeComplete.Enabled = false;
            btnReturn.Enabled = false;

            //Binding Data
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            txtUpdateChlngeID.Text = updateChallengeRow["ChallengeID"].ToString();
            txtUpdateChlngeName.Text = updateChallengeRow["ChallengeName"].ToString();
            txtUpdateStartTime.Text = updateChallengeRow["StartTime"].ToString();
            txtUpdateStatus.Text = updateChallengeRow["Status"].ToString();
            txtUpdateCapacity.Text = updateChallengeRow["Capacity"].ToString();
        }

        private void btnDeleteChlnge_Click(object sender, EventArgs e)
        {
            // Delete Challenge Button
            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];

            //Accessig the Entry table to check for events in the selected arena
            DataTable tableEntry = DM.dsNZST.Tables["Entry"];
            List<string> myListforEntry = new List<string>();
            foreach (DataRow row in tableEntry.Rows)
            {
                if (row["ChallengeID"].ToString() == deleteChallengeRow["ChallengeID"].ToString())
                {
                    myListforEntry.Add("1");
                }
            }

            // Check if Arena has no events attached to it then it can be deleted
            if (myListforEntry.Count == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this challenge?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.UpdateChallenge();
                    MessageBox.Show("Selected challenge  deleted successfully !!", "Success");
                }
            }
            else { MessageBox.Show("You may only delete challenges that has no entries.", "Error"); }
        }

        private void btnChlngeFinish_Click(object sender, EventArgs e)
        {
            // Mark Challenge as Finished Button
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];

            if (updateChallengeRow["Status"].ToString() == "Scheduled")
            {
                updateChallengeRow["Status"] = "Finished";

                currencyManager.EndCurrentEdit();
                DM.UpdateChallenge();
                MessageBox.Show("Challenge marked as finished.", "Success");
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as finished.", "Error");
            }
        }

        private void btnChlngeComplete_Click(object sender, EventArgs e)
        {
            // Mark Challenge as Complete Button
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];

            if (updateChallengeRow["Status"].ToString() == "Finished")
            {
                updateChallengeRow["Status"] = "Completed";

                currencyManager.EndCurrentEdit();
                DM.UpdateChallenge();
                MessageBox.Show("Challenge marked as completed.", "Success");
            }
            else
            {
                MessageBox.Show("Only finished challenges can be marked as completed.", "Error");
            }
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

            if (txtAddChallengeName.Text == "" || txtAddStartTime.Text == "")
            {
                MessageBox.Show("Please enter values for all text fields", "Error");
            }
            else if (Convert.ToInt32(txtCapacity.Text) < 0 || Convert.ToInt32(txtCapacity.Text) > 40)
            {
                MessageBox.Show("Please enter capacity value between 0 and 40 !!", "Error");
            }
            else
            {
                addChallenge["ChallengeName"] = txtAddChallengeName.Text;
                addChallenge["EventID"] = comboAddEventID.Text;
                addChallenge["StartTime"] = txtAddStartTime.Text;
                addChallenge["Status"] = comboAddStatus.Text;
                addChallenge["Capacity"] = addCapacity.Text;

                DM.dtChallenge.Rows.Add(addChallenge);
                DM.UpdateChallenge();
                MessageBox.Show("Challenge added successfully", "Success");

                //Close Panel
                panelAddChallenge.Visible = false;

                lstChallenge.Visible = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnUpdateChlnge.Enabled = true;
                btnDeleteChlnge.Enabled = true;
                btnChlngeFinish.Enabled = true;
                btnChlngeComplete.Enabled = true;
                btnReturn.Enabled = true;
                txtAddChallengeName.Text = "";
                txtAddStartTime.Text = "";
                txtCapacity.Text = "0";
            }

        }
        private void AddCapacity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            // Update Save button
            updateChallengeRow["ChallengeName"] = txtUpdateChlngeName.Text;
            updateChallengeRow["StartTime"] = txtUpdateStartTime.Text;
            updateChallengeRow["Capacity"] = txtUpdateCapacity.Text;
            DM.UpdateChallenge();
            MessageBox.Show("Challenge updated successfully", "Success");


            //Close udpate panel
            panelUpdateChallenge.Visible = false;

            lstChallenge.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateChlnge.Enabled = true;
            btnDeleteChlnge.Enabled = true;
            btnChlngeFinish.Enabled = true;
            btnChlngeComplete.Enabled = true;
            btnReturn.Enabled = true;

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Update Cancel button
            panelUpdateChallenge.Visible = false;

            lstChallenge.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateChlnge.Enabled = true;
            btnDeleteChlnge.Enabled = true;
            btnChlngeFinish.Enabled = true;
            btnChlngeComplete.Enabled = true;
            btnReturn.Enabled = true;


        }

        private void lstChallenge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                txtEventName.Text = "";
            }
            else
            {
                getEventName();
            }
        }
    }
}

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
    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EventForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.dsNZST, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsNZST, "Event.EventName");
            txtArenaID.DataBindings.Add("Text", DM.dsNZST, "Event.ArenaID");
            txtStatus.DataBindings.Add("Text", DM.dsNZST, "Event.Status");
            txtCapacity.DataBindings.Add("Text", DM.dsNZST, "Event.Capacity");
            txtEventDate.DataBindings.Add("Text", DM.dsNZST, "Event.EventDate");

            lstEvent.DataSource = DM.dsNZST;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZST, "Event"];

            getArenaName();
        }

        private void getArenaName()
        {
            DataTable arenaTable = DM.dsNZST.Tables["Arena"];
            foreach (DataRow row in arenaTable.Rows)
            {
                if (row["ArenaID"].ToString() == DM.dtEvent.Rows[currencyManager.Position]["ArenaID"].ToString())
                {
                    txtArenaName.Text = row["ArenaName"].ToString();
                    txtUpdateArenaName.Text = row["ArenaName"].ToString();
                }
            }
        }


        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Previous Button
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
            getArenaName();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Next Button
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
            getArenaName();
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            //Add Event Button
            panelAddEvent.Visible = true;

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateEvent.Enabled = false;
            btnDeleteEvent.Enabled = false;
            btnReturn.Enabled = false;
            lstEvent.Visible = false;

            txtAddArenaID.DataSource = DM.dsNZST.Tables["Arena"];
            txtAddArenaID.DisplayMember = "ArenaID";

            comboAddArenaName.DataSource = DM.dsNZST.Tables["Arena"];
            comboAddArenaName.DisplayMember = "ArenaName";

            for (int i = 5000; i >= 100; i--)
            {
                txtaddCapacity.Items.Add(i.ToString());
            }
            txtaddCapacity.SelectedItem = "100";
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            //Update Event Button
            panelUpdateevent.Visible = true;

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddEvent.Enabled = false;
            btnDeleteEvent.Enabled = false;
            btnReturn.Enabled = false;
            lstEvent.Visible = false;

            //Populating fields
            txtUpdateEventID.Text = updateEventRow["EventID"].ToString();
            txtUpdateEventName.Text = updateEventRow["EventName"].ToString();
            txtUpdateArenaID.Text = updateEventRow["ArenaID"].ToString();
            getArenaName();
            txtUpdateStatus.Text = updateEventRow["Status"].ToString();
            txtUpdateCapacity.Text = updateEventRow["Capacity"].ToString();
            txtUpdateEventDate.Text = updateEventRow["EventDate"].ToString();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            //Delete Event Button
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];

            DataTable tableChallenge = DM.dsNZST.Tables["Challenge"];
            List<string> myListforChallenge = new List<string>();
            foreach (DataRow row in tableChallenge.Rows)
            {
                if (row["EventID"].ToString() == deleteEventRow["EventID"].ToString())
                {
                    myListforChallenge.Add("1");
                }
            }

            // Check if Arena has no events attached to it then it can be deleted
            if (myListforChallenge.Count == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Event?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.UpdateChallenge();
                    MessageBox.Show("Selected event  deleted successfully !!", "Success");
                }

            }
            else { MessageBox.Show("You may only delete events that have no challenges.", "Error"); }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return Button
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddEventName.Text = "";
            // Button Cancel Add event
            panelAddEvent.Visible = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnReturn.Enabled = true;
            lstEvent.Visible = true;
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            // Save button Add Event

            DataRow addEventRow = DM.dtEvent.NewRow();

            if (txtAddEventName.Text == "")
            {
                MessageBox.Show("Please enter values for all text fields", "Error");
            }
            else
            {
                addEventRow["EventName"] = txtAddEventName.Text;
                addEventRow["ArenaID"] = txtAddArenaID.Text;
                addEventRow["Status"] = txtStatus.Text;
                addEventRow["Capacity"] = txtaddCapacity.Text;
                addEventRow["EventDate"] = txtEventDate.Text;

                DM.dtEvent.Rows.Add(addEventRow);
                DM.UpdateEvent();
                MessageBox.Show("Event added successfully", "Success");

                // Close panel
                panelAddEvent.Visible = false;

                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnUpdateEvent.Enabled = true;
                btnDeleteEvent.Enabled = true;
                btnReturn.Enabled = true;
                lstEvent.Visible = true;

            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Update Event Cancel Button
            panelUpdateevent.Visible = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnReturn.Enabled = true;
            lstEvent.Visible = true;
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            // Save button update event
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];

            updateEventRow["EventName"] = txtUpdateEventName.Text;
            updateEventRow["Status"] = txtUpdateStatus.Text;
            updateEventRow["EventDate"] = txtUpdateEventDate.Text;

            DM.UpdateEvent();
            MessageBox.Show("Event updated successfully", "Success");


            //Close Panel
            panelUpdateevent.Visible = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnReturn.Enabled = true;
            lstEvent.Visible = true;
        }

        private void lstEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                txtEventName.Text = "";
            }
            else
            {
                getArenaName();
            }
        }
    }
}

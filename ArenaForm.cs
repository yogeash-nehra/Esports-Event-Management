using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Documents;

namespace Assignment1
{
    public partial class ArenaForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ArenaForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            try
            {
                // Binding data to the textboxes
                txtArenaID.DataBindings.Add("Text", DM.dsNZST, "Arena.ArenaID");
                txtArenaName.DataBindings.Add("Text", DM.dsNZST, "Arena.ArenaName");
                txtStAddress.DataBindings.Add("Text", DM.dsNZST, "Arena.StreetAddress");
                txtSuburb.DataBindings.Add("Text", DM.dsNZST, "Arena.Suburb");
                txtCity.DataBindings.Add("Text", DM.dsNZST, "Arena.City");
                txtPhone.DataBindings.Add("Text", DM.dsNZST, "Arena.PhoneNumber");

                // Binding Data to the list
                lstArena.DataSource = DM.dsNZST;
                lstArena.DisplayMember = "Arena.ArenaName";
                lstArena.ValueMember = "Arena.ArenaName";

                currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZST, "Arena"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while binding controls: " + ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Add Arena Button
                txtArenaNameAdd.Text = "";
                txtSuburbAdd.Text = "";
                txtStreetAddressAdd.Text = "";
                txtCityAdd.Text = "";
                txtPhoneNumberAdd.Text = "";

                panelAddArena.Show();
                panelAddArena.Visible = true;

                lstArena.Visible = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnUpdateArena.Enabled = false;
                btnDeleteArena.Enabled = false;
                btnReturn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Update Arena Button
                panelUpdateArena.Show();
                panelUpdateArena.Visible = true;

                lstArena.Visible = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnAddArena.Enabled = false;
                btnDeleteArena.Enabled = false;
                btnReturn.Enabled = false;

                // get data for current position
                DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
                txtAreanNameUpdate.Text = updateArenaRow["ArenaName"].ToString();
                txtStreetAddressUpdate.Text = updateArenaRow["StreetAddress"].ToString();
                txtSuburbUpdate.Text = updateArenaRow["Suburb"].ToString();
                txtCityUpdate.Text = updateArenaRow["City"].ToString();
                txtPhoneNumberUpdate.Text = updateArenaRow["PhoneNumber"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete Arena Button
                DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];

                //Accessig the Events table to check for events in the selected arena
                DataTable tableEvents = DM.dsNZST.Tables["Event"];
                List<string> myListforEvents = new List<string>();
                foreach (DataRow row in tableEvents.Rows)
                {
                    if (row["ArenaID"].ToString() == deleteArenaRow["ArenaID"].ToString())
                    {
                        myListforEvents.Add("1");
                    }
                }

                // Check if Arena has no events attached to it then it can be deleted
                if (myListforEvents.Count == 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete this arena?", "Warning",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteArenaRow.Delete();
                        DM.UpdateArena();
                        MessageBox.Show("Selected arena deleted successfully !!", "Success");
                    }
                }
                // else arena can't be deleted
                else
                {
                    MessageBox.Show("You may only delete arenas that have no events.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                // Previous Button
                if (currencyManager.Position > 0)
                {
                    --currencyManager.Position;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Next Button
                if (currencyManager.Position < currencyManager.Count - 1)
                {
                    ++currencyManager.Position;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Return Button
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //update arena Save button
                DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
                //Update values for the rows
                updateArenaRow["ArenaName"] = txtAreanNameUpdate.Text;
                updateArenaRow["StreetAddress"] = txtStreetAddressUpdate.Text;
                updateArenaRow["Suburb"] = txtSuburbUpdate.Text;
                updateArenaRow["City"] = txtCityUpdate.Text;
                updateArenaRow["PhoneNumber"] = txtPhoneNumberUpdate.Text;
                // Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateArena();
                //Success message
                MessageBox.Show("Arena updated successfully !!", "Success");

                //Close the update panel
                panelUpdateArena.Visible = false;

                lstArena.Visible = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddArena.Enabled = true;
                btnDeleteArena.Enabled = true;
                btnReturn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Update Arena Cancel button
                panelUpdateArena.Visible = false;

                lstArena.Visible = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddArena.Enabled = true;
                btnDeleteArena.Enabled = true;
                btnReturn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Add Arena - Save button
                DataRow newArenaRow = DM.dtArena.NewRow();

                if (txtArenaNameAdd.Text == "" || txtSuburbAdd.Text == "" || txtStreetAddressAdd.Text == "" ||
                    txtCityAdd.Text == "" || txtPhoneNumberAdd.Text == "")
                {
                    MessageBox.Show("Please enter values for all text fields", "Error");
                }
                else
                {
                    newArenaRow["ArenaName"] = txtArenaNameAdd.Text;
                    newArenaRow["StreetAddress"] = txtStreetAddressAdd.Text;
                    newArenaRow["Suburb"] = txtSuburbAdd.Text;
                    newArenaRow["City"] = txtCityAdd.Text;
                    newArenaRow["PhoneNumber"] = txtPhoneNumberAdd.Text;

                    DM.dtArena.Rows.Add(newArenaRow);
                    DM.UpdateArena();
                    MessageBox.Show("Arena added successfully", "Success");

                    panelAddArena.Visible = false;

                    lstArena.Visible = true;
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnUpdateArena.Enabled = true;
                    btnDeleteArena.Enabled = true;
                    btnReturn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Add Arena cancel Button
                panelAddArena.Visible = false;

                lstArena.Visible = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateArena.Enabled = true;
                btnDeleteArena.Enabled = true;
                btnReturn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error");
            }
        }

        private void panelAddArena_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

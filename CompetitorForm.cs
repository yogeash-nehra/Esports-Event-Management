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
    public partial class CompetitorForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public CompetitorForm(DataModule dM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = dM;
            this.frmMenu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            txtCompID.DataBindings.Add("Text", DM.dsNZST, "Competitor.CompetitorID");
            txtUsername.DataBindings.Add("Text", DM.dsNZST, "Competitor.UserName");
            txtfName.DataBindings.Add("Text", DM.dsNZST, "Competitor.FirstName");
            txtlName.DataBindings.Add("Text", DM.dsNZST, "Competitor.LastName");
            txtGender.DataBindings.Add("Text", DM.dsNZST, "Competitor.Gender");
            txtDOB.DataBindings.Add("Text", DM.dsNZST, "Competitor.DateOfBirth");
            txtEmail.DataBindings.Add("Text", DM.dsNZST, "Competitor.EmailAddress");

            lstCompetitor.DataSource = DM.dsNZST;
            lstCompetitor.DisplayMember = "Competitor.UserName";
            lstCompetitor.ValueMember = "Competitor.UserName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZST, "Competitor"];

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Update Comp Cancel button
            panelUpdateComp.Visible = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddComp.Enabled = true;
            btnDeleteComp.Enabled = true;
            btnReturn.Enabled = true;
            lstCompetitor.Visible = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Previous Button
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Next Button
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            txtAddUsername.Text = "";
            txtAddFName.Text = "";
            txtAddLName.Text = "";
            txtAddDOB.Text = "";
            txtAddEmail.Text = "";
            //Add Comp Button
            panelAddComp.Visible = true;

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateComp.Enabled = false;
            btnDeleteComp.Enabled = false;
            btnReturn.Enabled = false;
            lstCompetitor.Visible = false;

        }

        private void btnUpdateComp_Click(object sender, EventArgs e)
        {
            //Update Comp btn
            panelUpdateComp.Visible = true;

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddComp.Enabled = false;
            btnDeleteComp.Enabled = false;
            btnReturn.Enabled = false;
            lstCompetitor.Visible = false;

            DataRow updateCompRow = DM.dtCompetitor.Rows[currencyManager.Position];
            txtUpdateUsername.Text  = updateCompRow["UserName"].ToString();
            txtUpdateFName.Text = updateCompRow["FirstName"].ToString();
            txtUpdateLName.Text = updateCompRow["LastName"].ToString();
            if (updateCompRow["Gender"].ToString() == "Female")
            {
                radioUpdateFemale.Checked = true;
            }
            else if (updateCompRow["Gender"].ToString() == "Male")
            {
                radioUpdateMale.Checked = true;
            }
            else 
            {
                radioUpdateOther.Checked = true;
            }
            txtUpdateDOB.Text = updateCompRow["DateOfBirth"].ToString();
            txtUpdateEmail.Text = updateCompRow["EmailAddress"].ToString();
        }

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
            DataRow deleteCompRow = DM.dtCompetitor.Rows[currencyManager.Position];

            //Accessig the Entry table to check for events in the selected arena
            DataTable tableEntry = DM.dsNZST.Tables["Entry"];
            List<string> myListforEntry = new List<string>();
            foreach (DataRow row in tableEntry.Rows)
            {
                if (row["CompetitorID"].ToString() == deleteCompRow["CompetitorID"].ToString())
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
                    deleteCompRow.Delete();
                    DM.UpdateCompetitor();
                    MessageBox.Show("Selected competitor  deleted successfully !!", "Success");
                }
            }
            else { MessageBox.Show("You may only delete competitors that have no entries.", "Error"); }
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            //Update Save button
            DataRow updateCompRow = DM.dtCompetitor.Rows[currencyManager.Position];
            if (txtUpdateUsername.Text == "" || txtUpdateFName.Text == "" || txtUpdateLName.Text == "" || txtUpdateDOB.Text == "" || txtUpdateEmail.Text == "")
            {
                MessageBox.Show("Please enter values for all text fields", "Error");
            }
            else
            {
                updateCompRow["UserName"] = txtUpdateUsername.Text;
                updateCompRow["FirstName"] = txtUpdateFName.Text;
                updateCompRow["LastName"] =  txtUpdateLName.Text;
                updateCompRow["DateOfBirth"] = txtUpdateDOB.Text;
                updateCompRow["EmailAddress"] = txtUpdateEmail.Text;
                if (radioUpdateFemale.Checked)
                {
                    updateCompRow["Gender"] = "Female";
                }
                else if (radioUpdateMale.Checked)
                {
                    updateCompRow["Gender"] = "Male";
                }
                else
                {
                    updateCompRow["Gender"] = "Other";
                }
                DM.UpdateCompetitor();
                MessageBox.Show("Competitor updated successfully", "Success");


                //Close panel
                panelUpdateComp.Visible = false;

                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnAddComp.Enabled = true;
                btnDeleteComp.Enabled = true;
                btnReturn.Enabled = true;
                lstCompetitor.Visible = true;
            }
        }

        private void btnSaveComp_Click(object sender, EventArgs e)
        {
            DataRow addCompRow = DM.dtCompetitor.NewRow();
            //Add Save button
            if (txtAddUsername.Text == "" || txtAddFName.Text == "" || txtAddLName.Text == "" || txtAddDOB.Text == "" || txtAddEmail.Text == "")
            {
                MessageBox.Show("Please enter values for all text fields", "Error");
            }
            else
            {
                addCompRow["UserName"] = txtAddUsername.Text;
                addCompRow["FirstName"] = txtAddFName.Text;
                addCompRow["LastName"] = txtAddLName.Text;
                addCompRow["DateOfBirth"] = txtAddDOB.Text;
                addCompRow["EmailAddress"] = txtAddEmail.Text;
                if (radioAddFemale.Checked)
                {
                    addCompRow["Gender"] = "Female";
                }
                else if (radioAddMale.Checked)
                {
                    addCompRow["Gender"] = "Male";
                }
                else
                {
                    addCompRow["Gender"] = "Other";
                }
                DM.dtCompetitor.Rows.Add(addCompRow);
                DM.UpdateCompetitor();
                MessageBox.Show("Competitor added successfully", "Success");

                //Close Panel
                panelAddComp.Visible = false;

                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnUpdateComp.Enabled = true;
                btnDeleteComp.Enabled = true;
                btnReturn.Enabled = true;
                lstCompetitor.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Add Cancel btn
            panelAddComp.Visible = false;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateComp.Enabled = true;
            btnDeleteComp.Enabled = true;
            btnReturn.Enabled = true;
            lstCompetitor.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //return
            Close();
        }
    }
}

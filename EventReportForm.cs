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
    public partial class EventReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public EventReportForm(DataModule DM, MainForm mnu)
        {
            InitializeComponent();
            this.DM = DM;
            this.frmMenu = mnu;
            BindControls();
        }
        private void BindControls()
        {

        }
    }
}

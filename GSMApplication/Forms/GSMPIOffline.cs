using GSMApplication.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMApplication.Forms
{
    public partial class GSMPIOffline : Form
    {
        private GSMPIDataContext bdGSMPI = new GSMPIDataContext();

        public GSMPIOffline()
        {
            InitializeComponent();
            this.init();

        }

        private void init()
        {
            string hourNumber = bdGSMPI.taParameters.SingleOrDefault(qry => qry.tag.Equals("HoursScann")).value ;
            txtHoras.Text = !string.IsNullOrEmpty(hourNumber) ? hourNumber : "1";

            string numberScann = bdGSMPI.taParameters.SingleOrDefault(qry => qry.tag.Equals("NumberOfScann")).value;
            txtCantidad.Text = !string.IsNullOrEmpty(numberScann) ? numberScann : "1000";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void rbIndefinido_CheckedChanged(object sender, EventArgs e)
        {
            gBIndefinido.Enabled = ((RadioButton)sender).Name.Equals("rbIndefinido");
            gbHoras.Enabled = ((RadioButton)sender).Name.Equals("rBHoras");
            gBCantidad.Enabled = ((RadioButton)sender).Name.Equals("rBCantidad");

            switch (((RadioButton)sender).Name)
            {
                case "rBHoras":
                    txtHoras.Focus();
                    txtHoras.SelectAll();
                    break;
                case "rBCantidad":
                    txtCantidad.Focus();
                    txtCantidad.SelectAll();
                    break;
            }
        }
       
    }
}

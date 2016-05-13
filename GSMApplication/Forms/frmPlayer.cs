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
    public partial class frmPlayer : Form
    {
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set {
                filePath = value;
                this.wMP.URL = filePath;
            }
        }

        private string filename;
        public string Filename
        {
            get { return filename; }
            set { 
                filename = value;
                this.Text = filename;    
            }
        }

        public frmPlayer(string fileName, string filePath)
        {
            InitializeComponent();

            this.Filename = fileName;
            this.FilePath = filePath;
            this.Init();
        }

        private void Init()
        {
            wMP.Ctlcontrols.play();
        }

        private void wMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                this.Close();
            }
        }

    }
}

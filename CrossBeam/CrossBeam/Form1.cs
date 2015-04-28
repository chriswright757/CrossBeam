using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APILib;

namespace CrossBeam
{
    public partial class APITest : Form
    {
        Api CZEMApi = new Api();
        public APITest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void APIInitialise_Click(object sender, EventArgs e)
        {


            // Initialise the control to connect to the local CZ EM microscope
            long lReturn = CZEMApi.InitialiseRemoting();

            if (lReturn != 0)
            {
                MessageBox.Show("Failed to initialise control");
                return;
            }
        }

        private void GetMag_Click_1(object sender, EventArgs e)
        {
            // Get the magnification value from the microscope
            object varfloat = new System.Runtime.InteropServices.VariantWrapper((float)0.0f);
            // get param (numeric)value
            long lResult = CZEMApi.Get("AP_MAG", ref varfloat);
            if (lResult != 0)
            {
                MessageBox.Show("Failed to get magnification");
                return;
            }
            MessageBox.Show("Magnification = " + varfloat.ToString());
        }      

    }
}

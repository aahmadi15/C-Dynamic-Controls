/*Abdul Ahmadi  
 112202155*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO670ASS2
{
    public partial class frmFirst : Form
    {
        public String myData;
        private frmBuilded dlgInputN;
        public frmFirst()
        {
            //add items to checkBox
            InitializeComponent();
            lblWelcome.Text = "Welcome to the Dynamic Form App!";
            cmbCBB.Text = "--SELECT--";
            cmbCBB.Items.Add("Empty");
            cmbCBB.Items.Add("Movies");
            cmbCBB.Items.Add("Jobs");
        }
        //close the app
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check(object sender, EventArgs e)
        {
            //nothing selected yet means hide build button
            if (cmbCBB.SelectedIndex == -1)
            {
                btnBuild.Visible = false;
            }

            else
            {
                btnBuild.Visible = true;
            }
        }

        private void Build(object sender, EventArgs e)
        {
            //creates separate instances of the dialog box based on different inputs in checkbox which will then have different dynamic controls assigned to them
            if (cmbCBB.Text == "Empty")
            {
              
                this.Hide();

                dlgInputN = new frmBuilded(lblTransfer, cmbCBB, myData);

                dlgInputN.ShowDialog();

                dlgInputN = null;

                Show();


            }

            if (cmbCBB.Text == "Movies")
            {

                this.Hide();

                dlgInputN = new frmBuilded(lblTransfer, cmbCBB, myData);

                dlgInputN.ShowDialog();

                dlgInputN = null;

                Show();
            }

            if (cmbCBB.Text == "Jobs")
            {

                this.Hide();

                dlgInputN = new frmBuilded(lblTransfer, cmbCBB, myData);

                dlgInputN.ShowDialog();

                dlgInputN = null;

                Show();
            }
        }
    }
}

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
    public partial class frmBuilded : Form
    {
        public frmFirst frst;
        public Label myLabel;
        private ComboBox cmbCBB;
        private Label lblTransfer;
        private String myData;
        ListBox ibM = new ListBox();
        TextBox txtData = new TextBox();
        GroupBox grpBox = new GroupBox();

        public frmBuilded(Label lblTransfer,ComboBox cmbCBB, string myData)
        {
            InitializeComponent();
            this.cmbCBB = cmbCBB;
            this.lblTransfer = lblTransfer;
            this.myData = myData;

            /*if option empty add textbox*/
            if (cmbCBB.Text == "Empty")
            {
                this.Controls.Add(txtData);
                txtData.Location = new System.Drawing.Point(230, 150);
            }
            /*Adds items to listBox*/
            if (cmbCBB.Text == "Movies")
            {
                this.Controls.Add(ibM);
                ibM.Items.Add("Shawshank Redemption\n");
                ibM.Items.Add("Joe Kidd\n");
                ibM.Items.Add("Assassin's Creed\n");
                ibM.Items.Add("The Dark Knight\n");
                ibM.Items.Add("Dracula\n");
                ibM.Items.Add("Capote\n");
                ibM.Items.Add("Pulp Fiction\n");
                ibM.Items.Add("Kill Bill\n");
                ibM.Items.Add("A New Hope\n");
                ibM.Location = new System.Drawing.Point(200, 75); 
            }

            if (cmbCBB.Text == "Jobs")
            {
                lblShowOption.Text = "Enter the Number of Jobs";
                this.Controls.Add(txtData);
                txtData.Location = new System.Drawing.Point(230, 150);        
            }
        }
        /*Creates radioButton for the number of jobs generated and adds to groupbox*/
        public void creaNewRadio(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                RadioButton Radio_N = new RadioButton();

                Radio_N.Text = "JOB# " + j + "-for this user";

                Radio_N.Location = new Point(5, 30 * j);

                grpBox.Controls.Add(Radio_N);
            }
        }
        /*Creates groupbox and returns the object*/
        GroupBox creaNewGroup(int i)
        {
            creaNewRadio(i);

            grpBox.Location = new System.Drawing.Point(350, 100);

            grpBox.Width = 300;
            grpBox.Height = 300;
            this.Controls.Add(grpBox);
            return grpBox;                        
        }
        /*Checks which option selected and returns the value to the first form no text gives error prompt*/
        private void Transfer(object sender, EventArgs e)
        {
            if(txtData.Text == "")
            {
                lblErr.Visible = true;
            }

            else
                if(cmbCBB.Text == "Empty")
            {
                myData = "100";
                this.lblTransfer.Text = myData;
                lblTransfer.Visible = true;
                this.Close();
            }

         
               if(cmbCBB.Text == "Movies")
               {
                    if(ibM.SelectedIndex == 0)
                    {
                        myData = "200";
                    
                    }

                    if (ibM.SelectedIndex == 1)
                    {
                        myData = "201";
                   
                    }

                    if (ibM.SelectedIndex == 2)
                    {
                        myData = "202";
                   
                    }

                    if (ibM.SelectedIndex == 3)
                    {
                        myData = "203";
                   
                    }

                    if (ibM.SelectedIndex == 4)
                    {
                        myData = "204";
                   
                    }

                    if (ibM.SelectedIndex == 5)
                    {
                        myData = "205";
                   
                    }

                    if (ibM.SelectedIndex == 6)
                    {
                        myData = "206";
                    
                    }

                    if (ibM.SelectedIndex == 7)
                    {
                        myData = "207";
                    
                    }

                    if (ibM.SelectedIndex == 8)
                    {
                        myData = "208";
                    
                    }

                    if (ibM.SelectedIndex == 9)
                    {
                        myData = "209";
                    
                    }

                this.lblTransfer.Text = myData;
                lblTransfer.Visible = true;
                this.Close();
            }

            if (cmbCBB.Text == "Jobs")
            {
                GroupBox grpBox;
                /*Tryparse reads and converts the stringdata in textbox to a number from 1 and 10*/
                int i;
                bool b;
                b = int.TryParse(txtData.Text, out i) && i >= 1 && i <= 10;

                if (b == true)
                {
                    int jobs = i - 1;
                    grpBox = creaNewGroup(i);
                    grpBox.Text = "Jobs";
                    myData = 30 + jobs.ToString();
                    this.lblTransfer.Text = myData;
                    lblTransfer.Visible = true;
                }
                //else dont display error message
                if (b == false)
                {
                    lblErr.Visible = true;
                }

                }
            }
        //close the dialog box
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }        
    }

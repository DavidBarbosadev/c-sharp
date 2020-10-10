using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSports
{
    public partial class eSportsform : Form
    {
        public eSportsform()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string sname;
            int imatchesplayed;
            int ivictories;
            double dwinratio;

            sname = txtname.Text;
            imatchesplayed = Convert.ToInt32(txtmatchesplayed.Text);
            ivictories = Convert.ToInt32(txtvictories.Text);
            if (imatchesplayed < ivictories)
            {
                MessageBox.Show("Error...Please review the data that you introduced. " +
                    "it is impossible to have move victories than games played!");
            }
                
            dwinratio = (ivictories * 100) / imatchesplayed;


            txtwinratio.Text = Convert.ToString(dwinratio);

            lbldisplay.Text = "Name: " + txtname.Text + Environment.NewLine 
                +"Date of Birth: " + date.Text + Environment.NewLine + "Gender: " + lblgenderchosen.Text + Environment.NewLine + "Game: " + comboBox1.Text + Environment.NewLine
                + "Win Rate: " + txtwinratio.Text + "%" + Environment.NewLine;

            

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            lblgenderchosen.Text = rdoMale.Text;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblgenderchosen.Text = rdoFemale.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            comboBox1.Text = "";
            date.Text = "";
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            lblgenderchosen.Text = "";
            txtwinratio.Clear();
            txtvictories.Clear();
            txtmatchesplayed.Clear();
            lbldisplay.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lstboxplayersenrolled.Items.Add("Name: " + txtname.Text + 
            "  "+ "Game: " + comboBox1.Text);
            txtname.Text = lstboxplayersenrolled.Text;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            lstboxplayersenrolled.Items.Remove(lstboxplayersenrolled.Text);
        }
    }
}

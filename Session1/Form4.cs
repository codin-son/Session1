using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ArrayList itemtype = new ArrayList();
            itemtype = DBCon.getType();

            cbType.DataSource = itemtype;

            numMinNight.Maximum = numMaxNight.Value;

            if (Form3.action == "add")
            {
                this.Text = "Seoul Stay - Add Listing";
                btnClose.Text = "Finish";
                btnClose.Visible = false;
            }
            else
            {
                this.Text = "Seoul Stay - Edit Listing";
                btnClose.Text = "Close";
                if(Form3.itemid > 0)
                {
                    ArrayList itemdata = new ArrayList();
                    itemdata = DBCon.getItemData(Form3.itemid.ToString());
                    cbType.SelectedItem = itemdata[0];
                    txtTitle.Text = itemdata[1].ToString();
                    numCap.Value = Convert.ToDecimal(itemdata[2]);
                    numBed.Value = Convert.ToDecimal(itemdata[3]);
                    numRooms.Value = Convert.ToDecimal(itemdata[4]);
                    numBath.Value = Convert.ToDecimal(itemdata[5]);
                    txtApproAddress.Text = itemdata[6].ToString();
                    txtExactAddress.Text = itemdata[7].ToString();
                    txtDesc.Text = itemdata[8].ToString();
                    txtHostRules.Text = itemdata[9].ToString();
                    numMinNight.Value = Convert.ToDecimal(itemdata[10]);
                    numMaxNight.Value = Convert.ToDecimal(itemdata[11]);
                }
            }


        }

        private void tabAmenities_Click(object sender, EventArgs e)
        {

        }

        private void tabContList_Selected(object sender, TabControlEventArgs e)
        {
            if (tabContList.SelectedIndex == 0)
            {
                btnCancel.Visible = true;
                btnNext.Visible = true;
                btnClose.Visible = false;

            }
            else if (tabContList.SelectedIndex == 1)
            {
                btnCancel.Visible = true;
                btnNext.Visible = true;
                btnClose.Visible = false;
                string sql = "SELECT ID, Name FROM amenities";
                DBCon.display(sql, dgAmenities);
            }
            else if (tabContList.SelectedIndex == 2)
            {
                btnCancel.Visible = false;
                btnNext.Visible = false;
                btnClose.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool check = checkForm();
            if (check == true)
            {
                MessageBox.Show("please fill in all form");
            }
            else
            {
                if (tabContList.SelectedIndex == 0)
                {
                    tabContList.SelectedTab = tabAmenities;
                }
                else if (tabContList.SelectedIndex == 1)
                {
                    tabContList.SelectedTab = tabDistanceAttract;
                }
            }

        }

        public bool checkForm()
        {
            
            if(string.IsNullOrEmpty(txtTitle.Text) || txtApproAddress.Text == string.Empty || txtExactAddress.Text == string.Empty || txtDesc.Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        private void numMinNight_ValueChanged(object sender, EventArgs e)
        {
                numMinNight.Maximum = numMaxNight.Value;
            
        }

        private void numMaxNight_ValueChanged(object sender, EventArgs e)
        {
            
                numMinNight.Maximum = numMaxNight.Value;
            
        }


    }
}

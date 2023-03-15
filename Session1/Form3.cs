using System;
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
    public partial class Form3 : Form
    {
        private readonly Form1 _parent;
        private readonly Form2 _parents;
        public static string action = "add";
        public static int itemid = 0;
        public Form3(Form1 parent)
        {

            InitializeComponent();
            _parent = parent;

        }
        public Form3(Form2 parents)
        {

            InitializeComponent();

            _parents = parents;
        }
        public Form3()
        {
            InitializeComponent();


        }
        public void displayData()
        {
            String sql = "SELECT items.Title, items.Capacity, Areas.Name, itemtypes.Name FROM items JOIN areas ON items.AreaID = areas.ID JOIN itemtypes ON items.ItemTypeID = itemtypes.ID";

            lblNoSearch.Text = DBCon.display(sql, dgTraveler);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();

            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search destination or Listing Title or Attraction")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search destination or Listing Title or Attraction";
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                displayData();
            }
            else
            {
                lblNoSearch.Text = DBCon.searchResult(txtSearch.Text, dgTraveler);
            }
        }

        private void tabRole_Selected(object sender, TabControlEventArgs e)
        {
            if (tabRole.SelectedIndex == 0)
            {
                displayData();
            }
            else
            {
                String sql = "SELECT items.ID, items.Title, items.Capacity, Areas.Name, itemtypes.Name FROM items JOIN areas ON items.AreaID = areas.ID JOIN itemtypes ON items.ItemTypeID = itemtypes.ID WHERE  items.UserID =" + DBCon.id;

                lblNoSearch.Text = DBCon.display(sql, dgOwner);
            }
        }

        private void dgOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedrowindex = dgOwner.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = dgOwner.Rows[selectedrowindex];
            itemid = Convert.ToInt32(selectedrow.Cells["Column10"].Value);
            action = "edit";
            Form4 form4 = new Form4();
            this.Hide();
            form4.Closed += (s, args) => this.Close();
            form4.Show();

        }

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            action = "add";
            Form4 form4 = new Form4();
            this.Hide();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
            
        }
    }
}

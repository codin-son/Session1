using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Session1
{
    class DBCon
    {
        public static string id;
        public static MySqlConnection GetConnection()
        {
            string provider = "server=localhost;user id=root;database=session1";
            MySqlConnection con = new MySqlConnection(provider);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("connection failed. error: " + ex);
            }
            return con;
        }

        public static int Login(string username, string password, string role)
        {
            string sql = "SELECT * FROM users WHERE username =@us";
            int success;
            //1 for employee, 2 for user
            if (role == "1")
            {
                sql += " AND UserTypeID = 1";
            }
            else
            {
                sql += " AND UserTypeID = 2";
            }
            sql += " AND password = @ps";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);

            if(tbl.Rows.Count > 0)
            {
                
                string txt = "Login Success";
                MySqlDataReader dreader = cmd.ExecuteReader();
                dreader.Read();
                id= dreader["ID"].ToString();
                if (role == "1")
                {
                    txt += "\nWelcome employee";
                }
                else
                {
                    txt += "\nWelcome  taveler/owner";
                }
                MessageBox.Show(txt);
                success = 1;
            }
            else
            {
                MessageBox.Show("Login failed");
                success = 0;
            }
            return success;
        }
        public static string Login(string username, string password)
        {
            string sql = "SELECT * FROM users WHERE username =@us AND password = @ps";

            string isEmp = "";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            
            if (tbl.Rows.Count > 0)
            {

                MySqlDataReader dreader = cmd.ExecuteReader();
                dreader.Read();
                isEmp = dreader["UserTypeID"].ToString();
                id= dreader["ID"].ToString();
            }
            else
            {
                MessageBox.Show("Login failed");

            }
            return isEmp;
        }
        public static bool checkDuplicate(string username, string fullname, string birthday, string password, string gender, string numFamMem)
        {
            bool isDup = false;
            string sql = "SELECT * FROM users WHERE Username =@us AND FullName= @fn AND BirthDate =@bt AND Password= @ps AND Gender= @gd AND FamilyCount=@nfm";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@bt", MySqlDbType.VarChar).Value = birthday;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@nfm", MySqlDbType.VarChar).Value = numFamMem;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                isDup = true;
            }
            else
            {
                isDup = false;
            }
            return isDup;
        }

        public static bool register(string username, string fullname, string birthday, string password, string gender, string numFamMem)
        {
            bool success = false;
            int id = getID("users");

            string sql = "INSERT INTO users (ID,GUID,UserTypeID,Username,Password,FullName,Gender,BirthDate,FamilyCount) VALUES (@id,@guid,@utid,@us,@ps,@fnm,@gd,@bt,@fm)";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id+1;
            cmd.Parameters.Add("@guid", MySqlDbType.VarChar).Value = generateGUID();
            cmd.Parameters.Add("@utid", MySqlDbType.Int32).Value = 2;
            cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@gd", MySqlDbType.Int32).Value = gender;
            cmd.Parameters.Add("@bt", MySqlDbType.Date).Value = birthday;
            cmd.Parameters.Add("@fm", MySqlDbType.Int32).Value = numFamMem;

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();

                success = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("data not added. error: " + ex);

            }
            return success;
        }
        public static string generateGUID()
        {
            string guId = "";
            Guid guid = Guid.NewGuid();
            guId = guid.ToString("D");
            
            return guId;
        }

        public static int getID(string idType)
        {
            int id = 0;

            string sql = "SELECT ID FROM " + idType + " WHERE ID ORDER BY ID DESC LIMIT 1";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            var queryResult = cmd.ExecuteScalar();
            id = Convert.ToInt32(queryResult);

            return id;
        }

        public static string display(string sql, DataGridView dgv)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;

            string rowcount = tbl.Rows.Count.ToString();
            return rowcount;
        }

        public static string searchResult(string searchtext, DataGridView dgv)
        {
            string rowcount = "";

            String sql = "SELECT items.Title, items.Capacity, Areas.Name, itemtypes.Name FROM items JOIN areas ON items.AreaID = areas.ID JOIN itemtypes ON items.ItemTypeID = itemtypes.ID WHERE items.Title LIKE '%" + searchtext + "%' OR Areas.Name LIKE '%" + searchtext + "%'"; 

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@st", MySqlDbType.VarChar).Value = searchtext;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            
            if (tbl.Rows.Count == 0)
            {
                //String sql2 = "SELECT items.Title, items.Capacity, Areas.Name, itemtypes.Name FROM items JOIN areas ON items.AreaID = areas.ID JOIN itemtypes ON items.ItemTypeID = itemtypes.ID WHERE ";

                //MySqlConnection con2 = GetConnection();
                //MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                //cmd2.CommandType = CommandType.Text;
                //cmd2.Parameters.Add("@st", MySqlDbType.VarChar).Value = searchtext;
                //MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
                //DataTable tbl2 = new DataTable();
                //adp2.Fill(tbl2);
                //if (tbl2.Rows.Count == 0)
                //{

                //}
                //else
                //{
                //    dgv.DataSource = tbl2;
                //    rowcount = tbl2.Rows.Count.ToString();
                //}
            }
            else
            {
                dgv.DataSource = tbl;
                rowcount = tbl.Rows.Count.ToString();
            }
            
            return rowcount;
        }
        public static ArrayList getType()
        {
           ArrayList itemtype = new ArrayList();
            string sql = "SELECT Name FROM itemTypes";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                itemtype.Add(reader.GetString("Name"));
            }
            return itemtype;
        }

        public static ArrayList getItemData(string id)
        {
            ArrayList itemData = new ArrayList();
            string sql = "SELECT IT.Name , I.Title, I.Capacity, I.NumberOfBeds, I.NumberOfBedrooms, I.NumberOfBathrooms, I.ExactAddress, I.ApproximateAddress, I.Description, I.HostRules, I.MinimumNights, I.MaximumNights FROM items I JOIN itemtypes IT ON I.ItemTypeID = IT.ID WHERE I.ID =" + id;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                itemData.Add(reader.GetString("Name"));
                itemData.Add(reader.GetString("Title"));
                itemData.Add(reader.GetInt32("Capacity"));
                itemData.Add(reader.GetInt32("NumberOfBeds"));
                itemData.Add(reader.GetInt32("NumberOfBedrooms"));
                itemData.Add(reader.GetInt32("NumberOfBathrooms"));
                itemData.Add(reader.GetString("ExactAddress"));
                itemData.Add(reader.GetString("ApproximateAddress"));
                itemData.Add(reader.GetString("Description"));
                itemData.Add(reader.GetString("HostRules"));
                itemData.Add(reader.GetInt32("MinimumNights"));
                itemData.Add(reader.GetInt32("MaximumNights"));
            }
            return itemData;
        }

    }
}

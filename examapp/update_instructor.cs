using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace examapp
{
    public partial class update_instructor : Form
    {
        int ins_ID=0;
        public void addcourseitem()
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand cmd;
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);

            comboxCourse.Items.Clear();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  [cr_name] from [dbo].[course]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboxCourse.Items.Add(dr["cr_name"].ToString());
            }
            cnn.Close();
        }
        public void addDepitem()
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand cmd;
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);

            comboxDepartment.Items.Clear();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  [d_name] from [dbo].[Department]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboxDepartment.Items.Add(dr["d_name"].ToString());
            }
            cnn.Close();
        }
        public void addRoleitem()
        {
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("Ins");
            comboBoxRole.Items.Add("admin");

        }
        public int GetcourseID(string cur_name)
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader data_ID;
            // Retrive data  sql command for admin and student and instructor
            string sqlGetID;
            int CourseID = 0;


            //Open connection 
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Select admin or instructor role 
            sqlGetID = "P_Coures_GetID '" + cur_name + "'";
            command = new SqlCommand(sqlGetID, cnn);
            data_ID = command.ExecuteReader();

            // Read data from command admin or instructor
            while (data_ID.Read()) { CourseID = (int)data_ID.GetValue(0); }

            return CourseID;
        }

        public int GetDepID(string dep_name)
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader data_ID;
            // Retrive data  sql command for admin and student and instructor
            string sqlGetID;
            int DepID = 0;


            //Open connection 
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Select admin or instructor role 
            sqlGetID = "P_Dep_GetID '" + dep_name + "'";
            command = new SqlCommand(sqlGetID, cnn);
            data_ID = command.ExecuteReader();

            // Read data from command admin or instructor
            while (data_ID.Read()) { DepID = (int)data_ID.GetValue(0); }

            return DepID;
        }

        public int udpateinst(int ID ,string fname, string lname, string email, string pass, string username, DateTime hiredate, float salary, float rating, int CurID, int DepID, string Roletype)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlCommand command;
                SqlDataReader data;
                // Retrive data  sql command for admin and student and instructor
                string sqlGetID;


                //Open connection 
                connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                // Select admin or instructor role 
                sqlGetID = "P_update_Inst " + ID +",'"+ fname + "'," + "'" + lname + "'," + "'" + email + "'," + "" + pass + "," + "'" + username + "','" + hiredate + "'," + salary + "," + "" + rating + "," + "" + CurID + "," + "" + DepID + "," + "'" + Roletype + "'";
                command = new SqlCommand(sqlGetID, cnn);
                data = command.ExecuteReader();
                return 1;
            }
            catch
            {
                return -1;
            }

            // Read data from command admin or instructor
        }

        public update_instructor(int ID)
        {
            InitializeComponent();
            addcourseitem();

            addDepitem();
            addRoleitem();
            ins_ID = ID;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            int CourseID = GetcourseID((string)comboxCourse.SelectedItem);
            int DepID = GetDepID((string)comboxDepartment.SelectedItem);
            string RoleType = ((string)comboBoxRole.SelectedItem);


            int Status = udpateinst(ins_ID, txtFname.Text, txtLname.Text, txtEmail.Text, txtPassword.Text, txtusername.Text, dateTimePicker1.Value, float.Parse(txtsalary.Text), float.Parse(txtRating.Text), CourseID, DepID, RoleType);
            if (Status == 1)
            {
                MessageBox.Show("Data update Done");
            }
            else
            {
                MessageBox.Show("Error can't update Data  ");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_instructor MST = new Form_instructor();
            MST.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace examapp
{
    public partial class Add_Student : Form
    {
        public void addDepitem()
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand cmd;
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);

            comboxDeprtment.Items.Clear();
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
                comboxDeprtment.Items.Add(dr["d_name"].ToString());
            }
            cnn.Close();
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

        public Add_Student()
        {
            InitializeComponent();
            addDepitem();
        }
        public void  addST(string fname, string lname, string email, string pass, string username, string FB, string Linkedin, int DepID)
        {
            try
            {   string connetionString;
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
            sqlGetID = "Inst_St '" + fname + "'," + "'" + lname + "'," + "'" + username + "'," + "'" + pass + "'," + "'" + email + "','" + FB + "','" + Linkedin + "'," + DepID+",'ST"+"'";
                command = new SqlCommand(sqlGetID, cnn);
                data = command.ExecuteReader();
            MessageBox.Show("add Student Done");
        }
            catch
            {
                MessageBox.Show("can't add Student ");
            }


    // Read data from command admin or instructor
}
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Student_ByAdmin MST = new Form_Student_ByAdmin();
            MST.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int DepID = GetDepID((string)comboxDeprtment.SelectedItem);
            addST(txtFname.Text,txtLname.Text,txtEmail.Text,txtPassword.Text,txtusername.Text,txtFB.Text,txtLinkedin.Text,DepID);

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }
    }
}

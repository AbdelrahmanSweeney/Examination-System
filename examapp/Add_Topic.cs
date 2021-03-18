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
    public partial class Add_Topic : Form
    {
        public Add_Topic()
        {
            InitializeComponent();
            addcourseitem();
        }
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
            cmd.CommandText = "P_Coures_Getall";
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
        public void AddCur(string TopicName, int curID)
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
                sqlGetID = "Inst_topic '" + TopicName + "'," + curID;
                command = new SqlCommand(sqlGetID, cnn);
                data = command.ExecuteReader();

                MessageBox.Show("add Course Done");
            }
            catch
            {
                MessageBox.Show("can't add Course ");
            }

            // Read data from command admin or instructor
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Course MST = new Form_Course();
            MST.Show();
        }

        private void btnaddST_Click(object sender, EventArgs e)
        {
            int CourseID = GetcourseID((string)comboxCourse.SelectedItem);
            AddCur(txtopicName.Text, (CourseID));

        }
    }
}

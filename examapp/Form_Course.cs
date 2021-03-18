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
    public partial class Form_Course : Form
    {
        public Form_Course()
        {
            InitializeComponent();
            addcouresItem();
            addtopicItem();
        }
        
        public void addtopicItem()
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("P_topic_Getall", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGtopic.DataSource = dt;
        }
        public void addcouresItem()
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("P_Coures_Getall", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataG_course.DataSource = dt;
        }
        public void DeleteCourse(int ID)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlCommand cmd;
                connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
                cnn = new SqlConnection(connetionString);

                cnn.Open();
                cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "P_Delete_Cur  " + ID;
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Delete Course Done");
            }
            catch
            {
                MessageBox.Show("can't Delete Course ");
            }
        }
        public void Deletetopic(int ID)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlCommand cmd;
                connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
                cnn = new SqlConnection(connetionString);

                cnn.Open();
                cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete_topic  " + ID;
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Delete Topic Done");
            }
            catch
            {
                MessageBox.Show("can't Delete Topic ");
            }
        }
        private void btnaddCur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Course MST = new Add_Course();
            MST.Show();
        }

        private void addtopic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Topic MST = new Add_Topic();
            MST.Show();
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
            DeleteCourse(int.Parse(dataG_course.CurrentCell.Value.ToString()));
            addcouresItem();
        }

        private void btndeletetopic_Click(object sender, EventArgs e)
        {
            Deletetopic(int.Parse(dataGtopic.CurrentCell.Value.ToString()));
            addtopicItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin MST = new MainAdmin();
            MST.Show();


        }

        private void btnupdatecur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Course MST = new Update_Course(int.Parse(dataG_course.CurrentCell.Value.ToString()));
            MST.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Topic MST = new Update_Topic(int.Parse(dataGtopic.CurrentCell.Value.ToString()));
            MST.Show();
        }
    }
}

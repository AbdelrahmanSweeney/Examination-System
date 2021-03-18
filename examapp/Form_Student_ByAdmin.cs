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
    public partial class Form_Student_ByAdmin : Form
    {
        public Form_Student_ByAdmin()
        {
            InitializeComponent();
            addStudentItem();
        }
        public void addStudentItem()
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("P_Student_Getall", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGStudent.DataSource = dt;
        }
        public void DeleteStudent(int ID)
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
                cmd.CommandText = "P_Delete_st  " + ID;
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Delete Student Done");
            }
            catch
            {
                MessageBox.Show("can't Delete Student ");
            }
        }

        private void btnaddstu_Click(object sender, EventArgs e)

        {
            this.Hide();
            Add_Student MST = new Add_Student();
            MST.Show();
        }


        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            DeleteStudent(int.Parse(dataGStudent.CurrentCell.Value.ToString()));
            addStudentItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin MST = new MainAdmin();
            MST.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            this.Hide();
            Update_Student MST = new Update_Student(int.Parse(dataGStudent.CurrentCell.Value.ToString()));
            MST.Show();
        }
    }
}

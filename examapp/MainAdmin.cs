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
    public partial class MainAdmin : Form
    {

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
    
        public void addinstructorItem()
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("P_Inst_GeAll", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataG_inst.DataSource = dt;
        }

        public MainAdmin()
        {
            InitializeComponent();
            addcouresItem();
            addStudentItem();
            addinstructorItem();
        }

        private void btnAddInst_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_instructor Minst = new Form_instructor();
            Minst.Show();
        }

        private void btnaddstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Student_ByAdmin MST = new Form_Student_ByAdmin();
            MST.Show();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examination_systemDataSet1.instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.examination_systemDataSet1.instructor);

        }

        private void btnDeleteins_Click(object sender, EventArgs e)
        {
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            DeleteStudent(int.Parse(dataGStudent.CurrentCell.Value.ToString()));
            addStudentItem();
        }

        private void btndeletecourse_Click(object sender, EventArgs e)
        {
        
            
        }

        private void btnaddCur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Course MST = new Form_Course();
            MST.Show();
        }

        private void addtopic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Topic MST = new Add_Topic();
            MST.Show();
        }

        private void btndeletetopic_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom MST = new LoginFrom();
            MST.Show();
        }
    }
}

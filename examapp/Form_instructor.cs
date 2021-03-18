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
    public partial class Form_instructor : Form
    {
        public Form_instructor()
        {
            InitializeComponent();
            addinstructorItem();

        }
        public void DeleteInstructor(int ID)
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
                cmd.CommandText = "P_Delete_ins  " + ID;
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Delete Instructor Done");

            }
            catch
            {
                MessageBox.Show("can't Delete Instructor ");

            }
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

        private void btnAddInst_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_instructor Minst = new Add_instructor();
            Minst.Show();
        }

        private void btnDeleteins_Click(object sender, EventArgs e)
        {
            
                DeleteInstructor(int.Parse(dataG_inst.CurrentCell.Value.ToString()));
                addinstructorItem();
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin MST = new MainAdmin();
            MST.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_instructor MST = new update_instructor(int.Parse(dataG_inst.CurrentCell.Value.ToString()));
            MST.Show();
        }
    }
}

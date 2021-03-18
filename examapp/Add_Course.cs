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
    public partial class Add_Course : Form
    {
        public void AddCur(string curName, int curhours)
        {
            try
            { string connetionString;
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
            sqlGetID = "Inst_cr '" + curName + "'," + curhours;
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

        public Add_Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Course MST = new Form_Course();
            MST.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddCur(txtCurName.Text, int.Parse(txtcurhour.Text));

        }

        private void Addcourse_Load(object sender, EventArgs e)
        {

        }
    }
}

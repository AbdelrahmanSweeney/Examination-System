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
    public partial class Update_Topic : Form
    {
        int Cur_ID = 0;
        public Update_Topic(int ID)
        {
            InitializeComponent();
            Cur_ID = ID;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Course MST = new Form_Course();
            MST.Show();
        }
        public void updatetopic(string Topic_name, int topic_ID)
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
                sqlGetID = "update_topic " + topic_ID +  ",'" + Topic_name + "'";
                command = new SqlCommand(sqlGetID, cnn);
                data = command.ExecuteReader();

                MessageBox.Show("update Course Done");
            }
            catch
            {
                MessageBox.Show("can't update Course ");
            }

        }

        private void btnUdpate_Click(object sender, EventArgs e)
        {
            updatetopic(txtopicName.Text,Cur_ID);


        }
    }
}

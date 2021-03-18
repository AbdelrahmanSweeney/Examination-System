using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examapp
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Connetion variables 
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader data_admin_instr, data_St;
            // Retrive data  sql command for admin and student and instructor
            string sqlST, sql_Instr_admin, ST_Role = null, Ins_admin_Role = null;


            //Open connection 
            connetionString = @"Data Source =.; Initial Catalog = 'examination system'; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Select admin or instructor role 
            sql_Instr_admin = "P_Inst_GetRoleType '" + txtusername.Text + "' , '" + txtpassword.Text + "'";
            command = new SqlCommand(sql_Instr_admin, cnn);
            data_admin_instr = command.ExecuteReader();
            // Read data from command admin or instructor
            while (data_admin_instr.Read()) { Ins_admin_Role = (string)data_admin_instr.GetValue(0); }
             
            // check Role
            if (Ins_admin_Role == "Ins")
            {
                this.Hide();
                MainInstructor Minstructor = new MainInstructor();
                Minstructor.Show();

            }
            else if (Ins_admin_Role == "admin")
            {
                this.Hide();
                MainAdmin Minadmin = new MainAdmin();
                Minadmin.Show();
            }


            else {
                data_admin_instr.Close();
                command.Dispose();
                //select student Role 
                sqlST = "P_ST_Role '" + txtusername.Text + "' , '" + txtpassword.Text + "'";
                command = new SqlCommand(sqlST, cnn);
                data_St = command.ExecuteReader();
                // Read data from command student
                while (data_St.Read()) { ST_Role = (string)data_St.GetValue(0); }
                if (ST_Role == "ST")
                {
                    this.Hide();
                    MainStudent MST = new MainStudent();
                    MST.Show();
                }
                else { MessageBox.Show("Data not vaild"); }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examapp
{
    public partial class MainInstructor : Form
    {
        public MainInstructor()
        {
            InitializeComponent();
        }

        private void btnaddstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Student_ByAdmin MST = new Form_Student_ByAdmin();
            MST.Show();
        }
    }
}

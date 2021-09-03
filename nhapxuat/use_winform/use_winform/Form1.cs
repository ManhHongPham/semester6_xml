using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_winform
{
    public partial class a : Form
    {
        StudentService obj = new StudentService();
        public a()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void a_Load(object sender, EventArgs e)
        {

        }

        private void displayData()
        {
            dgvInformation.DataSource = obj.getAllStudent();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

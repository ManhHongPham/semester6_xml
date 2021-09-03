using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtilities data = new DataUtilities();

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }


        //thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //nhập
            Student s = new Student();
            s.Id = txtID.Text;
            s.Name =txtName.Text;
            s.Age = txtAge.Text;
            s.City = txtAddress.Text;

            //kiểm tra 
            Student st = data.FindByID(s.Id);
            if (st==null)
            {
                data.AddStudent(s);
                ClearTextboxs();
            }
            else
            {
                MessageBox.Show("id: " + s.Id + "exist");
            }
            

            //mỗi lần thêm sinh viên sẽ hiển thị danh sách
            DisplayData();
        }

        private void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllStudent();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 200;
            lblMsg.Text = dataGridView1.Rows.Count + "";

        }
        private void ClearTextboxs()// phương thức xóa text trong textbox và đặt con trở điều khiển vào txtid
        {
            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();

            ActiveControl = txtID;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// sự kiện cellclick trong datagridview, hiển thị trực tiếp trên txt
        /// dễ dàng hơn trong việc chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getAStudent(object sender, DataGridViewCellEventArgs e)
        {
            Student s = (Student)dataGridView1.CurrentRow.DataBoundItem;
            txtID.Text = s.Id;
            txtName.Text = s.Name;
            txtAge.Text = s.Age;
            txtAddress.Text = s.City;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = txtID.Text;
            s.Name = txtName.Text;
            s.Age = txtAge.Text;
            s.City = txtAddress.Text;

            bool kt = data.UpdateStudent(s);
            if (!kt)
            {
                MessageBox.Show("no student whose id is " + s.Id);
            }
            DisplayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextboxs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //hiển thị thông báo cho việc xác nhận
            DialogResult d = MessageBox.Show("Bạn có chắc chắn xóa không ? ", 
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool kt = data.DeleteStudent(txtID.Text);
                if (!kt)
                {
                    MessageBox.Show("Có lỗi khi xóa !", "Thông báo");
                    return;
                }

                DisplayData();
                ClearTextboxs();
            }
        }

        private void btnFindByID_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            List<Student> li = new List<Student>();
            Student s = data.FindByID(id);
            if (s != null)
            {
                li.Add(s);
                dataGridView1.DataSource = li;
                lblMsg.Text = dataGridView1.Rows.Count + "";
                txtID.Text = s.Id;
                txtName.Text = s.Name;
                txtAge.Text = s.Age;
                txtAddress.Text = s.City;
            }
            else
            {
                MessageBox.Show("Không có sinh viên có mã = " + id, "Thông báo");
            }
        }

        private void btnFindByCity_Click(object sender, EventArgs e)
        {
            string city = txtAddress.Text;
            dataGridView1.DataSource = data.FindByCity(city);
            lblMsg.Text = dataGridView1.Rows.Count + "";
            ClearTextboxs();
            txtAddress.Text = city;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //define tang service

        DataUtilities data = new DataUtilities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cbChucVu.Items.Add("giam đốc");
            cbChucVu.Items.Add("nhân viên");
            cbChucVu.Items.Add("thư ký");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nhanvien s = new nhanvien();
            s.id = txtId.Text;
            s.name = txtName.Text;
            s.phone = txtPhone.Text;
            s.salary = txtSalary.Text;
            s.street = txtStreet.Text;
            s.address = txtCity.Text;
            s.year = txtYear.Text;
            s.district = txtDistrict.Text;

            s.position = cbChucVu.Text;

            string a = null;
            if (rabtnNam.Checked)
            {
                a = rabtnNam.Text;
            }
            else
            {
                a = rabtnNu.Text;
            }
            s.sex = a;
            
            data.addNhanvien(s);

            DisplayData();
        }

        private void DisplayData()
        {
            dgvInformation.DataSource = data.getAllNhanvien();
            dgvInformation.Columns[0].Width = 50;
            dgvInformation.Columns[1].Width = 50;
            dgvInformation.Columns[2].Width = 50;
            dgvInformation.Columns[3].Width = 50;
            dgvInformation.Columns[4].Width = 50;
            dgvInformation.Columns[5].Width = 50;
            dgvInformation.Columns[6].Width = 50;
            dgvInformation.Columns[7].Width = 50;
            dgvInformation.Columns[8].Width = 50;
            dgvInformation.Columns[9].Width = 200;

            labelTotal.Text = dgvInformation.Rows.Count + "";

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            
            DisplayData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            dgvInformation.DataSource = data.FindByCity(city);
            labelTotal.Text = dgvInformation.Rows.Count + "";
            //ClearTextboxs();
            txtCity.Text = city;
        }

        private void getNhanvien(object sender, DataGridViewCellEventArgs e)
        {
            nhanvien s = (nhanvien)dgvInformation.CurrentRow.DataBoundItem;
            txtId.Text = s.id;
            txtName.Text=s.name;
            txtPhone.Text=s.phone;
            txtSalary.Text=s.salary;
            txtStreet.Text=s.street;
            txtCity.Text=s.address;
            txtYear.Text=s.year;
            txtDistrict.Text= s.district;
            cbChucVu.Text = s.position;
           
            if (s.sex.Equals(rabtnNam.Text))
            {
                rabtnNam.Checked = true;
            }
            else
            {
                rabtnNu.Checked = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}

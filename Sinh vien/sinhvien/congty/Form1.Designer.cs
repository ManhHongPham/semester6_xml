
namespace congty
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnFindByID = new System.Windows.Forms.Button();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.rabtnNam = new System.Windows.Forms.RadioButton();
            this.rabtnNu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "city";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "district";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(81, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 10;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(81, 132);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(100, 20);
            this.txtDistrict.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(81, 170);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(241, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(241, 98);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 14;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(241, 128);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(241, 169);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(520, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(520, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(520, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(602, 61);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 21;
            this.btnLoadFile.Text = "load file";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnFindByID
            // 
            this.btnFindByID.Location = new System.Drawing.Point(602, 96);
            this.btnFindByID.Name = "btnFindByID";
            this.btnFindByID.Size = new System.Drawing.Size(75, 23);
            this.btnFindByID.TabIndex = 22;
            this.btnFindByID.Text = "find by id";
            this.btnFindByID.UseVisualStyleBackColor = true;
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(601, 129);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(75, 23);
            this.btnFindByName.TabIndex = 23;
            this.btnFindByName.Text = "find by name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(602, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Location = new System.Drawing.Point(45, 208);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.Size = new System.Drawing.Size(631, 150);
            this.dgvInformation.TabIndex = 25;
            this.dgvInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getNhanvien);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotal.Location = new System.Drawing.Point(305, 21);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 26;
            this.labelTotal.Text = "0";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(423, 63);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(69, 21);
            this.cbChucVu.TabIndex = 27;
            // 
            // rabtnNam
            // 
            this.rabtnNam.AutoSize = true;
            this.rabtnNam.Location = new System.Drawing.Point(36, 14);
            this.rabtnNam.Name = "rabtnNam";
            this.rabtnNam.Size = new System.Drawing.Size(45, 17);
            this.rabtnNam.TabIndex = 28;
            this.rabtnNam.TabStop = true;
            this.rabtnNam.Text = "nam";
            this.rabtnNam.UseVisualStyleBackColor = true;
            // 
            // rabtnNu
            // 
            this.rabtnNu.AutoSize = true;
            this.rabtnNu.Location = new System.Drawing.Point(36, 36);
            this.rabtnNu.Name = "rabtnNu";
            this.rabtnNu.Size = new System.Drawing.Size(37, 17);
            this.rabtnNu.TabIndex = 29;
            this.rabtnNu.TabStop = true;
            this.rabtnNu.Text = "nữ";
            this.rabtnNu.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabtnNam);
            this.groupBox1.Controls.Add(this.rabtnNu);
            this.groupBox1.Location = new System.Drawing.Point(373, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 60);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "giới tính";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.btnFindByID);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnFindByID;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.RadioButton rabtnNam;
        private System.Windows.Forms.RadioButton rabtnNu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


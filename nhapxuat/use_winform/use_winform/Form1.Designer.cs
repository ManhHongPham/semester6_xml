
namespace use_winform
{
    partial class a
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFindBySid = new System.Windows.Forms.Button();
            this.btFindByAddress = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.lblMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnfix
            // 
            this.btnfix.Location = new System.Drawing.Point(300, 74);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(75, 36);
            this.btnfix.TabIndex = 9;
            this.btnfix.Text = "update";
            this.btnfix.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "clear texbox";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(420, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 36);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "load file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFindBySid
            // 
            this.btnFindBySid.Location = new System.Drawing.Point(420, 74);
            this.btnFindBySid.Name = "btnFindBySid";
            this.btnFindBySid.Size = new System.Drawing.Size(75, 36);
            this.btnFindBySid.TabIndex = 13;
            this.btnFindBySid.Text = "find by sid";
            this.btnFindBySid.UseVisualStyleBackColor = true;
            // 
            // btFindByAddress
            // 
            this.btFindByAddress.Location = new System.Drawing.Point(420, 107);
            this.btFindByAddress.Name = "btFindByAddress";
            this.btFindByAddress.Size = new System.Drawing.Size(75, 36);
            this.btFindByAddress.TabIndex = 14;
            this.btFindByAddress.Text = "find by address";
            this.btFindByAddress.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(420, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Location = new System.Drawing.Point(75, 194);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.Size = new System.Drawing.Size(420, 191);
            this.dgvInformation.TabIndex = 16;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(144, 153);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(13, 13);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "number of student";
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 397);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btFindByAddress);
            this.Controls.Add(this.btnFindBySid);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnfix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "a";
            this.Load += new System.EventHandler(this.a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFindBySid;
        private System.Windows.Forms.Button btFindByAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label6;
    }
}

namespace WindowsFormsApp1
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.middlename = new System.Windows.Forms.TextBox();
            this.houseno = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.barangay = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // middlename
            // 
            this.middlename.BackColor = System.Drawing.Color.Gainsboro;
            this.middlename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middlename.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.middlename.Location = new System.Drawing.Point(838, 162);
            this.middlename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.middlename.Multiline = true;
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(184, 25);
            this.middlename.TabIndex = 3;
            this.middlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // houseno
            // 
            this.houseno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.houseno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.houseno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.houseno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.houseno.Location = new System.Drawing.Point(438, 243);
            this.houseno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.houseno.Multiline = true;
            this.houseno.Name = "houseno";
            this.houseno.Size = new System.Drawing.Size(71, 25);
            this.houseno.TabIndex = 4;
            this.houseno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.houseno.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // street
            // 
            this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.street.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.street.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.street.Location = new System.Drawing.Point(528, 243);
            this.street.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.street.Multiline = true;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(135, 25);
            this.street.TabIndex = 5;
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.street.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // district
            // 
            this.district.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.district.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.district.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.district.Location = new System.Drawing.Point(682, 243);
            this.district.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.district.Multiline = true;
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(112, 25);
            this.district.TabIndex = 6;
            this.district.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.district.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // barangay
            // 
            this.barangay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barangay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barangay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barangay.Location = new System.Drawing.Point(817, 243);
            this.barangay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barangay.Multiline = true;
            this.barangay.Name = "barangay";
            this.barangay.Size = new System.Drawing.Size(210, 25);
            this.barangay.TabIndex = 7;
            this.barangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barangay.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.city.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.city.Location = new System.Drawing.Point(438, 305);
            this.city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(169, 24);
            this.city.TabIndex = 8;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // province
            // 
            this.province.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.province.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.province.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.province.Location = new System.Drawing.Point(628, 305);
            this.province.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.province.Multiline = true;
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(216, 24);
            this.province.TabIndex = 9;
            this.province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.province.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // zip
            // 
            this.zip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zip.Location = new System.Drawing.Point(869, 305);
            this.zip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zip.Multiline = true;
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(153, 24);
            this.zip.TabIndex = 10;
            this.zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox12.Location = new System.Drawing.Point(438, 386);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(152, 23);
            this.textBox12.TabIndex = 11;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.Gainsboro;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.age.Location = new System.Drawing.Point(916, 386);
            this.age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(111, 23);
            this.age.TabIndex = 13;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(507, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 

            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(628, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(750, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(869, 454);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 27);
            this.button4.TabIndex = 17;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxID.Location = new System.Drawing.Point(848, 55);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(174, 31);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.LightGray;
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname.Location = new System.Drawing.Point(438, 162);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(152, 25);
            this.lastname.TabIndex = 1;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.LightGray;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname.Location = new System.Drawing.Point(618, 162);
            this.firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(198, 25);
            this.firstname.TabIndex = 2;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstname.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // birthday
            // 
            this.birthday.CalendarMonthBackground = System.Drawing.Color.White;
            this.birthday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(628, 383);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(256, 26);
            this.birthday.TabIndex = 18;
            this.birthday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(438, 383);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(152, 28);
            this.gender.TabIndex = 19;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 193);
            this.dataGridView1.TabIndex = 20;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.province);
            this.Controls.Add(this.city);
            this.Controls.Add(this.barangay);
            this.Controls.Add(this.district);
            this.Controls.Add(this.street);
            this.Controls.Add(this.houseno);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBoxID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox houseno;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox barangay;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


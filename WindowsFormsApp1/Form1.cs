using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

//This branch is for testing Purposes when merging with other branches work.

namespace WindowsFormsApp1
{

    public partial class UserForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString;

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            update.Enabled = false;
            delete.Enabled = false;
            //Change DataGridView Font Color to Black
            this.dataGridView1.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            update.Enabled = true;
            delete.Enabled = true;
        }


        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from crud_tbl1";
                MySqlConnection mycon2 = new MySqlConnection(connectionString);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void birthday_ValueChanged(object sender, EventArgs e)
        {
         /*   DateTime from = birthday.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            age.Text = (days / 365).ToString("0");  */
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (lastname.Text != "" && firstname.Text != "" && houseno.Text != "" && houseno.Text != "" && street.Text != "" && barangay.Text != "" && city.Text != "" && province.Text != "" && zip.Text != "" && gender.Text != "" && age.Text != "")
            {
                try
                {
                    string query = "insert into crud_tbl1(lastname,firstname,middlename,houseno,street,district,barangay,city,province,zipcode,gender,birthday,age) values('" + this.lastname.Text + "' , '" + this.firstname.Text + "' , '" + this.middlename.Text + "' , '" + this.houseno.Text + "' , '" + this.street.Text + "' , '" + this.district.Text + "' , '" + this.barangay.Text + "' , '" + this.city.Text + "' , '" + this.province.Text + "' , '" + this.zip.Text + "' , '" + this.gender.Text + "' , '" + this.birthday.Text + "' , '" + this.age.Text + "');";
                    MySqlConnection mycon = new MySqlConnection(connectionString);
                    MySqlCommand mycommand = new MySqlCommand(query, mycon);
                    MySqlDataReader Reader;
                    mycon.Open();
                    Reader = mycommand.ExecuteReader();
                    string message = "DATA IS INSERTED! PANIS!";
                    string title = "Congratulation!";
                    MessageBox.Show(message, title);
                    mycon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                lastname.Text = "";
                firstname.Text = "";
                middlename.Text = "";
                houseno.Text = "";
                street.Text = "";
                district.Text = "";
                barangay.Text = "";
                city.Text = "";
                province.Text = "";
                zip.Text = "";
                gender.Text = "-Select-";
                birthday.ResetText();
                age.Text = "";
            }
            else
            {
                string message1 = "Empty Text Field";
                string title1 = "Error!"; 
                MessageBox.Show(message1, title1);
            }
        }



            private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
            textBoxID.Text = gridViewRow.Cells[0].Value.ToString();
            lastname.Text = gridViewRow.Cells[1].Value.ToString();
            firstname.Text = gridViewRow.Cells[2].Value.ToString();
            middlename.Text = gridViewRow.Cells[3].Value.ToString();
            houseno.Text = gridViewRow.Cells[4].Value.ToString();
            street.Text = gridViewRow.Cells[5].Value.ToString();
            district.Text = gridViewRow.Cells[6].Value.ToString();
            barangay.Text = gridViewRow.Cells[7].Value.ToString();
            city.Text = gridViewRow.Cells[8].Value.ToString();
            province.Text = gridViewRow.Cells[9].Value.ToString();
            zip.Text = gridViewRow.Cells[10].Value.ToString();
            gender.Text = gridViewRow.Cells[11].Value.ToString();
        //    birthday.Text = gridViewRow.Cells[11].Value.ToString();
            age.Text = gridViewRow.Cells[13].Value.ToString();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from crud_tbl1 where id = '" + this.textBoxID.Text + "'";
                MySqlConnection mycon2 = new MySqlConnection(connectionString);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataReader MyReader1;
                mycon2.Open();
                MyReader1 = mycommand.ExecuteReader();
                MessageBox.Show("Data is Deleted");

                mycon2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string date = birthday.Value.Date.ToString("yyyy-MM-dd");
                string query = "update crud_tbl1 set lastname = '" + this.lastname.Text + "', firstname = '" + this.firstname.Text + "', middlename = '" + this.middlename.Text + "', houseno = '" + this.houseno.Text + "', street = '" + this.street.Text + "', district = '" + this.district.Text + "' , barangay = '" + this.barangay.Text + "' , city = '" + this.city.Text + "' , province = '" + this.province.Text + "' , zipcode = '" + this.zip.Text + "' , gender = '" + this.gender.Text + "' , birthday = '" + date + "' , age = '" + this.age.Text + "' where id = '" + this.textBoxID.Text + "';";
                MySqlConnection mycon2 = new MySqlConnection(connectionString);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataReader MyReader1;
                mycon2.Open();
                MyReader1 = mycommand.ExecuteReader();
                MessageBox.Show("Data is Updated");

                mycon2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }


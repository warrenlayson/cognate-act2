using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
   
    public partial class UserForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString;

        string con = "datasource=localhost;username=root;password=;database=act2";
         
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into users(last_name,first_name,middle_name,house_no,street,district,brgy,city,province,zipcode,gender,birthday,age) values('" + this.LastName.Text + "','" + this.FirstName.Text + "','" + this.MiddleName.Text + "','" + this.HouseNo.Text + "','" + this.StreetName.Text + "','" + this.DistrictName.Text + "','" + this.BrgyName.Text + "','" + this.CityName.Text + "','" + this.Province.Text + "','" + this.Zip.Text + "','" + this.Gender.Text + "','" + this.Birthday.Text + "','" + this.Age.Text + "');";
                MySqlConnection mycon = new MySqlConnection(con);
                MySqlCommand mycommand = new MySqlCommand(query, mycon);
                MySqlDataReader MyReader1;
                mycon.Open();
                MyReader1 = mycommand.ExecuteReader();
                MessageBox.Show("Data is inserted");

                mycon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("hihi xd");
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

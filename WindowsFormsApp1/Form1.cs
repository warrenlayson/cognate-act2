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


//This branch is for testing Purposes when merging with other branches work.


namespace WindowsFormsApp1
{

    public partial class UserForm : Form
    {

        string con = "datasource=localhost;username=root;password=;database=crud1;";

        string connectionString = ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString;

        string mycon = "datasource=localhost;username=root;password=;database=act2";

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            update.Enabled = false;
        }


            //Change DataGridView Font Color to Black
            this.dataGridView1.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void zip_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }


        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into crud_tbl1(lastname,firstname,middlename,houseno,street,district,barangay,city,province,zipcode,gender,birthday,age) values('" + this.lastname.Text + "' , '" + this.firstname.Text + "' , '" + this.middlename.Text + "' , '" + this.houseno.Text + "' , '" + this.street.Text + "' , '" + this.district.Text + "' , '" + this.barangay.Text + "' , '" + this.city.Text + "' , '" + this.province.Text + "' , '" + this.zip.Text + "' , '" + this.gender.Text + "' , '" + this.birthday.Text + "' , '" + this.age.Text + "');";
                MySqlConnection mycon = new MySqlConnection(con);
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

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            update.Enabled = true;

        private void update_Click(object sender, EventArgs e)
        {
            

        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "Select * from crud_tbl1";
                MySqlConnection mycon2 = new MySqlConnection(con);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = mycommand;

                DataTable dtable = new DataTable();
                adapt.Fill(dtable);

                dataGridView1.DataSource = dtable;
            }
            catch (Exception ex)

                string query = "Select * from users";
                MySqlConnection mycon2 = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, mycon2);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }


        private void birthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = birthday.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            age.Text = (days / 365).ToString("0");
        }

        private void age_TextChanged(object sender, EventArgs e)
        {


        
   

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}

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

            //Change DataGridView Font Color to Black
            this.dataGridView1.ForeColor = Color.Black;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programm?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

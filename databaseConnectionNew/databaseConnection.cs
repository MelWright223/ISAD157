using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseConnectionNew
{

    public partial class databaseConnection : Form
    {
        public databaseConnection()
        {
            InitializeComponent();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void databaseConnection_Load(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }








        public static string sendtext = "";
        private void button1_Click(object sender, EventArgs e)
        {
            sendtext = textBox1.Text;

            userProfilePage b = new userProfilePage();
            this.Hide();
            b.Show();

        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}


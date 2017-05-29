using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankkk
{
    public partial class FormLoign : Form
    {

        public FormLoign()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*'; // gwiazdkowanie hasla
        }
        /*
        private void btnExit_Click(object sender, EventArgs e) // close
        {
            this.Close();
        }
        */
        private void btnLogin_Click(object sender, EventArgs e) // logowanie 
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Login where Username = '" + txtLogin.Text + 
                "' and Password = '" + txtPassword.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1") // jezeli znaleziono klienta o danym hasle i loginie to logujemy sie do main window
            {
                this.Hide();
                FormMainWindow main = new FormMainWindow(txtLogin.Text, txtPassword.Text);
                main.Show();
            }
            else // jesli zle dane to wtedy wiadomosc
            {
                MessageBox.Show("Bad Username or Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {}

        private void lblName_Click(object sender, EventArgs e) {}

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewAccount f = new FormNewAccount();
            f.Show();
        }
    }
}

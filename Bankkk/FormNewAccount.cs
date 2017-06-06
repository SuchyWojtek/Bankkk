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
    public partial class FormNewAccount : Form
    {
        public FormNewAccount()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtEnterPassword.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoign f = new FormLoign();
            f.Show();
        }

        private bool passEnter() // sprawdzam czy potwierdzenie hasla jest ok
        {
            if(txtPassword.Text.ToString() == txtEnterPassword.Text.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool freeLogin() // sprawdzam czy login nie jest zajety
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Login where Username = '" + txtLogin.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool freeFields() // sprawdzam czy wszystkie pola sa zajete
        {
            if (txtLogin.Text.ToString() == "") { return false; }
            else if (txtPassword.Text.ToString() == "") { return false; }
            else if (txtEnterPassword.Text.ToString() == "") { return false; }
            else if (txtFirstName.Text.ToString() == "") { return false; }
            else if (txtSurname.Text.ToString() == "") { return false; }
            else if (txtDateOfBirth.Text.ToString() == "") { return false; }
            else if (txtAge.Text.ToString() == "") { return false; }
            else return true;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(freeFields() == false)
            {
                MessageBox.Show("Free fields!");
            }
            else if (passEnter() == true && freeLogin() == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "insert into Login (Username, Password, Name, Surname, Street, Postalcode, Dateofbirth, Age, Saldo) values ('" +
                    txtLogin.Text.ToString() + "', '" + txtPassword.Text.ToString() + "', '" + txtFirstName.Text.ToString() + "', '" +
                    txtSurname.Text.ToString() + "', '" + txtStreet.Text.ToString() + "', '" + txtPostalCode.Text.ToString() + 
                    "', '" + txtDateOfBirth.Text.ToString() + "', '" + txtAge.Text.ToString() + "', '" + "0')";
                SqlCommand cmd = new SqlCommand(query, con);

                // wykonuje polecenie sql
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // czyszcze txt boxy
                txtLogin.Clear();
                txtPassword.Clear();
                txtFirstName.Clear();
                txtSurname.Clear();
                txtStreet.Clear();
                txtPostalCode.Clear();
                txtEnterPassword.Clear();
                txtDateOfBirth.Clear();
                txtAge.Clear();
            }
            else if (freeLogin() == false)
            {
                txtLogin.Clear();
                MessageBox.Show("This Login is engaged!");
            }
            else
            {
                txtEnterPassword.Clear();
                txtPassword.Clear();
                MessageBox.Show("Incorrect enter password!");
            }
        }
    }
}

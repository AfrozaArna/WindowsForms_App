using System.Text;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Data;

namespace Task3
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-HGJK7T6\\SQLEXPRESS;Initial Catalog=Task2;User ID=DESKTOP-HGJK7T6\\Arna;Password=null;TrustServerCertificate=True; Integrated Security=True;Connect Timeout=30;MultiSubnetFailover=False";
        private object dataGridView;

        public Form1()
        {
            InitializeComponent();
        }



        private void Save(object sender, EventArgs e)
        {
            string Name = textName.Text;
            string Email = textEmail.Text;
            string Contact = textContact.Text;


            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Invalid email address.", "Error");
                return;
            }

            SaveData(Name, Email, Contact);

            MessageBox.Show("Data saved successfully!");
        }

        // Email validation method
        private bool IsValidEmail(string email)
        {
            try
            {
                var regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void SaveData(string name, string email, string contact)
        {
            // Create a SqlConnection and SqlCommand
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Information (Name, Email, Contact) VALUES (@Name, @Email, @Contact)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contact", contact);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            string emailToSearch = textSearch.Text;


            // Search the email in the database

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Information WHERE Email = @Email", connection);
                command.Parameters.AddWithValue("@Email", emailToSearch);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Email exists in the database.", "Result");
                }
                else
                {
                    MessageBox.Show("Email does not exist in the database.", "Result");
                }
            }
        }

    }
}
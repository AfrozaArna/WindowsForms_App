using System.Text;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task2
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-HGJK7T6\\SQLEXPRESS;Initial Catalog=Task2;User ID=DESKTOP-HGJK7T6\\Arna;Password=null;TrustServerCertificate=True; Integrated Security=True;Connect Timeout=30;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string Name = textName.Text;
            string Email = textEmail.Text;
            string Contact = textContact.Text;

            SaveData(Name, Email, Contact);

            MessageBox.Show("Data saved successfully!");
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
    }
}
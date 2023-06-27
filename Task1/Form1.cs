using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task1
{
    public partial class Form1 : Form
    {
        private string csvFilePath = "C:/Users/Arna/source/repos/Task1/Task1/data.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            string Name = textName.Text;
            string Email = TextEmail.Text;
            string Contact = TextContact.Text;

            string csvLine = $"{Name},{Email},{Contact}";

            using (StreamWriter sw = File.AppendText(csvFilePath))
            {
                sw.WriteLine(csvLine);
            }
            MessageBox.Show("Data saved successfully!");
        }
    }
}
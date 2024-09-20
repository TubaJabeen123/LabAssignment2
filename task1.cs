using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab3
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void task1_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void inoutTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle text changes if necessary
        }

        private void outputTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle output text changes if necessary
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = inoutTextBox1.Text;
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Split words, ignoring empty entries

            string pattern = @"^[-+]?\d{1,5}(\.\d{1,5})?$|^[-+]?\.\d{1,5}$";
            Regex regex = new Regex(pattern);
            outputTextBox2.Clear(); // Clear previous output

            foreach (string word in words)
            {
                Match match = regex.Match(word);

                if (match.Success)
                {
                    outputTextBox2.AppendText(word + " "); // Append valid words
                }
                else
                {
                    MessageBox.Show("Invalid: " + word, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

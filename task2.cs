using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab3
{
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
            // Initialize DataGridView with one column
            dataGridView1.Columns.Add("Numbers", "Scientific Notation");
        }

        private void task2_Load(object sender, EventArgs e)
        {
            // Optional: Initialization logic can go here if needed
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            // Assuming you have a TextBox named inputTextBox for user input
            string input = inputTextBox.Text.Trim();
            string pattern = @"^\d+e[+-]?\d+$";
            Regex regex = new Regex(pattern);

            // Validate the input
            if (regex.IsMatch(input))
            {
                // Add the valid input to the DataGridView
                dataGridView1.Rows.Add(input);
                MessageBox.Show($"{input} has been added to the grid.");
                inputTextBox.Clear(); // Clear the input after adding

            }
            else
            {
                MessageBox.Show($"{input} is NOT a valid scientific notation.");
                inputTextBox.Clear(); // Clear the input after adding
            }
        }
    }
}

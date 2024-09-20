using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab3
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
            // Initialize DataGridView with one column for words
            dataGridView1.Columns.Add("Words", "Matching Words");
        }

        private void task3_Load(object sender, EventArgs e)
        {
            // Optional: Any initialization code if needed
        }

        private void inputTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes if necessary
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            // Retrieve input text from the inputTextBox1
            string input = inputTextBox1.Text;

            // Define the regex pattern to match words starting with 't' or 'm'
            string pattern = @"\b[tTmM]\w*";
            Regex regex = new Regex(pattern);

            // Clear previous results in the DataGridView
            dataGridView1.Rows.Clear();

            // Find matches
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value); // Add each matching word to the DataGridView
                inputTextBox1.Clear();
            }

            // Inform the user if no matches were found
            if (matches.Count == 0)
            {
                MessageBox.Show("No words starting with 't' or 'm' were found.");
                inputTextBox1.Clear();
            }
        }
    }
}

using System.Diagnostics;

namespace ArrayAndCollectionsWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string input = txtbxName.Text;
            HasSpecialCharacter(input);
        }

        private List<string> GetName()
        {
            List<string> list = new();
            string input = txtbxName.Text;
            if (string.IsNullOrWhiteSpace(input)) {
                lblErrMsg.Text = "Please enter a name!";
            }
            else if (input.Contains('!') ||
                     input.Contains('@')) { }
            return list;
        }

        /// <summary>
        /// check if a string contains special characters
        /// </summary>
        /// <param name="s">string to check</param>
        /// <returns>false if contains a char out of range (A-Z, ' ')</returns>
        private bool HasSpecialCharacter(string s)
        {
            // create a list of alphabet and a space
            List<char> alphabet = new List<char>();
            alphabet.Add(' ');
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabet.Add(letter);
            }

            // remove duplicate chars in a string
            var unique = new HashSet<char>(s.ToUpper());

            //check if a string contains char from A-Z or a space only
            int count = 0;
            foreach (char letter in alphabet)
            {
                if (unique.Contains(letter))
                {
                    count++;
                }
            }
            return count != unique.Count;
        }
    }
}
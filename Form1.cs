using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = MorseCode(richTextBox1.Text);
        }
        public static string MorseCode(string input)
        {
            var output = new StringBuilder();

            foreach (var character in input.ToUpper())
            {
                switch (character)
                {
                    case 'A': output.Append(".- "); break;
                    case 'B': output.Append("-... "); break;
                    case 'C': output.Append("-.-. "); break;
                    case 'D': output.Append("-.. "); break;
                    case 'E': output.Append(". "); break;
                    case 'F': output.Append("..-. "); break;
                    case 'G': output.Append("--. "); break;
                    case 'H': output.Append(".... "); break;
                    case 'I': output.Append(".. "); break;
                    case 'J': output.Append(".--- "); break;
                    case 'K': output.Append("-.- "); break;
                    case 'L': output.Append(".-.. "); break;
                    case 'M': output.Append("--"); break;
                    case 'N': output.Append("-. "); break;

                }

            }

            return output.ToString();
        }
    }
}

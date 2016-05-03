using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchByRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MatchedlBox.Items.Clear();
            foreach (var line in txtTextbox.Lines)
            {
                MatchCollection matchCollection = Regex.Matches(line, txtPattern.Text);

                if (matchCollection.Count > 0)
                {
                    foreach (Match match in matchCollection)
                    {
                        MatchedlBox.Items.Add(match);
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public partial class Form1 : Form
    {
        private Regex m_Regex = null;


        public Form1()
        {
            InitializeComponent();
            rbIgnoreCase.Click += rbOption_Changed;
            rbNone.Click += rbOption_Changed;
            chkMatchIndex.CheckedChanged += chkMatchIndex_CheckedChanged;
        }

        void chkMatchIndex_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidateTestBox();
        }

        private void rbOption_Changed(object sender, EventArgs e)
        {
            expressionChanged();
        }
        
        private void textBoxRegEx_TextChanged(object sender, EventArgs e)
        {
            // Exit if no regex
            if (textBoxRegEx.Text == String.Empty)
            {
                textBoxRegEx.BackColor = Color.White;
                textBoxTest.BackColor = Color.White;
                statusBarMessage.Text = String.Empty;
                return;
            }
            // Validate regex
            expressionChanged();
        }
        private void expressionChanged()
        {
            RegexOptions opt = RegexOptions.None;
            if (rbIgnoreCase.Checked)
                opt = RegexOptions.IgnoreCase;

            // Validate regex
            try
            {
                m_Regex = new Regex(textBoxRegEx.Text, opt);
                statusBarMessage.Text = String.Empty;
                textBoxRegEx.BackColor = Color.PaleGreen;
                this.ValidateTestBox();
            }
            catch (ArgumentException error)
            {
                statusBarMessage.Text = error.Message;
                textBoxRegEx.BackColor = Color.LightPink;
            }
        }

        private void textBoxTest_TextChanged(object sender, EventArgs e)
        {
            this.ValidateTestBox();
        }

        private void ValidateTestBox()
        {
            txtMatches.Clear();

            // Skip validation if no regex
            if (textBoxRegEx.Text == String.Empty)
            {
                textBoxTest.BackColor = Color.White;
                return;
            }

            // Validate
            MatchCollection matchColl = m_Regex.Matches(textBoxTest.Text);
           if (matchColl.Count > 0)
            {
                statusBarMessage.Text = String.Empty;
                textBoxTest.BackColor = Color.PaleGreen;
                foreach (Match m in matchColl)
                {
                    if(chkMatchIndex.Checked)
                        txtMatches.Text += string.Format("{0} -  at [{1},{2}]{3}", m.Value, m.Index, m.Index + m.Value.Length, Environment.NewLine);
                    else
                        txtMatches.Text += string.Format("{0}{1}", m.Value, Environment.NewLine);
                }
            }
            else
            {
                statusBarMessage.Text = "No match.";
                textBoxTest.BackColor = Color.LightPink;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxRegEx.Clear();
            textBoxTest.Clear();
            txtMatches.Clear();
        }

        private void buttonClearRegex_Click(object sender, EventArgs e)
        {
            textBoxRegEx.Clear();
            txtMatches.Clear();
        }

        private void buttonClearTest_Click(object sender, EventArgs e)
        {
            textBoxTest.Clear();
            txtMatches.Clear();
        }
    }
}
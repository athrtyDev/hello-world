using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberVote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            var vote1 = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote2 = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote3 = panel3.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote4 = panel4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote51 = panel5.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote52 = panel6.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote53 = panel7.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote61 = panel8.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote62 = panel9.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var vote63 = panel10.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
            // Changes from github
        }
    }
}

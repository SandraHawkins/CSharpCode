using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWithTwoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create a new instance of Form2() and make it visible (forms are 
            // invisible by default).
            new Form2().Visible = true;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}

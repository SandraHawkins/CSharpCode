using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBoxMenu
{
    public partial class MyDialog : Form
    {
        public MyDialog()
        {
            InitializeComponent();

            // Put some text into the label
            LblText.Text = "Today is Monday" + Environment.NewLine +
                "We are looking at Listboxes" + Environment.NewLine +
                "and Comboboxes" + Environment.NewLine +
                "and Menus.";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Remove the dialog from memory
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Remove the dialog from memory
            this.Dispose();
        }
    }
}

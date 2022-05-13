using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Model;

namespace SandraTesting
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateControls_Click(object sender, EventArgs e)
        {
            int y = 0;
            for (int i = 1; i <= 10; i++)
            {
                string name = "Button" + i;
                Button button = new Button();
                button.Name = name;
                button.Text = "Button " + i;
                button.Location = new Point(0, y+=20);
                panel1.Controls.Add(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[100];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }

        }
    }
}

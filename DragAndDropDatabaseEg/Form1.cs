using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropDatabaseEg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void learnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.learnerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.learnersDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learnersDataSet.Learner' table. You can move, or remove it, as needed.
            this.learnerTableAdapter.Fill(this.learnersDataSet.Learner);

        }

        private void BtnSearchByRegistration_Click(object sender, EventArgs e)
        {
            learnerTableAdapter.FillByRegistrationFee(learnersDataSet.Learner, 
                 Decimal.Parse(TxtRegistration.Text));
        }
    }
}

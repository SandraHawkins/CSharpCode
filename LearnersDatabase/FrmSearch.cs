using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;

namespace view
{
    public partial class FrmSearch : Form
    {
        private LearnerDAO dao;

        public FrmSearch()
        {
            InitializeComponent();
            dao = new LearnerDAO(); 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            // Make sure the Text property of the three controls are not empty
            
            // Call the dao's SearchLearner method and send across the value
            // from the three controls on the form:
            DataSet dataSet = dao.SearchLearner(LstField.Text, LstOperator.Text, TxtValue.Text);

            // The dataGridView has a DataSource property which you can set to a
            // DataSet. A dataSet will be returned from the SearchLearner method
            // in the DAO class. 
            // The DataSource property must be assigned a DataSet reference
            dataGridView1.DataSource = dataSet;
            // The DataMember property must be assigned the DataTable name in the dataset,
            // use the Table name that you specified in the DAO class:
            // dataAdapter.Fill(dataset, **** tableName *****)
            dataGridView1.DataMember = "LearnerTable";
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            LstField.Items.Add("Name");
            LstField.Items.Add("Address");
            LstField.Items.Add("DateOfBirth");
            LstField.Items.Add("RegistrationFee");
            LstField.Items.Add("Enrolled");
        }

        private void LstField_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the Operator listbox before adding into it
            LstOperator.Items.Clear();  

            switch (LstField.SelectedIndex)
            {
                case 0: // Name
                case 1: // Address
                case 4:
                    LstOperator.Items.Add("=");
                    LstOperator.Items.Add("!=");
                    break;
                case 2:
                case 3:
                    LstOperator.Items.Add("<");
                    LstOperator.Items.Add("<=");
                    LstOperator.Items.Add(">");
                    LstOperator.Items.Add(">=");
                    LstOperator.Items.Add("=");
                    LstOperator.Items.Add("!=");
                    break;
                default:
                    break;
            }
        }
    }
}

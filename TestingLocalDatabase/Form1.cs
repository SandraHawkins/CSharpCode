using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingLocalDatabase.MyLocalDBDataSetTableAdapters;


namespace TestingLocalDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsertIntoDatabase_Click(object sender, EventArgs e)
        {
            // Insert into the database
            TestTableTableAdapter adapter = new TestTableTableAdapter();
            adapter.Insert(TxtName.Text);

            // Focus in textbox for next entry
            TxtName.Focus();
            TxtName.SelectAll();

            // Fill the datatable with the new row just added
            adapter.Fill(myLocalDBDataSet.TestTable);
        }

        private void testTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myLocalDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myLocalDBDataSet.TestTable' table. You can move, or remove it, as needed.
            this.testTableTableAdapter.Fill(this.myLocalDBDataSet.TestTable);

        }
    }
}

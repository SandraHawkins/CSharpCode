using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Validate that all fields have values
            if (nameTextBox.Text == string.Empty || addressTextBox.Text == string.Empty ||
                phoneNumberTextBox.Text == string.Empty)
            {
                MessageBox.Show("Fields cannot be empty"); 
            } else
            {
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pizzaShopDataSet);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaShopDataSet.Pizza' table. You can move, or remove it, as needed.
            this.pizzaTableAdapter.Fill(this.pizzaShopDataSet.Pizza);
            // TODO: This line of code loads data into the 'pizzaShopDataSet.Pizza' table. You can move, or remove it, as needed.
            this.pizzaTableAdapter.Fill(this.pizzaShopDataSet.Pizza);
            // TODO: This line of code loads data into the 'pizzaShopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pizzaShopDataSet.Customer);

            // click the small radiobutton
            RbPersonal.Checked = true;
            LstName.SelectedIndex = 0;
        }

        private void AllRadioButtonCheckChanged(object sender, EventArgs e)
        {
            if (RbPersonal.Checked)
                LblPrice.Text = "6.99";
            else if (RbSmall.Checked)
                LblPrice.Text = "8.99";
            else if (RbMedium.Checked)
                LblPrice.Text = "11.99";
            else 
                LblPrice.Text = "13.99";
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            string name = LstName.Text;
            string size = "";
            if (RbPersonal.Checked)
                size = "Personal";
            else if (RbSmall.Checked)
                size = "Small";
            else if (RbMedium.Checked)
                size = "Medium";
            else
                size = "Large";
            string extraToppings = TxtExtraToppings.Text;
            int quantity = (int)NudQuantity.Value;
            decimal price = Decimal.Parse(LblPrice.Text);

            int custId = int.Parse(idTextBox.Text);

            // Insert the pizza into the database
            pizzaTableAdapter.Insert(custId, name, size, extraToppings, quantity, price);

            // Fill the dataset, so that the datagrid on the form will be populated
            // The fill method must be passed the Table to fill, i.e. DataSet.TableName
            pizzaTableAdapter.Fill(pizzaShopDataSet.Pizza);
        }

        private void BtnSearchByName_Click(object sender, EventArgs e)
        {
            customerTableAdapter.FillByName(pizzaShopDataSet.Customer, TxtSearchByName.Text);
        }

        private void BtnCountCustomers_Click(object sender, EventArgs e)
        {
            int numCustomers = (int)customerTableAdapter.CountCustomers();
            LblCount.Text = numCustomers.ToString();
        }
    }
}

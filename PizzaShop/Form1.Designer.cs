namespace PizzaShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.TxtSearchByName = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSearchByName = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaDataGridView = new System.Windows.Forms.DataGridView();
            this.LstName = new System.Windows.Forms.ListBox();
            this.TxtExtraToppings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RbPersonal = new System.Windows.Forms.RadioButton();
            this.RbSmall = new System.Windows.Forms.RadioButton();
            this.RbMedium = new System.Windows.Forms.RadioButton();
            this.RbLarge = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.NudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnCountCustomers = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDataSet = new PizzaShop.PizzaShopDataSet();
            this.customerTableAdapter = new PizzaShop.PizzaShopDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new PizzaShop.PizzaShopDataSetTableAdapters.TableAdapterManager();
            this.pizzaTableAdapter = new PizzaShop.PizzaShopDataSetTableAdapters.PizzaTableAdapter();
            this.fKPizzaCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPizzaCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(35, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(35, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(35, 121);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(60, 16);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(35, 149);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(99, 16);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(35, 177);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "email:";
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem,
            this.TxtSearchByName,
            this.BtnSearchByName});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(1005, 27);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // TxtSearchByName
            // 
            this.TxtSearchByName.Name = "TxtSearchByName";
            this.TxtSearchByName.Size = new System.Drawing.Size(100, 27);
            // 
            // BtnSearchByName
            // 
            this.BtnSearchByName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnSearchByName.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchByName.Image")));
            this.BtnSearchByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSearchByName.Name = "BtnSearchByName";
            this.BtnSearchByName.Size = new System.Drawing.Size(57, 24);
            this.BtnSearchByName.Text = "Search";
            this.BtnSearchByName.Click += new System.EventHandler(this.BtnSearchByName_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(154, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(64, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(154, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(432, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(154, 115);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(432, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(154, 143);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(432, 22);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(154, 171);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(432, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // pizzaBindingSource
            // 
            this.pizzaBindingSource.DataMember = "FK_Pizza_Customer";
            this.pizzaBindingSource.DataSource = this.customerBindingSource;
            // 
            // pizzaDataGridView
            // 
            this.pizzaDataGridView.AutoGenerateColumns = false;
            this.pizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.pizzaDataGridView.DataSource = this.pizzaBindingSource;
            this.pizzaDataGridView.Location = new System.Drawing.Point(26, 226);
            this.pizzaDataGridView.Name = "pizzaDataGridView";
            this.pizzaDataGridView.RowHeadersWidth = 51;
            this.pizzaDataGridView.RowTemplate.Height = 24;
            this.pizzaDataGridView.Size = new System.Drawing.Size(951, 161);
            this.pizzaDataGridView.TabIndex = 11;
            // 
            // LstName
            // 
            this.LstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstName.FormattingEnabled = true;
            this.LstName.ItemHeight = 25;
            this.LstName.Items.AddRange(new object[] {
            "Hawaiian",
            "Meat Feast",
            "Chicken Lover",
            "Texas BBQ"});
            this.LstName.Location = new System.Drawing.Point(26, 475);
            this.LstName.Name = "LstName";
            this.LstName.Size = new System.Drawing.Size(164, 104);
            this.LstName.TabIndex = 12;
            // 
            // TxtExtraToppings
            // 
            this.TxtExtraToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExtraToppings.Location = new System.Drawing.Point(26, 631);
            this.TxtExtraToppings.Multiline = true;
            this.TxtExtraToppings.Name = "TxtExtraToppings";
            this.TxtExtraToppings.Size = new System.Drawing.Size(394, 67);
            this.TxtExtraToppings.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order a Pizza here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // RbPersonal
            // 
            this.RbPersonal.AutoSize = true;
            this.RbPersonal.Checked = true;
            this.RbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPersonal.Location = new System.Drawing.Point(288, 493);
            this.RbPersonal.Name = "RbPersonal";
            this.RbPersonal.Size = new System.Drawing.Size(110, 29);
            this.RbPersonal.TabIndex = 16;
            this.RbPersonal.TabStop = true;
            this.RbPersonal.Text = "Personal";
            this.RbPersonal.UseVisualStyleBackColor = true;
            this.RbPersonal.CheckedChanged += new System.EventHandler(this.AllRadioButtonCheckChanged);
            // 
            // RbSmall
            // 
            this.RbSmall.AutoSize = true;
            this.RbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSmall.Location = new System.Drawing.Point(288, 520);
            this.RbSmall.Name = "RbSmall";
            this.RbSmall.Size = new System.Drawing.Size(82, 29);
            this.RbSmall.TabIndex = 17;
            this.RbSmall.TabStop = true;
            this.RbSmall.Text = "Small";
            this.RbSmall.UseVisualStyleBackColor = true;
            this.RbSmall.CheckedChanged += new System.EventHandler(this.AllRadioButtonCheckChanged);
            // 
            // RbMedium
            // 
            this.RbMedium.AutoSize = true;
            this.RbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMedium.Location = new System.Drawing.Point(288, 547);
            this.RbMedium.Name = "RbMedium";
            this.RbMedium.Size = new System.Drawing.Size(103, 29);
            this.RbMedium.TabIndex = 18;
            this.RbMedium.TabStop = true;
            this.RbMedium.Text = "Medium";
            this.RbMedium.UseVisualStyleBackColor = true;
            this.RbMedium.CheckedChanged += new System.EventHandler(this.AllRadioButtonCheckChanged);
            // 
            // RbLarge
            // 
            this.RbLarge.AutoSize = true;
            this.RbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbLarge.Location = new System.Drawing.Point(288, 574);
            this.RbLarge.Name = "RbLarge";
            this.RbLarge.Size = new System.Drawing.Size(83, 29);
            this.RbLarge.TabIndex = 19;
            this.RbLarge.TabStop = true;
            this.RbLarge.Text = "Large";
            this.RbLarge.UseVisualStyleBackColor = true;
            this.RbLarge.CheckedChanged += new System.EventHandler(this.AllRadioButtonCheckChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Size";
            // 
            // NudQuantity
            // 
            this.NudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudQuantity.Location = new System.Drawing.Point(546, 475);
            this.NudQuantity.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantity.Name = "NudQuantity";
            this.NudQuantity.Size = new System.Drawing.Size(120, 30);
            this.NudQuantity.TabIndex = 21;
            this.NudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantity";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(550, 574);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(61, 25);
            this.LblPrice.TabIndex = 23;
            this.LblPrice.Text = "€0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Extra Toppings";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(736, 631);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(144, 56);
            this.BtnOrder.TabIndex = 26;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnCountCustomers
            // 
            this.BtnCountCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCountCustomers.Location = new System.Drawing.Point(686, 65);
            this.BtnCountCustomers.Name = "BtnCountCustomers";
            this.BtnCountCustomers.Size = new System.Drawing.Size(194, 53);
            this.BtnCountCustomers.TabIndex = 27;
            this.BtnCountCustomers.Text = "Count Customers";
            this.BtnCountCustomers.UseVisualStyleBackColor = true;
            this.BtnCountCustomers.Click += new System.EventHandler(this.BtnCountCustomers_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(692, 121);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(125, 25);
            this.LblCount.TabIndex = 28;
            this.LblCount.Text = "Query Result";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "custId";
            this.dataGridViewTextBoxColumn2.HeaderText = "custId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn4.HeaderText = "size";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "extraToppings";
            this.dataGridViewTextBoxColumn5.HeaderText = "extraToppings";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn7.HeaderText = "price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pizzaShopDataSet;
            // 
            // pizzaShopDataSet
            // 
            this.pizzaShopDataSet.DataSetName = "PizzaShopDataSet";
            this.pizzaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PizzaTableAdapter = this.pizzaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PizzaShop.PizzaShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pizzaTableAdapter
            // 
            this.pizzaTableAdapter.ClearBeforeFill = true;
            // 
            // fKPizzaCustomerBindingSource
            // 
            this.fKPizzaCustomerBindingSource.DataMember = "FK_Pizza_Customer";
            this.fKPizzaCustomerBindingSource.DataSource = this.customerBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 724);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnCountCustomers);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbLarge);
            this.Controls.Add(this.RbMedium);
            this.Controls.Add(this.RbSmall);
            this.Controls.Add(this.RbPersonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtExtraToppings);
            this.Controls.Add(this.LstName);
            this.Controls.Add(this.pizzaDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPizzaCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PizzaShopDataSet pizzaShopDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private PizzaShopDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private PizzaShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private PizzaShopDataSetTableAdapters.PizzaTableAdapter pizzaTableAdapter;
        private System.Windows.Forms.BindingSource pizzaBindingSource;
        private System.Windows.Forms.DataGridView pizzaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ListBox LstName;
        private System.Windows.Forms.TextBox TxtExtraToppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbPersonal;
        private System.Windows.Forms.RadioButton RbSmall;
        private System.Windows.Forms.RadioButton RbMedium;
        private System.Windows.Forms.RadioButton RbLarge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.ToolStripTextBox TxtSearchByName;
        private System.Windows.Forms.ToolStripButton BtnSearchByName;
        private System.Windows.Forms.Button BtnCountCustomers;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.BindingSource fKPizzaCustomerBindingSource;
    }
}


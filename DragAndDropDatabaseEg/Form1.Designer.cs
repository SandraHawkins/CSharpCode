namespace DragAndDropDatabaseEg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label registrationFeeLabel;
            System.Windows.Forms.Label enrolledLabel;
            this.learnersDataSet = new DragAndDropDatabaseEg.LearnersDataSet();
            this.learnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnerTableAdapter = new DragAndDropDatabaseEg.LearnersDataSetTableAdapters.LearnerTableAdapter();
            this.tableAdapterManager = new DragAndDropDatabaseEg.LearnersDataSetTableAdapters.TableAdapterManager();
            this.learnerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.learnerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registrationFeeTextBox = new System.Windows.Forms.TextBox();
            this.enrolledCheckBox = new System.Windows.Forms.CheckBox();
            this.TxtRegistration = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSearchByRegistration = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            registrationFeeLabel = new System.Windows.Forms.Label();
            enrolledLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.learnersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerBindingNavigator)).BeginInit();
            this.learnerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // learnersDataSet
            // 
            this.learnersDataSet.DataSetName = "LearnersDataSet";
            this.learnersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // learnerBindingSource
            // 
            this.learnerBindingSource.DataMember = "Learner";
            this.learnerBindingSource.DataSource = this.learnersDataSet;
            // 
            // learnerTableAdapter
            // 
            this.learnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LearnerTableAdapter = this.learnerTableAdapter;
            this.tableAdapterManager.UpdateOrder = DragAndDropDatabaseEg.LearnersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // learnerBindingNavigator
            // 
            this.learnerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.learnerBindingNavigator.BindingSource = this.learnerBindingSource;
            this.learnerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.learnerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.learnerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.learnerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.learnerBindingNavigatorSaveItem,
            this.TxtRegistration,
            this.BtnSearchByRegistration});
            this.learnerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.learnerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.learnerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.learnerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.learnerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.learnerBindingNavigator.Name = "learnerBindingNavigator";
            this.learnerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.learnerBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.learnerBindingNavigator.TabIndex = 0;
            this.learnerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // learnerBindingNavigatorSaveItem
            // 
            this.learnerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.learnerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("learnerBindingNavigatorSaveItem.Image")));
            this.learnerBindingNavigatorSaveItem.Name = "learnerBindingNavigatorSaveItem";
            this.learnerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.learnerBindingNavigatorSaveItem.Text = "Save Data";
            this.learnerBindingNavigatorSaveItem.Click += new System.EventHandler(this.learnerBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(64, 90);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.learnerBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(173, 87);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(64, 118);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.learnerBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(173, 115);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(64, 146);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(60, 16);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.learnerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(173, 143);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(64, 174);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(34, 16);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.learnerBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(173, 171);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 22);
            this.ageTextBox.TabIndex = 8;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(64, 203);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(82, 16);
            dateOfBirthLabel.TabIndex = 9;
            dateOfBirthLabel.Text = "date Of Birth:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.learnerBindingSource, "dateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(173, 199);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(311, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 10;
            // 
            // registrationFeeLabel
            // 
            registrationFeeLabel.AutoSize = true;
            registrationFeeLabel.Location = new System.Drawing.Point(64, 230);
            registrationFeeLabel.Name = "registrationFeeLabel";
            registrationFeeLabel.Size = new System.Drawing.Size(103, 16);
            registrationFeeLabel.TabIndex = 11;
            registrationFeeLabel.Text = "registration Fee:";
            // 
            // registrationFeeTextBox
            // 
            this.registrationFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.learnerBindingSource, "registrationFee", true));
            this.registrationFeeTextBox.Location = new System.Drawing.Point(173, 227);
            this.registrationFeeTextBox.Name = "registrationFeeTextBox";
            this.registrationFeeTextBox.Size = new System.Drawing.Size(200, 22);
            this.registrationFeeTextBox.TabIndex = 12;
            // 
            // enrolledLabel
            // 
            enrolledLabel.AutoSize = true;
            enrolledLabel.Location = new System.Drawing.Point(64, 260);
            enrolledLabel.Name = "enrolledLabel";
            enrolledLabel.Size = new System.Drawing.Size(59, 16);
            enrolledLabel.TabIndex = 13;
            enrolledLabel.Text = "enrolled:";
            // 
            // enrolledCheckBox
            // 
            this.enrolledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.learnerBindingSource, "enrolled", true));
            this.enrolledCheckBox.Location = new System.Drawing.Point(173, 255);
            this.enrolledCheckBox.Name = "enrolledCheckBox";
            this.enrolledCheckBox.Size = new System.Drawing.Size(200, 24);
            this.enrolledCheckBox.TabIndex = 14;
            this.enrolledCheckBox.UseVisualStyleBackColor = true;
            // 
            // TxtRegistration
            // 
            this.TxtRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRegistration.Name = "TxtRegistration";
            this.TxtRegistration.Size = new System.Drawing.Size(100, 27);
            // 
            // BtnSearchByRegistration
            // 
            this.BtnSearchByRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnSearchByRegistration.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchByRegistration.Image")));
            this.BtnSearchByRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSearchByRegistration.Name = "BtnSearchByRegistration";
            this.BtnSearchByRegistration.Size = new System.Drawing.Size(161, 24);
            this.BtnSearchByRegistration.Text = "Search By Registration";
            this.BtnSearchByRegistration.Click += new System.EventHandler(this.BtnSearchByRegistration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(registrationFeeLabel);
            this.Controls.Add(this.registrationFeeTextBox);
            this.Controls.Add(enrolledLabel);
            this.Controls.Add(this.enrolledCheckBox);
            this.Controls.Add(this.learnerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.learnersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerBindingNavigator)).EndInit();
            this.learnerBindingNavigator.ResumeLayout(false);
            this.learnerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LearnersDataSet learnersDataSet;
        private System.Windows.Forms.BindingSource learnerBindingSource;
        private LearnersDataSetTableAdapters.LearnerTableAdapter learnerTableAdapter;
        private LearnersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator learnerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton learnerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox registrationFeeTextBox;
        private System.Windows.Forms.CheckBox enrolledCheckBox;
        private System.Windows.Forms.ToolStripTextBox TxtRegistration;
        private System.Windows.Forms.ToolStripButton BtnSearchByRegistration;
    }
}


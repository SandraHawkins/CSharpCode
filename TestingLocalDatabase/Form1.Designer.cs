namespace TestingLocalDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnInsertIntoDatabase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.myLocalDBDataSet = new TestingLocalDatabase.MyLocalDBDataSet();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableTableAdapter = new TestingLocalDatabase.MyLocalDBDataSetTableAdapters.TestTableTableAdapter();
            this.tableAdapterManager = new TestingLocalDatabase.MyLocalDBDataSetTableAdapters.TableAdapterManager();
            this.testTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(101, 84);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(180, 30);
            this.TxtName.TabIndex = 1;
            // 
            // BtnInsertIntoDatabase
            // 
            this.BtnInsertIntoDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertIntoDatabase.Location = new System.Drawing.Point(373, 56);
            this.BtnInsertIntoDatabase.Name = "BtnInsertIntoDatabase";
            this.BtnInsertIntoDatabase.Size = new System.Drawing.Size(225, 84);
            this.BtnInsertIntoDatabase.TabIndex = 2;
            this.BtnInsertIntoDatabase.Text = "Insert into Database";
            this.BtnInsertIntoDatabase.UseVisualStyleBackColor = true;
            this.BtnInsertIntoDatabase.Click += new System.EventHandler(this.BtnInsertIntoDatabase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contents of TestTable in the Database";
            // 
            // myLocalDBDataSet
            // 
            this.myLocalDBDataSet.DataSetName = "MyLocalDBDataSet";
            this.myLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            this.testTableBindingSource.DataSource = this.myLocalDBDataSet;
            // 
            // testTableTableAdapter
            // 
            this.testTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTableTableAdapter = this.testTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TestingLocalDatabase.MyLocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testTableDataGridView
            // 
            this.testTableDataGridView.AutoGenerateColumns = false;
            this.testTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.testTableDataGridView.DataSource = this.testTableBindingSource;
            this.testTableDataGridView.Location = new System.Drawing.Point(98, 232);
            this.testTableDataGridView.Name = "testTableDataGridView";
            this.testTableDataGridView.RowHeadersWidth = 51;
            this.testTableDataGridView.RowTemplate.Height = 24;
            this.testTableDataGridView.Size = new System.Drawing.Size(581, 220);
            this.testTableDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.testTableDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnInsertIntoDatabase);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myLocalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnInsertIntoDatabase;
        private System.Windows.Forms.Label label2;
        private MyLocalDBDataSet myLocalDBDataSet;
        private System.Windows.Forms.BindingSource testTableBindingSource;
        private MyLocalDBDataSetTableAdapters.TestTableTableAdapter testTableTableAdapter;
        private MyLocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView testTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}


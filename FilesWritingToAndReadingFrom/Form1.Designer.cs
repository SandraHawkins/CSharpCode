namespace FilesWritingToAndReadingFrom
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
            this.BtnWriteToFile = new System.Windows.Forms.Button();
            this.BtnReadFromFile = new System.Windows.Forms.Button();
            this.BtnReadFromFileOneLiner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxProducts = new System.Windows.Forms.GroupBox();
            this.BtnLoadProductFromFile = new System.Windows.Forms.Button();
            this.BtnClearTextboxes = new System.Windows.Forms.Button();
            this.BtnSaveProductToFile = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.LblRecordNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBoxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnWriteToFile
            // 
            this.BtnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWriteToFile.Location = new System.Drawing.Point(16, 40);
            this.BtnWriteToFile.Name = "BtnWriteToFile";
            this.BtnWriteToFile.Size = new System.Drawing.Size(141, 80);
            this.BtnWriteToFile.TabIndex = 0;
            this.BtnWriteToFile.Text = "Write to File";
            this.BtnWriteToFile.UseVisualStyleBackColor = true;
            this.BtnWriteToFile.Click += new System.EventHandler(this.BtnWriteToFile_Click);
            // 
            // BtnReadFromFile
            // 
            this.BtnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadFromFile.Location = new System.Drawing.Point(370, 40);
            this.BtnReadFromFile.Name = "BtnReadFromFile";
            this.BtnReadFromFile.Size = new System.Drawing.Size(235, 80);
            this.BtnReadFromFile.TabIndex = 1;
            this.BtnReadFromFile.Text = "Read from File with Exception Handling";
            this.BtnReadFromFile.UseVisualStyleBackColor = true;
            this.BtnReadFromFile.Click += new System.EventHandler(this.BtnReadFromFile_Click);
            // 
            // BtnReadFromFileOneLiner
            // 
            this.BtnReadFromFileOneLiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadFromFileOneLiner.Location = new System.Drawing.Point(163, 40);
            this.BtnReadFromFileOneLiner.Name = "BtnReadFromFileOneLiner";
            this.BtnReadFromFileOneLiner.Size = new System.Drawing.Size(201, 80);
            this.BtnReadFromFileOneLiner.TabIndex = 2;
            this.BtnReadFromFileOneLiner.Text = "Read From File - One Liner";
            this.BtnReadFromFileOneLiner.UseVisualStyleBackColor = true;
            this.BtnReadFromFileOneLiner.Click += new System.EventHandler(this.BtnReadFromFileOneLiner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnWriteToFile);
            this.groupBox1.Controls.Add(this.BtnReadFromFile);
            this.groupBox1.Controls.Add(this.BtnReadFromFileOneLiner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demo on Wrting to and Reading from a File";
            // 
            // GroupBoxProducts
            // 
            this.GroupBoxProducts.Controls.Add(this.BtnLoadProductFromFile);
            this.GroupBoxProducts.Controls.Add(this.BtnClearTextboxes);
            this.GroupBoxProducts.Controls.Add(this.BtnSaveProductToFile);
            this.GroupBoxProducts.Controls.Add(this.TxtPrice);
            this.GroupBoxProducts.Controls.Add(this.label4);
            this.GroupBoxProducts.Controls.Add(this.TxtQuantityPerUnit);
            this.GroupBoxProducts.Controls.Add(this.label3);
            this.GroupBoxProducts.Controls.Add(this.TxtName);
            this.GroupBoxProducts.Controls.Add(this.label2);
            this.GroupBoxProducts.Controls.Add(this.TxtId);
            this.GroupBoxProducts.Controls.Add(this.label1);
            this.GroupBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxProducts.Location = new System.Drawing.Point(30, 248);
            this.GroupBoxProducts.Name = "GroupBoxProducts";
            this.GroupBoxProducts.Size = new System.Drawing.Size(846, 275);
            this.GroupBoxProducts.TabIndex = 4;
            this.GroupBoxProducts.TabStop = false;
            this.GroupBoxProducts.Text = "Saving Product Information to File";
            // 
            // BtnLoadProductFromFile
            // 
            this.BtnLoadProductFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadProductFromFile.Location = new System.Drawing.Point(570, 185);
            this.BtnLoadProductFromFile.Name = "BtnLoadProductFromFile";
            this.BtnLoadProductFromFile.Size = new System.Drawing.Size(247, 75);
            this.BtnLoadProductFromFile.TabIndex = 9;
            this.BtnLoadProductFromFile.Text = "Load Product from File";
            this.BtnLoadProductFromFile.UseVisualStyleBackColor = true;
            this.BtnLoadProductFromFile.Click += new System.EventHandler(this.BtnLoadProductFromFile_Click);
            // 
            // BtnClearTextboxes
            // 
            this.BtnClearTextboxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearTextboxes.Location = new System.Drawing.Point(570, 103);
            this.BtnClearTextboxes.Name = "BtnClearTextboxes";
            this.BtnClearTextboxes.Size = new System.Drawing.Size(247, 75);
            this.BtnClearTextboxes.TabIndex = 8;
            this.BtnClearTextboxes.Text = "Clear Textboxes";
            this.BtnClearTextboxes.UseVisualStyleBackColor = true;
            this.BtnClearTextboxes.Click += new System.EventHandler(this.BtnClearTextboxes_Click);
            // 
            // BtnSaveProductToFile
            // 
            this.BtnSaveProductToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProductToFile.Location = new System.Drawing.Point(570, 22);
            this.BtnSaveProductToFile.Name = "BtnSaveProductToFile";
            this.BtnSaveProductToFile.Size = new System.Drawing.Size(247, 75);
            this.BtnSaveProductToFile.TabIndex = 3;
            this.BtnSaveProductToFile.Text = "Save Product to File";
            this.BtnSaveProductToFile.UseVisualStyleBackColor = true;
            this.BtnSaveProductToFile.Click += new System.EventHandler(this.BtnSaveProductToFile_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(200, 185);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(164, 30);
            this.TxtPrice.TabIndex = 7;
            this.TxtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrice_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price €";
            // 
            // TxtQuantityPerUnit
            // 
            this.TxtQuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantityPerUnit.Location = new System.Drawing.Point(200, 138);
            this.TxtQuantityPerUnit.Name = "TxtQuantityPerUnit";
            this.TxtQuantityPerUnit.Size = new System.Drawing.Size(333, 30);
            this.TxtQuantityPerUnit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity Per Unit";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(200, 92);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(333, 30);
            this.TxtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(200, 47);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(164, 30);
            this.TxtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(439, 539);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(79, 67);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(126, 539);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(79, 67);
            this.BtnPrevious.TabIndex = 6;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.Location = new System.Drawing.Point(41, 539);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(79, 67);
            this.BtnFirst.TabIndex = 7;
            this.BtnFirst.Text = "|<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(524, 539);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(79, 67);
            this.BtnLast.TabIndex = 8;
            this.BtnLast.Text = ">|";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // LblRecordNumber
            // 
            this.LblRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecordNumber.Location = new System.Drawing.Point(211, 539);
            this.LblRecordNumber.Name = "LblRecordNumber";
            this.LblRecordNumber.Size = new System.Drawing.Size(222, 60);
            this.LblRecordNumber.TabIndex = 10;
            this.LblRecordNumber.Text = "Record 0 of 0";
            this.LblRecordNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 634);
            this.Controls.Add(this.LblRecordNumber);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.GroupBoxProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Writing to and Reading from Files";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.GroupBoxProducts.ResumeLayout(false);
            this.GroupBoxProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnWriteToFile;
        private System.Windows.Forms.Button BtnReadFromFile;
        private System.Windows.Forms.Button BtnReadFromFileOneLiner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxProducts;
        private System.Windows.Forms.Button BtnLoadProductFromFile;
        private System.Windows.Forms.Button BtnClearTextboxes;
        private System.Windows.Forms.Button BtnSaveProductToFile;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuantityPerUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label LblRecordNumber;
    }
}


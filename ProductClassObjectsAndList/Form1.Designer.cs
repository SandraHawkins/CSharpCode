namespace view
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
            this.LblRecordNumber = new System.Windows.Forms.Label();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.GroupBoxProducts = new System.Windows.Forms.GroupBox();
            this.PnlTextboxes = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLoadProductsFromFile = new System.Windows.Forms.Button();
            this.BtnClearTextboxes = new System.Windows.Forms.Button();
            this.BtnSaveListToFile = new System.Windows.Forms.Button();
            this.BtnSaveProductToList = new System.Windows.Forms.Button();
            this.GroupBoxProducts.SuspendLayout();
            this.PnlTextboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRecordNumber
            // 
            this.LblRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecordNumber.Location = new System.Drawing.Point(213, 335);
            this.LblRecordNumber.Name = "LblRecordNumber";
            this.LblRecordNumber.Size = new System.Drawing.Size(222, 60);
            this.LblRecordNumber.TabIndex = 16;
            this.LblRecordNumber.Text = "Record 0 of 0";
            this.LblRecordNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(526, 335);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(79, 67);
            this.BtnLast.TabIndex = 15;
            this.BtnLast.Text = ">|";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.Location = new System.Drawing.Point(43, 335);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(79, 67);
            this.BtnFirst.TabIndex = 14;
            this.BtnFirst.Text = "|<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(128, 335);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(79, 67);
            this.BtnPrevious.TabIndex = 13;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(441, 335);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(79, 67);
            this.BtnNext.TabIndex = 12;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // GroupBoxProducts
            // 
            this.GroupBoxProducts.Controls.Add(this.PnlTextboxes);
            this.GroupBoxProducts.Controls.Add(this.label4);
            this.GroupBoxProducts.Controls.Add(this.label3);
            this.GroupBoxProducts.Controls.Add(this.label2);
            this.GroupBoxProducts.Controls.Add(this.label1);
            this.GroupBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxProducts.Location = new System.Drawing.Point(22, 43);
            this.GroupBoxProducts.Name = "GroupBoxProducts";
            this.GroupBoxProducts.Size = new System.Drawing.Size(601, 275);
            this.GroupBoxProducts.TabIndex = 11;
            this.GroupBoxProducts.TabStop = false;
            this.GroupBoxProducts.Text = "Saving Product Information to File";
            // 
            // PnlTextboxes
            // 
            this.PnlTextboxes.Controls.Add(this.TxtId);
            this.PnlTextboxes.Controls.Add(this.TxtName);
            this.PnlTextboxes.Controls.Add(this.TxtQuantityPerUnit);
            this.PnlTextboxes.Controls.Add(this.TxtPrice);
            this.PnlTextboxes.Location = new System.Drawing.Point(186, 47);
            this.PnlTextboxes.Name = "PnlTextboxes";
            this.PnlTextboxes.Size = new System.Drawing.Size(375, 213);
            this.PnlTextboxes.TabIndex = 17;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(18, 19);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(164, 30);
            this.TxtId.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(18, 64);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(333, 30);
            this.TxtName.TabIndex = 3;
            // 
            // TxtQuantityPerUnit
            // 
            this.TxtQuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantityPerUnit.Location = new System.Drawing.Point(18, 110);
            this.TxtQuantityPerUnit.Name = "TxtQuantityPerUnit";
            this.TxtQuantityPerUnit.Size = new System.Drawing.Size(333, 30);
            this.TxtQuantityPerUnit.TabIndex = 5;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(18, 157);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(164, 30);
            this.TxtPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity Per Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // BtnLoadProductsFromFile
            // 
            this.BtnLoadProductsFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadProductsFromFile.Location = new System.Drawing.Point(644, 297);
            this.BtnLoadProductsFromFile.Name = "BtnLoadProductsFromFile";
            this.BtnLoadProductsFromFile.Size = new System.Drawing.Size(247, 75);
            this.BtnLoadProductsFromFile.TabIndex = 9;
            this.BtnLoadProductsFromFile.Text = "Load Products from File";
            this.BtnLoadProductsFromFile.UseVisualStyleBackColor = true;
            this.BtnLoadProductsFromFile.Click += new System.EventHandler(this.BtnLoadProductsFromFile_Click);
            // 
            // BtnClearTextboxes
            // 
            this.BtnClearTextboxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearTextboxes.Location = new System.Drawing.Point(644, 216);
            this.BtnClearTextboxes.Name = "BtnClearTextboxes";
            this.BtnClearTextboxes.Size = new System.Drawing.Size(247, 75);
            this.BtnClearTextboxes.TabIndex = 8;
            this.BtnClearTextboxes.Text = "Clear Textboxes";
            this.BtnClearTextboxes.UseVisualStyleBackColor = true;
            this.BtnClearTextboxes.Click += new System.EventHandler(this.BtnClearTextboxes_Click);
            // 
            // BtnSaveListToFile
            // 
            this.BtnSaveListToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveListToFile.Location = new System.Drawing.Point(644, 135);
            this.BtnSaveListToFile.Name = "BtnSaveListToFile";
            this.BtnSaveListToFile.Size = new System.Drawing.Size(247, 75);
            this.BtnSaveListToFile.TabIndex = 3;
            this.BtnSaveListToFile.Text = "Save List to File";
            this.BtnSaveListToFile.UseVisualStyleBackColor = true;
            this.BtnSaveListToFile.Click += new System.EventHandler(this.BtnSaveProductToFile_Click);
            // 
            // BtnSaveProductToList
            // 
            this.BtnSaveProductToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProductToList.Location = new System.Drawing.Point(644, 54);
            this.BtnSaveProductToList.Name = "BtnSaveProductToList";
            this.BtnSaveProductToList.Size = new System.Drawing.Size(247, 75);
            this.BtnSaveProductToList.TabIndex = 17;
            this.BtnSaveProductToList.Text = "Save Product to List";
            this.BtnSaveProductToList.UseVisualStyleBackColor = true;
            this.BtnSaveProductToList.Click += new System.EventHandler(this.BtnSaveProductToList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 452);
            this.Controls.Add(this.BtnSaveProductToList);
            this.Controls.Add(this.LblRecordNumber);
            this.Controls.Add(this.BtnLoadProductsFromFile);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnClearTextboxes);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.BtnSaveListToFile);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.GroupBoxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxProducts.ResumeLayout(false);
            this.GroupBoxProducts.PerformLayout();
            this.PnlTextboxes.ResumeLayout(false);
            this.PnlTextboxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRecordNumber;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.GroupBox GroupBoxProducts;
        private System.Windows.Forms.Button BtnLoadProductsFromFile;
        private System.Windows.Forms.Button BtnClearTextboxes;
        private System.Windows.Forms.Button BtnSaveListToFile;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuantityPerUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlTextboxes;
        private System.Windows.Forms.Button BtnSaveProductToList;
    }
}


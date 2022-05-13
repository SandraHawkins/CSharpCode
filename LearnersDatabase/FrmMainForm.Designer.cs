namespace view
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRegFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.CbEnrolled = new System.Windows.Forms.CheckBox();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRecordNumber = new System.Windows.Forms.TextBox();
            this.BtnInsertLearner = new System.Windows.Forms.Button();
            this.BtnClearForm = new System.Windows.Forms.Button();
            this.BtnUpdateLearner = new System.Windows.Forms.Button();
            this.BtnDeleteLearner = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOpenSearchForm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learners Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Id";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(284, 88);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(312, 34);
            this.TxtId.TabIndex = 1;
            this.TxtId.TabStop = false;
            this.toolTip1.SetToolTip(this.TxtId, "This is the Learner\'s id, it is auto-generated in the database");
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(284, 198);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(312, 139);
            this.TxtAddress.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TxtAddress, "Learner\'s Address");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Name";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(284, 147);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(312, 34);
            this.TxtName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxtName, "Learner\'s name");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Address";
            // 
            // TxtRegFee
            // 
            this.TxtRegFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegFee.Location = new System.Drawing.Point(284, 420);
            this.TxtRegFee.Name = "TxtRegFee";
            this.TxtRegFee.Size = new System.Drawing.Size(312, 34);
            this.TxtRegFee.TabIndex = 5;
            this.toolTip1.SetToolTip(this.TxtRegFee, "Learner\'s Registration Fee");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Registration Fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "&Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "&Enrolled";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(284, 362);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(436, 34);
            this.DtpDateOfBirth.TabIndex = 4;
            this.toolTip1.SetToolTip(this.DtpDateOfBirth, "Learner\'s Date of Birth");
            // 
            // CbEnrolled
            // 
            this.CbEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEnrolled.Location = new System.Drawing.Point(284, 481);
            this.CbEnrolled.Name = "CbEnrolled";
            this.CbEnrolled.Size = new System.Drawing.Size(18, 17);
            this.CbEnrolled.TabIndex = 6;
            this.CbEnrolled.UseVisualStyleBackColor = true;
            // 
            // BtnFirst
            // 
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.Location = new System.Drawing.Point(11, 29);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(86, 80);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "<<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(103, 29);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(86, 80);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(490, 25);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(86, 80);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(586, 25);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(86, 80);
            this.BtnLast.TabIndex = 4;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRecordNumber);
            this.groupBox1.Controls.Add(this.BtnFirst);
            this.groupBox1.Controls.Add(this.BtnLast);
            this.groupBox1.Controls.Add(this.BtnPrevious);
            this.groupBox1.Controls.Add(this.BtnNext);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // TxtRecordNumber
            // 
            this.TxtRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecordNumber.Location = new System.Drawing.Point(208, 49);
            this.TxtRecordNumber.Name = "TxtRecordNumber";
            this.TxtRecordNumber.ReadOnly = true;
            this.TxtRecordNumber.Size = new System.Drawing.Size(263, 38);
            this.TxtRecordNumber.TabIndex = 2;
            this.TxtRecordNumber.Text = "0 of 0";
            this.TxtRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnInsertLearner
            // 
            this.BtnInsertLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertLearner.Location = new System.Drawing.Point(780, 33);
            this.BtnInsertLearner.Name = "BtnInsertLearner";
            this.BtnInsertLearner.Size = new System.Drawing.Size(198, 64);
            this.BtnInsertLearner.TabIndex = 8;
            this.BtnInsertLearner.Text = "Insert";
            this.toolTip1.SetToolTip(this.BtnInsertLearner, "Click to insert a learner");
            this.BtnInsertLearner.UseVisualStyleBackColor = true;
            this.BtnInsertLearner.Click += new System.EventHandler(this.BtnInsertLearner_Click);
            // 
            // BtnClearForm
            // 
            this.BtnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearForm.Location = new System.Drawing.Point(780, 243);
            this.BtnClearForm.Name = "BtnClearForm";
            this.BtnClearForm.Size = new System.Drawing.Size(198, 64);
            this.BtnClearForm.TabIndex = 11;
            this.BtnClearForm.Text = "Clear Form";
            this.BtnClearForm.UseVisualStyleBackColor = true;
            this.BtnClearForm.Click += new System.EventHandler(this.BtnClearForm_Click);
            // 
            // BtnUpdateLearner
            // 
            this.BtnUpdateLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateLearner.Location = new System.Drawing.Point(780, 103);
            this.BtnUpdateLearner.Name = "BtnUpdateLearner";
            this.BtnUpdateLearner.Size = new System.Drawing.Size(198, 64);
            this.BtnUpdateLearner.TabIndex = 9;
            this.BtnUpdateLearner.Text = "Update";
            this.toolTip1.SetToolTip(this.BtnUpdateLearner, "Update a Learner");
            this.BtnUpdateLearner.UseVisualStyleBackColor = true;
            this.BtnUpdateLearner.Click += new System.EventHandler(this.BtnUpdateLearner_Click);
            // 
            // BtnDeleteLearner
            // 
            this.BtnDeleteLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteLearner.Location = new System.Drawing.Point(780, 173);
            this.BtnDeleteLearner.Name = "BtnDeleteLearner";
            this.BtnDeleteLearner.Size = new System.Drawing.Size(198, 64);
            this.BtnDeleteLearner.TabIndex = 10;
            this.BtnDeleteLearner.Text = "Delete";
            this.BtnDeleteLearner.UseVisualStyleBackColor = true;
            this.BtnDeleteLearner.Click += new System.EventHandler(this.BtnDeleteLearner_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(780, 313);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(198, 64);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOpenSearchForm
            // 
            this.BtnOpenSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenSearchForm.Location = new System.Drawing.Point(780, 383);
            this.BtnOpenSearchForm.Name = "BtnOpenSearchForm";
            this.BtnOpenSearchForm.Size = new System.Drawing.Size(198, 64);
            this.BtnOpenSearchForm.TabIndex = 13;
            this.BtnOpenSearchForm.Text = "Search...";
            this.BtnOpenSearchForm.UseVisualStyleBackColor = true;
            this.BtnOpenSearchForm.Click += new System.EventHandler(this.BtnOpenSearchForm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(780, 523);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(198, 64);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(780, 453);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(198, 64);
            this.BtnPrint.TabIndex = 14;
            this.BtnPrint.Text = "Print...";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 693);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnOpenSearchForm);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeleteLearner);
            this.Controls.Add(this.BtnUpdateLearner);
            this.Controls.Add(this.BtnClearForm);
            this.Controls.Add(this.BtnInsertLearner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbEnrolled);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtRegFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Learners Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRegFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.CheckBox CbEnrolled;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRecordNumber;
        private System.Windows.Forms.Button BtnInsertLearner;
        private System.Windows.Forms.Button BtnClearForm;
        private System.Windows.Forms.Button BtnUpdateLearner;
        private System.Windows.Forms.Button BtnDeleteLearner;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOpenSearchForm;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


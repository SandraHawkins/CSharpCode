namespace Revision
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
            this.TxtOne = new System.Windows.Forms.TextBox();
            this.TxtTwo = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LstDaysOfWeek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDayOfWeekSelected = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RbPersonal = new System.Windows.Forms.RadioButton();
            this.RbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbMedium = new System.Windows.Forms.RadioButton();
            this.RbLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtOne
            // 
            this.TxtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOne.Location = new System.Drawing.Point(62, 81);
            this.TxtOne.Name = "TxtOne";
            this.TxtOne.Size = new System.Drawing.Size(100, 34);
            this.TxtOne.TabIndex = 0;
            // 
            // TxtTwo
            // 
            this.TxtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTwo.Location = new System.Drawing.Point(232, 81);
            this.TxtTwo.Name = "TxtTwo";
            this.TxtTwo.Size = new System.Drawing.Size(100, 34);
            this.TxtTwo.TabIndex = 1;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(368, 81);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(81, 29);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "Result";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(537, 62);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(160, 48);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Two";
            // 
            // LstDaysOfWeek
            // 
            this.LstDaysOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDaysOfWeek.FormattingEnabled = true;
            this.LstDaysOfWeek.ItemHeight = 29;
            this.LstDaysOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.LstDaysOfWeek.Location = new System.Drawing.Point(66, 215);
            this.LstDaysOfWeek.Name = "LstDaysOfWeek";
            this.LstDaysOfWeek.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstDaysOfWeek.Size = new System.Drawing.Size(166, 120);
            this.LstDaysOfWeek.TabIndex = 6;
            this.LstDaysOfWeek.SelectedIndexChanged += new System.EventHandler(this.LstDaysOfWeek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Days of the week";
            // 
            // TxtDayOfWeekSelected
            // 
            this.TxtDayOfWeekSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDayOfWeekSelected.Location = new System.Drawing.Point(66, 401);
            this.TxtDayOfWeekSelected.Multiline = true;
            this.TxtDayOfWeekSelected.Name = "TxtDayOfWeekSelected";
            this.TxtDayOfWeekSelected.Size = new System.Drawing.Size(315, 214);
            this.TxtDayOfWeekSelected.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Which days are selected";
            // 
            // RbPersonal
            // 
            this.RbPersonal.AutoSize = true;
            this.RbPersonal.Location = new System.Drawing.Point(22, 43);
            this.RbPersonal.Name = "RbPersonal";
            this.RbPersonal.Size = new System.Drawing.Size(130, 33);
            this.RbPersonal.TabIndex = 10;
            this.RbPersonal.TabStop = true;
            this.RbPersonal.Text = "Personal";
            this.RbPersonal.UseVisualStyleBackColor = true;
            this.RbPersonal.CheckedChanged += new System.EventHandler(this.ARadioButtonWasChecked);
            // 
            // RbSmall
            // 
            this.RbSmall.AutoSize = true;
            this.RbSmall.Location = new System.Drawing.Point(22, 79);
            this.RbSmall.Name = "RbSmall";
            this.RbSmall.Size = new System.Drawing.Size(95, 33);
            this.RbSmall.TabIndex = 11;
            this.RbSmall.TabStop = true;
            this.RbSmall.Text = "Small";
            this.RbSmall.UseVisualStyleBackColor = true;
            this.RbSmall.CheckedChanged += new System.EventHandler(this.ARadioButtonWasChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbLarge);
            this.groupBox1.Controls.Add(this.RbMedium);
            this.groupBox1.Controls.Add(this.RbSmall);
            this.groupBox1.Controls.Add(this.RbPersonal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(494, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 220);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Size";
            // 
            // RbMedium
            // 
            this.RbMedium.AutoSize = true;
            this.RbMedium.Location = new System.Drawing.Point(22, 116);
            this.RbMedium.Name = "RbMedium";
            this.RbMedium.Size = new System.Drawing.Size(121, 33);
            this.RbMedium.TabIndex = 12;
            this.RbMedium.TabStop = true;
            this.RbMedium.Text = "Medium";
            this.RbMedium.UseVisualStyleBackColor = true;
            this.RbMedium.CheckedChanged += new System.EventHandler(this.ARadioButtonWasChecked);
            // 
            // RbLarge
            // 
            this.RbLarge.AutoSize = true;
            this.RbLarge.Location = new System.Drawing.Point(22, 159);
            this.RbLarge.Name = "RbLarge";
            this.RbLarge.Size = new System.Drawing.Size(96, 33);
            this.RbLarge.TabIndex = 13;
            this.RbLarge.TabStop = true;
            this.RbLarge.Text = "Large";
            this.RbLarge.UseVisualStyleBackColor = true;
            this.RbLarge.CheckedChanged += new System.EventHandler(this.ARadioButtonWasChecked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDayOfWeekSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstDaysOfWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtTwo);
            this.Controls.Add(this.TxtOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOne;
        private System.Windows.Forms.TextBox TxtTwo;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LstDaysOfWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDayOfWeekSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbPersonal;
        private System.Windows.Forms.RadioButton RbSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbLarge;
        private System.Windows.Forms.RadioButton RbMedium;
    }
}


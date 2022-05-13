namespace RadioButtonsCheckBoxesLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnClickMe = new System.Windows.Forms.Button();
            this.TxtUserInput = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RbRed = new System.Windows.Forms.RadioButton();
            this.RbGreen = new System.Windows.Forms.RadioButton();
            this.RbBlue = new System.Windows.Forms.RadioButton();
            this.LblColour = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnWhichRadioButton = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.CbSausages = new System.Windows.Forms.CheckBox();
            this.CbStreakyBacon = new System.Windows.Forms.CheckBox();
            this.CbEggs = new System.Windows.Forms.CheckBox();
            this.GrpLunchOptions = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLoopThroughCheckboxes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BtnYourReceipt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GrpLunchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClickMe
            // 
            this.BtnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClickMe.Location = new System.Drawing.Point(293, 70);
            this.BtnClickMe.Name = "BtnClickMe";
            this.BtnClickMe.Size = new System.Drawing.Size(139, 47);
            this.BtnClickMe.TabIndex = 0;
            this.BtnClickMe.Text = "Click Me";
            this.BtnClickMe.UseVisualStyleBackColor = true;
            this.BtnClickMe.Click += new System.EventHandler(this.BtnClickMe_Click);
            // 
            // TxtUserInput
            // 
            this.TxtUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserInput.Location = new System.Drawing.Point(52, 83);
            this.TxtUserInput.Name = "TxtUserInput";
            this.TxtUserInput.Size = new System.Drawing.Size(218, 30);
            this.TxtUserInput.TabIndex = 1;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(461, 85);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(64, 25);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type into the Textbox below and click the button";
            // 
            // RbRed
            // 
            this.RbRed.AutoSize = true;
            this.RbRed.Location = new System.Drawing.Point(26, 38);
            this.RbRed.Name = "RbRed";
            this.RbRed.Size = new System.Drawing.Size(68, 29);
            this.RbRed.TabIndex = 4;
            this.RbRed.Text = "Red";
            this.RbRed.UseVisualStyleBackColor = true;
            this.RbRed.Click += new System.EventHandler(this.RbRed_Click);
            // 
            // RbGreen
            // 
            this.RbGreen.AutoSize = true;
            this.RbGreen.Location = new System.Drawing.Point(26, 80);
            this.RbGreen.Name = "RbGreen";
            this.RbGreen.Size = new System.Drawing.Size(87, 29);
            this.RbGreen.TabIndex = 5;
            this.RbGreen.Text = "Green";
            this.RbGreen.UseVisualStyleBackColor = true;
            this.RbGreen.Click += new System.EventHandler(this.RbGreen_Click);
            // 
            // RbBlue
            // 
            this.RbBlue.AutoSize = true;
            this.RbBlue.Location = new System.Drawing.Point(26, 120);
            this.RbBlue.Name = "RbBlue";
            this.RbBlue.Size = new System.Drawing.Size(72, 29);
            this.RbBlue.TabIndex = 6;
            this.RbBlue.Text = "Blue";
            this.RbBlue.UseVisualStyleBackColor = true;
            this.RbBlue.Click += new System.EventHandler(this.RbBlue_Click);
            // 
            // LblColour
            // 
            this.LblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColour.Location = new System.Drawing.Point(254, 188);
            this.LblColour.Name = "LblColour";
            this.LblColour.Size = new System.Drawing.Size(156, 174);
            this.LblColour.TabIndex = 7;
            this.LblColour.Text = "AutoSize = False";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbRed);
            this.groupBox1.Controls.Add(this.RbGreen);
            this.groupBox1.Controls.Add(this.RbBlue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a colour";
            // 
            // BtnWhichRadioButton
            // 
            this.BtnWhichRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWhichRadioButton.Location = new System.Drawing.Point(555, 178);
            this.BtnWhichRadioButton.Name = "BtnWhichRadioButton";
            this.BtnWhichRadioButton.Size = new System.Drawing.Size(248, 68);
            this.BtnWhichRadioButton.TabIndex = 9;
            this.BtnWhichRadioButton.Text = "Which Radio Button";
            this.BtnWhichRadioButton.UseVisualStyleBackColor = true;
            this.BtnWhichRadioButton.Click += new System.EventHandler(this.BtnWhichRadioButton_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(555, 259);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(328, 275);
            this.TxtResult.TabIndex = 10;
            // 
            // CbSausages
            // 
            this.CbSausages.AutoSize = true;
            this.CbSausages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSausages.Location = new System.Drawing.Point(20, 43);
            this.CbSausages.Name = "CbSausages";
            this.CbSausages.Size = new System.Drawing.Size(123, 29);
            this.CbSausages.TabIndex = 11;
            this.CbSausages.Text = "Sausages";
            this.CbSausages.UseVisualStyleBackColor = true;
            this.CbSausages.CheckedChanged += new System.EventHandler(this.ACheckBoxWasChanged);
            // 
            // CbStreakyBacon
            // 
            this.CbStreakyBacon.AutoSize = true;
            this.CbStreakyBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStreakyBacon.Location = new System.Drawing.Point(20, 89);
            this.CbStreakyBacon.Name = "CbStreakyBacon";
            this.CbStreakyBacon.Size = new System.Drawing.Size(162, 29);
            this.CbStreakyBacon.TabIndex = 12;
            this.CbStreakyBacon.Text = "Streaky Bacon";
            this.CbStreakyBacon.UseVisualStyleBackColor = true;
            this.CbStreakyBacon.CheckedChanged += new System.EventHandler(this.ACheckBoxWasChanged);
            // 
            // CbEggs
            // 
            this.CbEggs.AutoSize = true;
            this.CbEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEggs.Location = new System.Drawing.Point(20, 133);
            this.CbEggs.Name = "CbEggs";
            this.CbEggs.Size = new System.Drawing.Size(79, 29);
            this.CbEggs.TabIndex = 13;
            this.CbEggs.Text = "Eggs";
            this.CbEggs.UseVisualStyleBackColor = true;
            this.CbEggs.CheckedChanged += new System.EventHandler(this.ACheckBoxWasChanged);
            // 
            // GrpLunchOptions
            // 
            this.GrpLunchOptions.Controls.Add(this.CbSausages);
            this.GrpLunchOptions.Controls.Add(this.CbEggs);
            this.GrpLunchOptions.Controls.Add(this.CbStreakyBacon);
            this.GrpLunchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLunchOptions.Location = new System.Drawing.Point(52, 406);
            this.GrpLunchOptions.Name = "GrpLunchOptions";
            this.GrpLunchOptions.Size = new System.Drawing.Size(200, 191);
            this.GrpLunchOptions.TabIndex = 14;
            this.GrpLunchOptions.TabStop = false;
            this.GrpLunchOptions.Text = "Lunch Options";
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(555, 549);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(139, 47);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset Form";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(700, 549);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(139, 47);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLoopThroughCheckboxes
            // 
            this.BtnLoopThroughCheckboxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoopThroughCheckboxes.Location = new System.Drawing.Point(52, 635);
            this.BtnLoopThroughCheckboxes.Name = "BtnLoopThroughCheckboxes";
            this.BtnLoopThroughCheckboxes.Size = new System.Drawing.Size(278, 47);
            this.BtnLoopThroughCheckboxes.TabIndex = 18;
            this.BtnLoopThroughCheckboxes.Text = "Loop through checkboxes";
            this.BtnLoopThroughCheckboxes.UseVisualStyleBackColor = true;
            this.BtnLoopThroughCheckboxes.Click += new System.EventHandler(this.BtnLoopThroughCheckboxes_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(295, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 197);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(348, 635);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(62, 25);
            this.LblPrice.TabIndex = 20;
            this.LblPrice.Text = "Price:";
            // 
            // BtnYourReceipt
            // 
            this.BtnYourReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYourReceipt.Location = new System.Drawing.Point(555, 624);
            this.BtnYourReceipt.Name = "BtnYourReceipt";
            this.BtnYourReceipt.Size = new System.Drawing.Size(183, 47);
            this.BtnYourReceipt.TabIndex = 21;
            this.BtnYourReceipt.Text = "Your Receipt";
            this.BtnYourReceipt.UseVisualStyleBackColor = true;
            this.BtnYourReceipt.Click += new System.EventHandler(this.BtnYourReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 717);
            this.Controls.Add(this.BtnYourReceipt);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLoopThroughCheckboxes);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.GrpLunchOptions);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnWhichRadioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblColour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtUserInput);
            this.Controls.Add(this.BtnClickMe);
            this.Name = "Form1";
            this.Text = "Examples of RadioButtons, Checkboxes and Labels";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpLunchOptions.ResumeLayout(false);
            this.GrpLunchOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClickMe;
        private System.Windows.Forms.TextBox TxtUserInput;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbRed;
        private System.Windows.Forms.RadioButton RbGreen;
        private System.Windows.Forms.RadioButton RbBlue;
        private System.Windows.Forms.Label LblColour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnWhichRadioButton;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox CbSausages;
        private System.Windows.Forms.CheckBox CbStreakyBacon;
        private System.Windows.Forms.CheckBox CbEggs;
        private System.Windows.Forms.GroupBox GrpLunchOptions;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLoopThroughCheckboxes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button BtnYourReceipt;
    }
}


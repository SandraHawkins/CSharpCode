namespace SandraTesting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCreateControls = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(143, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 320);
            this.panel1.TabIndex = 0;
            // 
            // BtnCreateControls
            // 
            this.BtnCreateControls.Location = new System.Drawing.Point(288, 93);
            this.BtnCreateControls.Name = "BtnCreateControls";
            this.BtnCreateControls.Size = new System.Drawing.Size(145, 72);
            this.BtnCreateControls.TabIndex = 1;
            this.BtnCreateControls.Text = "Create Controls";
            this.BtnCreateControls.UseVisualStyleBackColor = true;
            this.BtnCreateControls.Click += new System.EventHandler(this.BtnCreateControls_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCreateControls);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCreateControls;
        private System.Windows.Forms.Button button1;
    }
}


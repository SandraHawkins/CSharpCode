using System.Windows.Forms;

namespace TheatreBooking
{
    partial class NewBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtShowName = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSaveSeatingPlanToFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Show Name";
            // 
            // TxtShowName
            // 
            this.TxtShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtShowName.Location = new System.Drawing.Point(240, 45);
            this.TxtShowName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtShowName.Name = "TxtShowName";
            this.TxtShowName.Size = new System.Drawing.Size(400, 30);
            this.TxtShowName.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(240, 119);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Show";
            // 
            // BtnSaveSeatingPlanToFile
            // 
            this.BtnSaveSeatingPlanToFile.Location = new System.Drawing.Point(543, 234);
            this.BtnSaveSeatingPlanToFile.Name = "BtnSaveSeatingPlanToFile";
            this.BtnSaveSeatingPlanToFile.Size = new System.Drawing.Size(230, 92);
            this.BtnSaveSeatingPlanToFile.TabIndex = 4;
            this.BtnSaveSeatingPlanToFile.Text = "Save Empty Seating Plan to File";
            this.BtnSaveSeatingPlanToFile.UseVisualStyleBackColor = true;
            this.BtnSaveSeatingPlanToFile.Click += new System.EventHandler(this.BtnSaveSeatingPlanToFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\Multimedia\\source\\repos\\TheatreBooking";
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 376);
            this.Controls.Add(this.BtnSaveSeatingPlanToFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TxtShowName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewBooking";
            this.Text = "New Theatre Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtShowName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSaveSeatingPlanToFile;
        private SaveFileDialog saveFileDialog1;
    }
}
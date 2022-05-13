namespace ListBoxComboBoxMenu
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
            this.BtnShowMyDialog = new System.Windows.Forms.Button();
            this.LstDaysOfWeek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGetSelectedItems = new System.Windows.Forms.Button();
            this.TxtOutputFromListbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbItems = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShowMyDialog
            // 
            this.BtnShowMyDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowMyDialog.Location = new System.Drawing.Point(504, 93);
            this.BtnShowMyDialog.Name = "BtnShowMyDialog";
            this.BtnShowMyDialog.Size = new System.Drawing.Size(173, 78);
            this.BtnShowMyDialog.TabIndex = 0;
            this.BtnShowMyDialog.Text = "Show My Dialog";
            this.BtnShowMyDialog.UseVisualStyleBackColor = true;
            this.BtnShowMyDialog.Click += new System.EventHandler(this.BtnCenterAMessageBox_Click);
            // 
            // LstDaysOfWeek
            // 
            this.LstDaysOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDaysOfWeek.FormattingEnabled = true;
            this.LstDaysOfWeek.ItemHeight = 25;
            this.LstDaysOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.LstDaysOfWeek.Location = new System.Drawing.Point(18, 78);
            this.LstDaysOfWeek.Name = "LstDaysOfWeek";
            this.LstDaysOfWeek.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstDaysOfWeek.Size = new System.Drawing.Size(162, 129);
            this.LstDaysOfWeek.TabIndex = 1;
            this.LstDaysOfWeek.SelectedIndexChanged += new System.EventHandler(this.LstDaysOfWeek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose the days you are available from the ListBox";
            // 
            // BtnGetSelectedItems
            // 
            this.BtnGetSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetSelectedItems.Location = new System.Drawing.Point(202, 78);
            this.BtnGetSelectedItems.Name = "BtnGetSelectedItems";
            this.BtnGetSelectedItems.Size = new System.Drawing.Size(191, 109);
            this.BtnGetSelectedItems.TabIndex = 3;
            this.BtnGetSelectedItems.Text = "Get Selected Items from Listbox";
            this.BtnGetSelectedItems.UseVisualStyleBackColor = true;
            this.BtnGetSelectedItems.Click += new System.EventHandler(this.BtnGetSelectedItems_Click);
            // 
            // TxtOutputFromListbox
            // 
            this.TxtOutputFromListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutputFromListbox.Location = new System.Drawing.Point(18, 287);
            this.TxtOutputFromListbox.Multiline = true;
            this.TxtOutputFromListbox.Name = "TxtOutputFromListbox";
            this.TxtOutputFromListbox.Size = new System.Drawing.Size(238, 198);
            this.TxtOutputFromListbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output from the Listbox";
            // 
            // CmbItems
            // 
            this.CmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbItems.FormattingEnabled = true;
            this.CmbItems.Location = new System.Drawing.Point(18, 640);
            this.CmbItems.Name = "CmbItems";
            this.CmbItems.Size = new System.Drawing.Size(185, 33);
            this.CmbItems.TabIndex = 6;
            this.CmbItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbItems_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(603, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "A ComboBox is combination of a TextBox and a ListBox";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(224, 640);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 45);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(350, 640);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 45);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveAll.Location = new System.Drawing.Point(476, 640);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(169, 45);
            this.BtnRemoveAll.TabIndex = 10;
            this.BtnRemoveAll.Text = "Remove All";
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(341, 30);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(350, 325);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Time Picker:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Month Calendar:";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateTime.Location = new System.Drawing.Point(353, 541);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(229, 29);
            this.LblDateTime.TabIndex = 15;
            this.LblDateTime.Text = "DateTime selected: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileOpen,
            this.toolStripMenuItem1,
            this.MnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // MnuFileOpen
            // 
            this.MnuFileOpen.Name = "MnuFileOpen";
            this.MnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MnuFileOpen.Size = new System.Drawing.Size(190, 26);
            this.MnuFileOpen.Text = "&Open...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // MnuFileExit
            // 
            this.MnuFileExit.Name = "MnuFileExit";
            this.MnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuFileExit.Size = new System.Drawing.Size(190, 26);
            this.MnuFileExit.Text = "E&xit";
            this.MnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 728);
            this.Controls.Add(this.LblDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOutputFromListbox);
            this.Controls.Add(this.BtnGetSelectedItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstDaysOfWeek);
            this.Controls.Add(this.BtnShowMyDialog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ListBox, ComboBox, Menu and Date Controls";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowMyDialog;
        private System.Windows.Forms.ListBox LstDaysOfWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGetSelectedItems;
        private System.Windows.Forms.TextBox TxtOutputFromListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}


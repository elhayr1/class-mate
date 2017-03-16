﻿namespace ClassMate
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
            this.tabs_window = new System.Windows.Forms.TabControl();
            this.srch_tab = new System.Windows.Forms.TabPage();
            this.filter_grbx = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.time_to_cmbx = new System.Windows.Forms.ComboBox();
            this.time_from_cmbx = new System.Windows.Forms.ComboBox();
            this.day_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.results_table = new System.Windows.Forms.DataGridView();
            this.advanced_srch_tb = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.advanced_srch_rbtn = new System.Windows.Forms.RadioButton();
            this.fast_srch_rbtn = new System.Windows.Forms.RadioButton();
            this.class_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs_window.SuspendLayout();
            this.srch_tab.SuspendLayout();
            this.filter_grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_window
            // 
            this.tabs_window.Controls.Add(this.srch_tab);
            this.tabs_window.Controls.Add(this.advanced_srch_tb);
            this.tabs_window.Location = new System.Drawing.Point(3, 3);
            this.tabs_window.Name = "tabs_window";
            this.tabs_window.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabs_window.SelectedIndex = 0;
            this.tabs_window.Size = new System.Drawing.Size(465, 416);
            this.tabs_window.TabIndex = 0;
            // 
            // srch_tab
            // 
            this.srch_tab.Controls.Add(this.fast_srch_rbtn);
            this.srch_tab.Controls.Add(this.advanced_srch_rbtn);
            this.srch_tab.Controls.Add(this.filter_grbx);
            this.srch_tab.Controls.Add(this.search_btn);
            this.srch_tab.Controls.Add(this.results_table);
            this.srch_tab.Location = new System.Drawing.Point(4, 22);
            this.srch_tab.Name = "srch_tab";
            this.srch_tab.Padding = new System.Windows.Forms.Padding(3);
            this.srch_tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.srch_tab.Size = new System.Drawing.Size(457, 390);
            this.srch_tab.TabIndex = 0;
            this.srch_tab.Text = "חיפוש כללי";
            this.srch_tab.UseVisualStyleBackColor = true;
            // 
            // filter_grbx
            // 
            this.filter_grbx.Controls.Add(this.label3);
            this.filter_grbx.Controls.Add(this.time_to_cmbx);
            this.filter_grbx.Controls.Add(this.time_from_cmbx);
            this.filter_grbx.Controls.Add(this.day_cmbx);
            this.filter_grbx.Controls.Add(this.label2);
            this.filter_grbx.Controls.Add(this.label1);
            this.filter_grbx.Enabled = false;
            this.filter_grbx.Location = new System.Drawing.Point(22, 35);
            this.filter_grbx.Name = "filter_grbx";
            this.filter_grbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filter_grbx.Size = new System.Drawing.Size(410, 73);
            this.filter_grbx.TabIndex = 3;
            this.filter_grbx.TabStop = false;
            this.filter_grbx.Text = "סנן";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 16);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "עד שעה:";
            // 
            // time_to_cmbx
            // 
            this.time_to_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_to_cmbx.Location = new System.Drawing.Point(67, 40);
            this.time_to_cmbx.Name = "time_to_cmbx";
            this.time_to_cmbx.Size = new System.Drawing.Size(88, 21);
            this.time_to_cmbx.TabIndex = 4;
            // 
            // time_from_cmbx
            // 
            this.time_from_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_from_cmbx.Location = new System.Drawing.Point(203, 40);
            this.time_from_cmbx.Name = "time_from_cmbx";
            this.time_from_cmbx.Size = new System.Drawing.Size(101, 21);
            this.time_from_cmbx.TabIndex = 3;
            this.time_from_cmbx.SelectedIndexChanged += new System.EventHandler(this.time_from_cmbx_SelectedIndexChanged);
            // 
            // day_cmbx
            // 
            this.day_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_cmbx.Location = new System.Drawing.Point(313, 40);
            this.day_cmbx.Name = "day_cmbx";
            this.day_cmbx.Size = new System.Drawing.Size(85, 21);
            this.day_cmbx.TabIndex = 2;
            this.day_cmbx.SelectedIndexChanged += new System.EventHandler(this.day_cmbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "משעה:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "יום:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(22, 361);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "חפש";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // results_table
            // 
            this.results_table.AllowUserToAddRows = false;
            this.results_table.AllowUserToDeleteRows = false;
            this.results_table.AllowUserToResizeRows = false;
            this.results_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id_col,
            this.building_col,
            this.floor_col,
            this.avail_time_col,
            this.total_avail_time_col});
            this.results_table.Location = new System.Drawing.Point(22, 145);
            this.results_table.Name = "results_table";
            this.results_table.ReadOnly = true;
            this.results_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.results_table.Size = new System.Drawing.Size(410, 193);
            this.results_table.TabIndex = 1;
            this.results_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // advanced_srch_tb
            // 
            this.advanced_srch_tb.Location = new System.Drawing.Point(4, 22);
            this.advanced_srch_tb.Name = "advanced_srch_tb";
            this.advanced_srch_tb.Padding = new System.Windows.Forms.Padding(3);
            this.advanced_srch_tb.Size = new System.Drawing.Size(457, 390);
            this.advanced_srch_tb.TabIndex = 1;
            this.advanced_srch_tb.Text = "חיפוש לפי כיתה";
            this.advanced_srch_tb.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelFileToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // excelFileToolStripMenuItem
            // 
            this.excelFileToolStripMenuItem.Name = "excelFileToolStripMenuItem";
            this.excelFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.excelFileToolStripMenuItem.Text = "Excel File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "אודות";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabs_window);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 421);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // advanced_srch_rbtn
            // 
            this.advanced_srch_rbtn.AutoSize = true;
            this.advanced_srch_rbtn.Location = new System.Drawing.Point(230, 12);
            this.advanced_srch_rbtn.Name = "advanced_srch_rbtn";
            this.advanced_srch_rbtn.Size = new System.Drawing.Size(96, 17);
            this.advanced_srch_rbtn.TabIndex = 4;
            this.advanced_srch_rbtn.Text = "חיפוש מתקדם";
            this.advanced_srch_rbtn.UseVisualStyleBackColor = true;
            this.advanced_srch_rbtn.CheckedChanged += new System.EventHandler(this.advanced_srch_rbtn_CheckedChanged);
            // 
            // fast_srch_rbtn
            // 
            this.fast_srch_rbtn.AutoSize = true;
            this.fast_srch_rbtn.Checked = true;
            this.fast_srch_rbtn.Location = new System.Drawing.Point(346, 12);
            this.fast_srch_rbtn.Name = "fast_srch_rbtn";
            this.fast_srch_rbtn.Size = new System.Drawing.Size(86, 17);
            this.fast_srch_rbtn.TabIndex = 5;
            this.fast_srch_rbtn.TabStop = true;
            this.fast_srch_rbtn.Text = "חיפוש מהיר";
            this.fast_srch_rbtn.UseVisualStyleBackColor = true;
            this.fast_srch_rbtn.CheckedChanged += new System.EventHandler(this.fast_srch_rbtn_CheckedChanged);
            // 
            // class_id_col
            // 
            this.class_id_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.class_id_col.HeaderText = "כיתה";
            this.class_id_col.MinimumWidth = 50;
            this.class_id_col.Name = "class_id_col";
            this.class_id_col.Width = 58;
            // 
            // building_col
            // 
            this.building_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.building_col.HeaderText = "בניין";
            this.building_col.Name = "building_col";
            this.building_col.Width = 59;
            // 
            // floor_col
            // 
            this.floor_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.floor_col.HeaderText = "קומה";
            this.floor_col.Name = "floor_col";
            this.floor_col.Width = 58;
            // 
            // avail_time_col
            // 
            this.avail_time_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.avail_time_col.HeaderText = "זמינות";
            this.avail_time_col.MinimumWidth = 80;
            this.avail_time_col.Name = "avail_time_col";
            this.avail_time_col.Width = 80;
            // 
            // total_avail_time_col
            // 
            this.total_avail_time_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.total_avail_time_col.HeaderText = "סה\"כ זמן";
            this.total_avail_time_col.Name = "total_avail_time_col";
            this.total_avail_time_col.Width = 78;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 456);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs_window.ResumeLayout(false);
            this.srch_tab.ResumeLayout(false);
            this.srch_tab.PerformLayout();
            this.filter_grbx.ResumeLayout(false);
            this.filter_grbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_window;
        private System.Windows.Forms.TabPage srch_tab;
        private System.Windows.Forms.TabPage advanced_srch_tb;
        private System.Windows.Forms.DataGridView results_table;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox filter_grbx;
        private System.Windows.Forms.ComboBox time_from_cmbx;
        private System.Windows.Forms.ComboBox day_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox time_to_cmbx;
        private System.Windows.Forms.RadioButton fast_srch_rbtn;
        private System.Windows.Forms.RadioButton advanced_srch_rbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn building_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn avail_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_avail_time_col;


    }
}


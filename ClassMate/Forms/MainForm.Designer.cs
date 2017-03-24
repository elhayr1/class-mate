namespace ClassMate
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
            this.filter_grbx = new System.Windows.Forms.GroupBox();
            this.time_cmbx = new System.Windows.Forms.ComboBox();
            this.day_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.results_table = new System.Windows.Forms.DataGridView();
            this.class_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.export_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.preferences_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filter_grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filter_grbx
            // 
            this.filter_grbx.Controls.Add(this.time_cmbx);
            this.filter_grbx.Controls.Add(this.day_cmbx);
            this.filter_grbx.Controls.Add(this.label2);
            this.filter_grbx.Controls.Add(this.label1);
            this.filter_grbx.Location = new System.Drawing.Point(3, 3);
            this.filter_grbx.Name = "filter_grbx";
            this.filter_grbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filter_grbx.Size = new System.Drawing.Size(403, 73);
            this.filter_grbx.TabIndex = 3;
            this.filter_grbx.TabStop = false;
            this.filter_grbx.Text = "סנן";
            // 
            // time_from_cmbx
            // 
            this.time_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_cmbx.Location = new System.Drawing.Point(152, 40);
            this.time_cmbx.Name = "time_from_cmbx";
            this.time_cmbx.Size = new System.Drawing.Size(101, 21);
            this.time_cmbx.TabIndex = 3;
            this.time_cmbx.SelectedIndexChanged += new System.EventHandler(this.time_from_cmbx_SelectedIndexChanged);
            // 
            // day_cmbx
            // 
            this.day_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_cmbx.Location = new System.Drawing.Point(309, 40);
            this.day_cmbx.Name = "day_cmbx";
            this.day_cmbx.Size = new System.Drawing.Size(85, 21);
            this.day_cmbx.TabIndex = 2;
            this.day_cmbx.SelectedIndexChanged += new System.EventHandler(this.day_cmbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "משעה:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "יום:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(3, 290);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(90, 30);
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
            this.results_table.Location = new System.Drawing.Point(3, 92);
            this.results_table.Name = "results_table";
            this.results_table.ReadOnly = true;
            this.results_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.results_table.Size = new System.Drawing.Size(403, 185);
            this.results_table.TabIndex = 1;
            this.results_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // class_id_col
            // 
            this.class_id_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.class_id_col.HeaderText = "כיתה";
            this.class_id_col.MinimumWidth = 50;
            this.class_id_col.Name = "class_id_col";
            this.class_id_col.ReadOnly = true;
            this.class_id_col.Width = 58;
            // 
            // building_col
            // 
            this.building_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.building_col.HeaderText = "בניין";
            this.building_col.Name = "building_col";
            this.building_col.ReadOnly = true;
            this.building_col.Width = 59;
            // 
            // floor_col
            // 
            this.floor_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.floor_col.HeaderText = "קומה";
            this.floor_col.Name = "floor_col";
            this.floor_col.ReadOnly = true;
            this.floor_col.Width = 58;
            // 
            // avail_time_col
            // 
            this.avail_time_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.avail_time_col.HeaderText = "זמינות";
            this.avail_time_col.MinimumWidth = 80;
            this.avail_time_col.Name = "avail_time_col";
            this.avail_time_col.ReadOnly = true;
            this.avail_time_col.Width = 80;
            // 
            // total_avail_time_col
            // 
            this.total_avail_time_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.total_avail_time_col.HeaderText = "סה\"כ זמן";
            this.total_avail_time_col.Name = "total_avail_time_col";
            this.total_avail_time_col.ReadOnly = true;
            this.total_avail_time_col.Width = 78;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.about_btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export_btn,
            this.print_btn,
            this.preferences_btn,
            this.settings_btn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "קובץ";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // export_btn
            // 
            this.export_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelFileToolStripMenuItem});
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(115, 22);
            this.export_btn.Text = "יצא...";
            // 
            // excelFileToolStripMenuItem
            // 
            this.excelFileToolStripMenuItem.Name = "excelFileToolStripMenuItem";
            this.excelFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.excelFileToolStripMenuItem.Text = "Excel File";
            // 
            // print_btn
            // 
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(115, 22);
            this.print_btn.Text = "הדפס";
            // 
            // preferences_btn
            // 
            this.preferences_btn.Name = "preferences_btn";
            this.preferences_btn.Size = new System.Drawing.Size(115, 22);
            this.preferences_btn.Text = "העדפות";
            // 
            // settings_btn
            // 
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(115, 22);
            this.settings_btn.Text = "הגדרות";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(48, 20);
            this.about_btn.Text = "אודות";
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.filter_grbx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.results_table, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.0219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.9781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 323);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(433, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 405);
            this.MinimumSize = new System.Drawing.Size(449, 405);
            this.Name = "Form1";
            this.Text = "ClassMate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.filter_grbx.ResumeLayout(false);
            this.filter_grbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView results_table;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem export_btn;
        private System.Windows.Forms.ToolStripMenuItem excelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print_btn;
        private System.Windows.Forms.ToolStripMenuItem preferences_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.GroupBox filter_grbx;
        private System.Windows.Forms.ComboBox time_cmbx;
        private System.Windows.Forms.ComboBox day_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn building_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn avail_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_avail_time_col;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem settings_btn;


    }
}


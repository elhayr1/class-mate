namespace ClassMate
{
    partial class MainForm
    {
        //BlueSky Software, Elchay Rauper
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
            this.filterGrbx = new System.Windows.Forms.GroupBox();
            this.timeCmbx = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dayCmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.class_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_avail_time_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchPbar = new System.Windows.Forms.ProgressBar();
            this.filterGrbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterGrbx
            // 
            this.filterGrbx.Controls.Add(this.searchPbar);
            this.filterGrbx.Controls.Add(this.timeCmbx);
            this.filterGrbx.Controls.Add(this.searchBtn);
            this.filterGrbx.Controls.Add(this.dayCmbx);
            this.filterGrbx.Controls.Add(this.label2);
            this.filterGrbx.Controls.Add(this.label1);
            this.filterGrbx.Location = new System.Drawing.Point(3, 3);
            this.filterGrbx.Name = "filterGrbx";
            this.filterGrbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filterGrbx.Size = new System.Drawing.Size(403, 73);
            this.filterGrbx.TabIndex = 3;
            this.filterGrbx.TabStop = false;
            this.filterGrbx.Text = "סנן";
            // 
            // timeCmbx
            // 
            this.timeCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCmbx.Location = new System.Drawing.Point(152, 40);
            this.timeCmbx.Name = "timeCmbx";
            this.timeCmbx.Size = new System.Drawing.Size(101, 21);
            this.timeCmbx.TabIndex = 3;
            this.timeCmbx.SelectedIndexChanged += new System.EventHandler(this.time_from_cmbx_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(90, 21);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "חפש";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dayCmbx
            // 
            this.dayCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCmbx.Location = new System.Drawing.Point(309, 40);
            this.dayCmbx.Name = "dayCmbx";
            this.dayCmbx.Size = new System.Drawing.Size(85, 21);
            this.dayCmbx.TabIndex = 2;
            this.dayCmbx.SelectedIndexChanged += new System.EventHandler(this.day_cmbx_SelectedIndexChanged);
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
            // resultTable
            // 
            this.resultTable.AllowUserToAddRows = false;
            this.resultTable.AllowUserToDeleteRows = false;
            this.resultTable.AllowUserToResizeRows = false;
            this.resultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id_col,
            this.building_col,
            this.floor_col,
            this.avail_time_col,
            this.total_avail_time_col});
            this.resultTable.Location = new System.Drawing.Point(3, 85);
            this.resultTable.Name = "resultTable";
            this.resultTable.ReadOnly = true;
            this.resultTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultTable.Size = new System.Drawing.Size(403, 227);
            this.resultTable.TabIndex = 1;
            this.resultTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "הגדרות";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.filterGrbx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultTable, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.26582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.73418F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 316);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // searchPbar
            // 
            this.searchPbar.Location = new System.Drawing.Point(13, 14);
            this.searchPbar.Name = "searchPbar";
            this.searchPbar.Size = new System.Drawing.Size(90, 19);
            this.searchPbar.TabIndex = 4;
            this.searchPbar.Visible = false;
            this.searchPbar.Click += new System.EventHandler(this.searchPbar_Click);
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.Text = "ClassMate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.filterGrbx.ResumeLayout(false);
            this.filterGrbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox filterGrbx;
        private System.Windows.Forms.ComboBox timeCmbx;
        private System.Windows.Forms.ComboBox dayCmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn building_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn avail_time_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_avail_time_col;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ProgressBar searchPbar;


    }
}


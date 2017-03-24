namespace ClassMate.Forms
{
    partial class SettingsForm
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
            this.settings_tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.links_grbx = new System.Windows.Forms.GroupBox();
            this.monday_url_txtbx = new System.Windows.Forms.TextBox();
            this.friday_url_txtbx = new System.Windows.Forms.TextBox();
            this.thursday_url_txtbx = new System.Windows.Forms.TextBox();
            this.wednesday_url_txtbx = new System.Windows.Forms.TextBox();
            this.tuesday_url_txtbx = new System.Windows.Forms.TextBox();
            this.sunday_url_txtbx = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.apply_btn = new System.Windows.Forms.Button();
            this.settings_tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.links_grbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_tabs
            // 
            this.settings_tabs.Controls.Add(this.tabPage1);
            this.settings_tabs.Controls.Add(this.tabPage2);
            this.settings_tabs.Location = new System.Drawing.Point(12, 12);
            this.settings_tabs.Name = "settings_tabs";
            this.settings_tabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settings_tabs.RightToLeftLayout = true;
            this.settings_tabs.SelectedIndex = 0;
            this.settings_tabs.Size = new System.Drawing.Size(376, 300);
            this.settings_tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.links_grbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(16, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(335, 40);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "לקבלת תוצאות חיפוש עדכניות יש לעדכן קישורים אלו כל סמסטר מחדש. ע\"מ לקבל הקישורים " +
    "ניתן לחפש \"שיבוץ כיתות ספיר\" בגוגל";
            // 
            // links_grbx
            // 
            this.links_grbx.Controls.Add(this.monday_url_txtbx);
            this.links_grbx.Controls.Add(this.friday_url_txtbx);
            this.links_grbx.Controls.Add(this.thursday_url_txtbx);
            this.links_grbx.Controls.Add(this.wednesday_url_txtbx);
            this.links_grbx.Controls.Add(this.tuesday_url_txtbx);
            this.links_grbx.Controls.Add(this.sunday_url_txtbx);
            this.links_grbx.Controls.Add(this.lable1);
            this.links_grbx.Controls.Add(this.label2);
            this.links_grbx.Controls.Add(this.label5);
            this.links_grbx.Controls.Add(this.label6);
            this.links_grbx.Controls.Add(this.label3);
            this.links_grbx.Controls.Add(this.label4);
            this.links_grbx.Location = new System.Drawing.Point(16, 67);
            this.links_grbx.Name = "links_grbx";
            this.links_grbx.Size = new System.Drawing.Size(335, 201);
            this.links_grbx.TabIndex = 6;
            this.links_grbx.TabStop = false;
            this.links_grbx.Text = "קישורים";
            // 
            // monday_url_txtbx
            // 
            this.monday_url_txtbx.Location = new System.Drawing.Point(6, 50);
            this.monday_url_txtbx.Name = "monday_url_txtbx";
            this.monday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.monday_url_txtbx.TabIndex = 11;
            // 
            // friday_url_txtbx
            // 
            this.friday_url_txtbx.Location = new System.Drawing.Point(6, 153);
            this.friday_url_txtbx.Name = "friday_url_txtbx";
            this.friday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.friday_url_txtbx.TabIndex = 10;
            // 
            // thursday_url_txtbx
            // 
            this.thursday_url_txtbx.Location = new System.Drawing.Point(6, 127);
            this.thursday_url_txtbx.Name = "thursday_url_txtbx";
            this.thursday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.thursday_url_txtbx.TabIndex = 9;
            // 
            // wednesday_url_txtbx
            // 
            this.wednesday_url_txtbx.Location = new System.Drawing.Point(6, 101);
            this.wednesday_url_txtbx.Name = "wednesday_url_txtbx";
            this.wednesday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.wednesday_url_txtbx.TabIndex = 8;
            // 
            // tuesday_url_txtbx
            // 
            this.tuesday_url_txtbx.Location = new System.Drawing.Point(6, 75);
            this.tuesday_url_txtbx.Name = "tuesday_url_txtbx";
            this.tuesday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.tuesday_url_txtbx.TabIndex = 7;
            // 
            // sunday_url_txtbx
            // 
            this.sunday_url_txtbx.Location = new System.Drawing.Point(6, 22);
            this.sunday_url_txtbx.Name = "sunday_url_txtbx";
            this.sunday_url_txtbx.Size = new System.Drawing.Size(269, 20);
            this.sunday_url_txtbx.TabIndex = 6;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(282, 25);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(40, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "ראשון";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "שישי";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "חמישי";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "רביעי";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "שני";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "שלישי";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(16, 318);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 1;
            this.apply_btn.Text = "החל";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 353);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.settings_tabs);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settings_tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.links_grbx.ResumeLayout(false);
            this.links_grbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settings_tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox links_grbx;
        private System.Windows.Forms.TextBox monday_url_txtbx;
        private System.Windows.Forms.TextBox friday_url_txtbx;
        private System.Windows.Forms.TextBox thursday_url_txtbx;
        private System.Windows.Forms.TextBox wednesday_url_txtbx;
        private System.Windows.Forms.TextBox tuesday_url_txtbx;
        private System.Windows.Forms.TextBox sunday_url_txtbx;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
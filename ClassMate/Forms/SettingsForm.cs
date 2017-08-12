using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMate.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            sunday_url_txtbx.Text = Properties.Settings.Default.sunday_url;
            monday_url_txtbx.Text = Properties.Settings.Default.monday_url;
            tuesday_url_txtbx.Text = Properties.Settings.Default.tuesday_url;
            wednesday_url_txtbx.Text = Properties.Settings.Default.wednesday_url;
            thursday_url_txtbx.Text = Properties.Settings.Default.thursday_url;
            friday_url_txtbx.Text = Properties.Settings.Default.friday_url;
        }

        private void UpdateURLs()
        {
            Properties.Settings.Default.sunday_url = sunday_url_txtbx.Text;
            Properties.Settings.Default.monday_url = monday_url_txtbx.Text;
            Properties.Settings.Default.tuesday_url = tuesday_url_txtbx.Text;
            Properties.Settings.Default.wednesday_url = wednesday_url_txtbx.Text;
            Properties.Settings.Default.thursday_url = thursday_url_txtbx.Text;
            Properties.Settings.Default.friday_url = friday_url_txtbx.Text;

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            UpdateURLs();
        }
    }
}

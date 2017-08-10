using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMate.Parsers;
using ClassMate.Forms;
using System.Runtime.InteropServices;


namespace ClassMate
{
    public partial class Form1 : Form
    {
        SettingsForm settings_form_;
        AboutForm about_form_;
        bool lock_triggers_;
        
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            results_table.AutoGenerateColumns = false;
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings_form_ == null || settings_form_.IsDisposed)
                settings_form_ = new SettingsForm();
            settings_form_.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initFilterLists();
        }

        private void initFilterLists()
        {
            lock_triggers_ = true;
            fillDaysList();
            fillFromTimeList();
 
            lock_triggers_ = false;
        }

        private void fillDaysList()
        {
            bool college_day = false;
            int today = (int)DateTime.Now.DayOfWeek;
            for (int i=0; i<=5; i++)
            {
                if (today != i)
                    day_cmbx.Items.Add(SapirParser.intDayToString(i));
                else
                {
                    day_cmbx.Items.Add("היום");
                    college_day = true;
                }
            }
               
            if (college_day)
                day_cmbx.SelectedIndex = day_cmbx.FindStringExact("היום");
            else
                day_cmbx.SelectedIndex = day_cmbx.FindStringExact("ראשון");
        }

        private void fillFromTimeList()
        {
            time_cmbx.Items.Clear();
            Hour now_hour = now_hour = new Hour(7, 0);
            if (day_cmbx.SelectedItem.ToString() == "היום" && Hour.now() >= new Hour(7, 0))
            {
                now_hour = Hour.now() >= new Hour(7, 0) ? Hour.now() : new Hour(7, 0);
                time_cmbx.Items.Add(now_hour + " (עכשיו)");
            }
                

            for (int hour = now_hour.getHours(); hour <= 23; hour++)
            {
                time_cmbx.Items.Add(hour + ":00");
                time_cmbx.Items.Add(hour + ":30");
            }
            time_cmbx.SelectedIndex = 0;
        }

        private void time_from_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lock_triggers_)
            {
                lock_triggers_ = true;
                lock_triggers_ = false;
            }
        }
        
        private void day_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lock_triggers_)
            {
               lock_triggers_ = true;
               fillFromTimeList();
               time_cmbx.SelectedIndex = 0;
               lock_triggers_ = false;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_btn.Enabled = false;
            results_table.Rows.Clear();
            SapirParser parser = new SapirParser();
            parser.LoadDataFromHTML(SapirParser.getDayURL(day_cmbx.SelectedItem.ToString()));
            var classes_hours = parser.getClassesHours();

            string time_selection = time_cmbx.SelectedItem.ToString();
            Hour from_time_hour = new Hour(time_selection.Replace("(עכשיו)", ""));
            foreach (KeyValuePair<string, ClassRoom> class_entry in classes_hours)
            {
                Console.Write("Class {0}: ", class_entry.Value.getID().ToString());
                class_entry.Value.getHoursList().printList();

                var free_time = class_entry.Value.getHoursList().getFreeTime(from_time_hour);

                if (free_time != null)
                {
                    Console.WriteLine("{0}  Total time: {1}", free_time.from_to.ToString(), free_time.total_time.ToString());
                    if (free_time.total_time > new Hour(0,0))
                        results_table.Rows.Add(class_entry.Value.getID(),
                                                class_entry.Value.getBuilding(),
                                                class_entry.Value.getFloor(),
                                                free_time.from_to.ToHebString(),
                                                free_time.total_time);
                }
            }
            search_btn.Enabled = true;
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void advanced_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fast_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            filter_grbx.Enabled = false;
            time_cmbx.Items.Clear();
            day_cmbx.Items.Clear();
            initFilterLists();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            if (about_form_ == null || about_form_.IsDisposed)
                about_form_ = new AboutForm();
            about_form_.Show();

        }
    }
}
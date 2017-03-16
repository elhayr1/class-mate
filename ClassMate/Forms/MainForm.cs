using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMate.Src;

namespace ClassMate
{
    public partial class Form1 : Form
    {
        bool first_cmbx_load_;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initFilterLists();
        }

        private void initFilterLists()
        {
            first_cmbx_load_ = true;
            fillDaysList();
            fillTimeLists();
            first_cmbx_load_ = false;
        }

        private void fillDaysList()
        {
            bool college_day = false;
            int today = (int)DateTime.Now.DayOfWeek;
            for (int i=0; i<=5; i++)
            {
                if (today != i)
                    day_cmbx.Items.Add(DataExtractor.intDayToString(i));
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

        private void fillTimeLists()
        {
            string now = DateTime.Now.ToString("HH:mm");
            Hour now_hour = new Hour(now);
            time_from_cmbx.Items.Add(now + " (עכשיו)");
            time_to_cmbx.Items.Add("סוף היום");
            for (int hour = now_hour.getHours() + 1; hour <= 23; hour++)
            {
                for (int half_hour = 0; half_hour < 2; half_hour++)
                {
                    if (half_hour == 0)
                    {
                        time_from_cmbx.Items.Add(hour + ":00");
                        time_to_cmbx.Items.Add(hour + ":00");
                    }
                    else
                    {
                        time_from_cmbx.Items.Add(hour + ":30");
                        time_to_cmbx.Items.Add(hour + ":30");
                    }
                }
            }
            time_from_cmbx.SelectedIndex = 0;
            time_to_cmbx.SelectedIndex = 0;
        }

        private void time_from_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!first_cmbx_load_)
            {
                string from_time_selection = time_from_cmbx.SelectedItem.ToString();
                if (from_time_selection.Contains("(עכשיו)"))
                    from_time_selection = from_time_selection.Replace("(עכשיו)", "");
                Hour from_time_hour = new Hour(from_time_selection);
                time_to_cmbx.Items.Clear();
                time_to_cmbx.Items.Add("סוף היום");
                for (int hour = from_time_hour.getHours() + 1; hour <= 23; hour++)
                {
                    for (int half_hour = 0; half_hour < 2; half_hour++)
                    {
                        if (half_hour == 0)
                        {
                            time_to_cmbx.Items.Add(hour + ":00");
                        }
                        else
                        {
                            time_to_cmbx.Items.Add(hour + ":30");
                        }
                    }
                }
                time_to_cmbx.SelectedIndex = 0;
            }
        }
        
        private void day_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (day_cmbx.SelectedItem.ToString() != "היום" && !first_cmbx_load_)
            {
                time_from_cmbx.Items.Clear();
                time_to_cmbx.Items.Clear();
                for (int hour = 7; hour <= 23; hour++)
                {
                    for (int half_hour = 0; half_hour < 2; half_hour++)
                    {
                        if (half_hour == 0)
                        {
                            time_from_cmbx.Items.Add(hour + ":00");
                            if (hour > 7)
                                time_to_cmbx.Items.Add(hour + ":00");
                        }
                        else
                        {
                            time_from_cmbx.Items.Add(hour + ":30");
                            if (hour > 7)
                                time_to_cmbx.Items.Add(hour + ":30");
                        }
                    }
                }
                time_from_cmbx.SelectedIndex = 0;
                time_to_cmbx.SelectedIndex = 0;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataExtractor.Instance.loadDataFromHTML(DataURLs.SUNDAY_URL);
            Dictionary<string, ClassRoom> classes_hours_ = DataExtractor.Instance.getClassesHours();
            foreach (KeyValuePair<string, ClassRoom> class_entry in classes_hours_)
            {
                // do something with entry.Value or entry.Key
                class_entry.Value.getHoursList().printList();
                var free_time = class_entry.Value.getHoursList().getFreeTime(new Hour(12,0));
                if (free_time != null) //TODO: IMPORTANT: if free time is null, means there free time until the end of the day
                {
                    Console.WriteLine("{0}  Total time: {1}", free_time.from_to.ToString(), free_time.total_time.ToString());
                    //TODO: SEARCH USES CONST PARAMS INSTEAD OF GUI PARAMS
                    results_table.Rows.Add(class_entry.Value.getID().ToString(), 
                                           class_entry.Value.getBuilding().ToString(), 
                                           class_entry.Value.getFloor().ToString(),
                                           free_time.from_to.ToString(),
                                           free_time.total_time.ToString());
                }
            }

            /*
            ClassRoom classroom = DataExtractor.Instance.getClassRoom("9001");
            //class_hours.getHoursList().printList();
            DataGridViewRow row = (DataGridViewRow)results_table.Rows[0].Clone();
            row.Cells[0].Value = classroom.getID().ToString();
            row.Cells[1].Value = classroom.getBuilding().ToString();
            row.Cells[2].Value = classroom.getFloor().ToString();
            row.Cells[3].Value = 50.2;
            row.Cells[4].Value = "XYZ";
            results_table.Rows.Add(row);*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void advanced_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            filter_grbx.Enabled = true;
        }

        private void fast_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            filter_grbx.Enabled = false;
            time_from_cmbx.Items.Clear();
            time_to_cmbx.Items.Clear();
            day_cmbx.Items.Clear();
            initFilterLists();
        }
    }
}

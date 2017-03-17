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
            results_table.AutoGenerateColumns = false;
          
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
               /* if (from_time_selection.Contains("(עכשיו)"))
                    from_time_selection = from_time_selection.Replace("(עכשיו)", "");*/
                Hour from_time_hour = new Hour(from_time_selection.Replace("(עכשיו)", ""));//new Hour(from_time_selection);
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
        //TODO: ADD EXPORT HOURS TO FILE CAPABILITY
        private void search_btn_Click(object sender, EventArgs e)
        {
            //var classes_bind_lst = new BindingList<ClassRoom>();
            //results_table.DataSource = classes_bind_lst;
            results_table.Rows.Clear();

            DataExtractor.Instance.loadDataFromHTML(DataExtractor.getDayURL(day_cmbx.SelectedItem.ToString()));
            Dictionary<string, ClassRoom> classes_hours_ = DataExtractor.Instance.getClassesHours();

            string from_time_selection = time_from_cmbx.SelectedItem.ToString();
            Hour from_time_hour = new Hour(from_time_selection.Replace("(עכשיו)", ""));

            foreach (KeyValuePair<string, ClassRoom> class_entry in classes_hours_)
            {
                Console.Write("Class {0}: ", class_entry.Value.getID().ToString());
                class_entry.Value.getHoursList().printList();

                //TODO: build another getfreetime that need to also get end time, not just start time (if user chose hour other than "end of day")
                var free_time = class_entry.Value.getHoursList().getFreeTime(from_time_hour);

                if (free_time != null)
                {
                    Console.WriteLine("{0}  Total time: {1}", free_time.from_to.ToString(), free_time.total_time.ToString());
                    results_table.Rows.Add(class_entry.Value.getID(),
                                            class_entry.Value.getBuilding(),
                                            class_entry.Value.getFloor(),
                                            free_time.from_to,
                                            free_time.total_time);
                }
            }
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

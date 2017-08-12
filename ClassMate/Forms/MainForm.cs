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
using ClassMate.ClassTime;

namespace ClassMate
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm_;
        AboutForm aboutForm_;
        bool controlsChangesLock_;
        
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            resultTable.AutoGenerateColumns = false;
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm_ == null || settingsForm_.IsDisposed)
                settingsForm_ = new SettingsForm();
            settingsForm_.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitFilterLists();
        }

        private void InitFilterLists()
        {
            controlsChangesLock_ = true;
            FillDaysList();
            FillFromTimeList();
 
            controlsChangesLock_ = false;
        }

        private void FillDaysList()
        {
            bool collegeDay = false;
            int today = (int)DateTime.Now.DayOfWeek;
            for (int dayNum=0; dayNum<=5; dayNum++)
            {
                if (today != dayNum)
                    dayCmbx.Items.Add(HebrewDay.IntDayToString(dayNum));
                else
                {   
                    dayCmbx.Items.Add("היום");
                    collegeDay = true;
                }
            }
               
            if (collegeDay)
                dayCmbx.SelectedIndex = dayCmbx.FindStringExact("היום");
            else
                dayCmbx.SelectedIndex = dayCmbx.FindStringExact("ראשון");
        }

        private void FillFromTimeList()
        {
            timeCmbx.Items.Clear();
            Hour nowHour = new Hour(7, 0);
            if (dayCmbx.SelectedItem.ToString() == "היום" && Hour.Now() >= new Hour(7, 0))
            {
                nowHour = Hour.Now() >= new Hour(7, 0) ? Hour.Now() : new Hour(7, 0);
                timeCmbx.Items.Add(nowHour + " (עכשיו)");
            }

            for (int hour = nowHour.Hours; hour <= 23; hour++)
            {
                timeCmbx.Items.Add(hour + ":00");
                timeCmbx.Items.Add(hour + ":30");
            }
            timeCmbx.SelectedIndex = 0;
        }

        private void time_from_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!controlsChangesLock_)
            {
                controlsChangesLock_ = true;
                controlsChangesLock_ = false;
            }
        }
        
        private void day_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!controlsChangesLock_)
            {
               controlsChangesLock_ = true;
               FillFromTimeList();
               timeCmbx.SelectedIndex = 0;
               controlsChangesLock_ = false;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            searchBtn.Enabled = false;
            resultTable.Rows.Clear();
            SapirParser parser = new SapirParser();
            parser.LoadDataFromHTML(SapirParser.getDayURL(dayCmbx.SelectedItem.ToString()));
            var classesHours = parser.getClassesHours();

            string timeSelection = timeCmbx.SelectedItem.ToString();
            Hour fromTimerHour = new Hour(timeSelection.Replace("(עכשיו)", ""));
            foreach (KeyValuePair<string, ClassRoom> classEntry in classesHours)
            {
                Console.Write("Class {0}: ", classEntry.Value.ID.ToString());
                classEntry.Value.HoursList.PrintList();

                var freeTime = classEntry.Value.HoursList.GetFreeTime(fromTimerHour);

                if (freeTime != null)
                {
                    Console.WriteLine("{0}  Total time: {1}", freeTime.fromTo.ToString(), freeTime.totalTime.ToString());
                    if (freeTime.totalTime > new Hour(0,0))
                        resultTable.Rows.Add(classEntry.Value.ID,
                                                classEntry.Value.Building,
                                                classEntry.Value.Floor,
                                                freeTime.fromTo.ToHebString(),
                                                freeTime.totalTime);
                }
            }
            searchBtn.Enabled = true;
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void advanced_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fast_srch_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            filterGrbx.Enabled = false;
            timeCmbx.Items.Clear();
            dayCmbx.Items.Clear();
            InitFilterLists();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            if (aboutForm_ == null || aboutForm_.IsDisposed)
                aboutForm_ = new AboutForm();
            aboutForm_.Show();

        }
    }
}
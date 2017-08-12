

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Xml.XPath;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClassMate.ClassTime;

namespace ClassMate.Parsers
{
    class SapirParser : Parser
    {
        //TODO: these URLs updates every semester. Support dynamic update from online server
        //TODO: enable change of links throught settings screen
        //TODO: add possibility to save extracted data in files for using offline

        public const string CLASSES_TAG = "//td";
        public const int FIRST_CLASS_INDEX = 5;
        public const int BETWEEN_CLASSES_OFFSET = 7;

        private HtmlWeb web_obj_;
        private HtmlAgilityPack.HtmlDocument html_doc_;
        private Dictionary<string, ClassRoom> classes_hours_;

        private static SapirParser instance = null;
        //adding locking object
        private static readonly object syncRoot = new object();
        public SapirParser() 
        {
            web_obj_ = new HtmlWeb();
            classes_hours_ = new Dictionary<string, ClassRoom>();
        }

        public void LoadDataFromHTML(string url)
        {
            try
            {
                try
                {
                    html_doc_ = web_obj_.Load(url);
                }
                catch (System.UriFormatException)
                {
                    MessageBox.Show(
                                "One of the days URLs in setting screen may be broken. Make sure URLs are correct and try again",
                                "URL Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show(
                                "Couldn't connect to Sapir. Please check your internet connection and try again",
                                "Connection Error",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }
           var node = html_doc_.DocumentNode.SelectNodes(CLASSES_TAG);
           int num_of_records = node.Count();

          // Console.Write(node[0].InnerText);

            string class_id = "";
            HourNode hours_window = null;
            HoursOrderedLinkedList temp_hours_linked_list = null;

            for (int i = FIRST_CLASS_INDEX;
                 i < num_of_records;
                 i += BETWEEN_CLASSES_OFFSET)
            {
                class_id = Regex.Match(node[i + 1].InnerText, @"\d+").Value;
                //Sapir HTML is fucked up, so check if class name is legal first
                if (class_id != "")
                {
                    hours_window = new HourNode(node[i].InnerText);
                    ClassRoom temp_class = new ClassRoom(class_id);
                    //test regex:
                    Console.Write(node[i + 1].InnerText + ": "); Console.WriteLine(class_id);

                    if (!classes_hours_.ContainsKey(class_id))
                    {
                        temp_hours_linked_list = new HoursOrderedLinkedList();
                        temp_hours_linked_list.Add(hours_window);
                        temp_class.attachHours(temp_hours_linked_list);
                        classes_hours_.Add(class_id, temp_class);
                        temp_hours_linked_list = null;
                        temp_class = null;
                    }
                    else
                    {
                        classes_hours_.TryGetValue(class_id, out temp_class);
                        temp_class.addHourNode(hours_window);
                    }

                    class_id = "";
                    hours_window = null;
                }
            }
        }

       

        public void loadDataToFile()
        {
            
        }

        public ClassRoom getClassRoom(string class_id)
        {
            ClassRoom result = new ClassRoom(class_id);
            classes_hours_.TryGetValue(class_id, out result);
            //temp_hours_linked_list.printList();
            //Console.WriteLine(temp_hours_linked_list.size());
            return result;
        }

        public Dictionary<string, ClassRoom> getClassesHours()
        {
            return classes_hours_;
        }

        public static string getDayURL(string day)
        {
            switch (day)
            {
                case "ראשון":
                    return Properties.Settings.Default.sunday_url;
                case "שני":
                    return Properties.Settings.Default.monday_url;
                case "שלישי":
                    return Properties.Settings.Default.tuesday_url;
                case "רביעי":
                    return Properties.Settings.Default.wednesday_url;
                case "חמישי":
                    return Properties.Settings.Default.thursday_url;
                case "שישי":
                    return Properties.Settings.Default.friday_url;
                case "היום":
                    return getDayURL(HebrewDay.IntDayToString((int)DateTime.Now.DayOfWeek));
            }
            return "";
        }


    }
}

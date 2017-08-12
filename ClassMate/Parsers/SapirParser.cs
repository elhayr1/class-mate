

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

        private HtmlWeb webObj_;
        private HtmlAgilityPack.HtmlDocument HTMLDoc_;
        private Dictionary<string, ClassRoom> classesHours_;

        public SapirParser() 
        {
            webObj_ = new HtmlWeb();
            classesHours_ = new Dictionary<string, ClassRoom>();
        }

        public void LoadDataFromHTML(string url)
        {
            try
            {
                try
                {
                    HTMLDoc_ = webObj_.Load(url);
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
           var node = HTMLDoc_.DocumentNode.SelectNodes(CLASSES_TAG);
           int numOfRecords = node.Count();

          // Console.Write(node[0].InnerText);

            string classId = "";
            HourNode hoursWindow = null;
            HoursOrderedLinkedList tempHoursList = null;

            for (int i = FIRST_CLASS_INDEX;
                 i < numOfRecords;
                 i += BETWEEN_CLASSES_OFFSET)
            {
                classId = Regex.Match(node[i + 1].InnerText, @"\d+").Value;
                //Sapir HTML is fucked up, so check if class name is legal first
                if (classId != "")
                {
                    hoursWindow = new HourNode(node[i].InnerText);
                    ClassRoom tempClass = new ClassRoom(classId);
                    //test regex:
                    Console.Write(node[i + 1].InnerText + ": "); Console.WriteLine(classId);

                    if (!classesHours_.ContainsKey(classId))
                    {
                        tempHoursList = new HoursOrderedLinkedList();
                        tempHoursList.Add(hoursWindow);
                        tempClass.attachHours(tempHoursList);
                        classesHours_.Add(classId, tempClass);
                        tempHoursList = null;
                        tempClass = null;
                    }
                    else
                    {
                        classesHours_.TryGetValue(classId, out tempClass);
                        tempClass.addHourNode(hoursWindow);
                    }

                    classId = "";
                    hoursWindow = null;
                }
            }
        }

        public ClassRoom GetClassRoom(string class_id)
        {
            ClassRoom result = new ClassRoom(class_id);
            classesHours_.TryGetValue(class_id, out result);
            return result;
        }

        public Dictionary<string, ClassRoom> GetClassesHours()
        {
            return classesHours_;
        }

        public static string GetDayURL(string day)
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
                    return GetDayURL(HebrewDay.IntDayToString((int)DateTime.Now.DayOfWeek));
            }
            return "";
        }


    }
}

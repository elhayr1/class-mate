

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

namespace ClassMate.Parsers
{
    class SapirParser : Parser
    {
        //TODO: these URLs updates every semester. Support dynamic update from online server
        //TODO: enable change of links throught settings screen
        //TODO: add possibility to save extracted data in files for using offline

        public const string SUNDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%F8%E0%F9%E5%EF&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=1&tod=1&cidfilter=030,050,010";
        public const string MONDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%F9%F0%E9&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=2&tod=2&cidfilter=030,050,010";
        public const string TUESDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%F9%EC%E9%F9%E9&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=3&tod=3&cidfilter=030,050,010";
        public const string WEDNESDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%F8%E1%E9%F2%E9&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=4&tod=4&cidfilter=030,050,010";
        public const string THURSDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%E7%EE%E9%F9%E9&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=5&tod=5&cidfilter=030,050";
        public const string FRIDAY_URL = "http://events.sapir.ac.il/asplinks/newlist.asp?co=3,5,73,69,7,75,74&cok=,,,&teax=16&sm=1,8&titles=&mtit=%F9%E9%E1%E5%F5%20%EC%E9%E5%ED%20%F9%E9%F9%E9&fher=Arial&ftet=Arial&ftit=Arial&cher=ff6820&ctit=00008b&ctet=00008b&bher=1&btit=0&btet=0&bgch=e6e6fa&bgctit=e6e6fa&bgctet=e6e6fa&sitit=28&siher=24&sitet=16&bgc=e6e6fa&isHdr=1&bgi=&spd=1&sTime=0&cidd=12%26%239001%3B=1&Facu=0&db_num=2007%20&sf=0&st=19999&fromd=6&tod=6&cidfilter=030,050";
        public const string CLASSES_TAG = "//td";
        public const int FIRST_CLASS_INDEX = 5;
        public const int BETWEEN_CLASSES_OFFSET = 7;

        private HtmlWeb web_obj_;
        private HtmlAgilityPack.HtmlDocument html_doc_;
        private Dictionary<string, ClassRoom> classes_hours_;

        private static SapirParser instance = null;
        //adding locking object
        private static readonly object syncRoot = new object();
        private SapirParser() 
        {
            web_obj_ = new HtmlWeb();
            classes_hours_ = new Dictionary<string, ClassRoom>();
        }

        public static SapirParser Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SapirParser();
                        }
                    }
                }
                return instance;
            }
        }

        public void loadDataFromHTML(string url)
        {
            try
            {
                html_doc_ = web_obj_.Load(url);
                
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show(null,
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
                        temp_hours_linked_list.add(hours_window);
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

        public static string intDayToString(int day)
        {
            switch (day)
            {
                case 0:
                    return "ראשון";
                case 1:
                    return "שני";
                case 2:
                    return "שלישי";
                case 3:
                    return "רביעי";
                case 4:
                    return "חמישי";
                case 5:
                    return "שישי";
            }
            return "";
        }

        public static int stringDayToInt(string day)
        {
            switch (day)
            {
                case "ראשון":
                    return 0;
                case "שני":
                    return 1;
                case "שלישי":
                    return 2;
                case "רביעי":
                    return 3;
                case "חמישי":
                    return 4;
                case "שישי":
                    return 5;
            }
            return -1;
        }

        public static string getDayURL(string day)
        {
            switch (day)
            {
                case "ראשון":
                    return SUNDAY_URL;
                case "שני":
                    return MONDAY_URL;
                case "שלישי":
                    return TUESDAY_URL;
                case "רביעי":
                    return WEDNESDAY_URL;
                case "חמישי":
                    return THURSDAY_URL;
                case "שישי":
                    return FRIDAY_URL;
                case "היום":
                    return getDayURL(intDayToString((int)DateTime.Now.DayOfWeek));
            }
            return "";
        }


    }
}

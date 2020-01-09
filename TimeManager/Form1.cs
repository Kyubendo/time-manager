using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace TimeManager
{

    public partial class Form1 : Form
    {
        const string filePath = @"C:\Users\Igor\source\repos\TimeManager\MyFile.txt";
        const string fileExample = @"C:\Users\Igor\source\repos\TimeManager\Example.txt";
        const string fileTime = @"C:\Users\Igor\source\repos\TimeManager\Time.txt";



        string fileText = File.ReadAllText(filePath);
        string Example = File.ReadAllText(fileExample);

        int allTime = int.Parse(File.ReadAllText(fileTime));

        


        DateTime dt = DateTime.Now.AddHours(-4);
        
        

        public int getTodayTime()
        {
            int todayTime;

            try
            {
                string DoW = dt.DayOfWeek.ToString();
                int pos = fileText.IndexOf(DoW) + DoW.Length;
                string subjectString = fileText.Substring(pos).ToString();
                todayTime = int.Parse(Regex.Match(subjectString, @"\d+").Value);
                
            }
            catch
            {
                todayTime = 0;
            }
            return todayTime;
        }

        public int getAllSpentTime()
        {
            int spentTime = 0;
            string[] DoWs = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i =0; i <7;i++)
            {
                string DoW = DoWs[i];
                try
                {                    
                    int pos = fileText.IndexOf(DoW) + DoW.Length;
                    string subjectString = fileText.Substring(pos).ToString();
                    spentTime += int.Parse(Regex.Match(subjectString, @"\d+").Value);

                }
                catch
                {
                    spentTime += 0;                    
                }                
            }
            return spentTime;
        }

        public void setAllSpentTime()
        {
            int spentTime = getAllSpentTime();

            spentHoursO.Text = (spentTime / 60).ToString();
            spentMinutesO.Text = (spentTime % 60).ToString();
        }

        public void setRemTime()
        {
            int remTime = allTime - getAllSpentTime();

            remHoursO.Text = (remTime / 60).ToString();
            remMinutesO.Text = (remTime % 60).ToString();
        }

        public void setAvrgSpentTime()
        {
            string[] DoWs = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int spentDays=7;
            for (int i = 0; i < 7; i++)
            {
                string DoW = DoWs[i];
                try
                {
                    int pos = fileText.IndexOf(DoW) + DoW.Length;
                    string subjectString = fileText.Substring(pos).ToString();
                    int.Parse(Regex.Match(subjectString, @"\d+").Value);
                }
                catch
                {
                    spentDays = i;
                    break;
                }
            }
            if (spentDays==0) spentDays = 1;
            int avrgSpentTime = getAllSpentTime() / spentDays;

            avrgSpentHoursO.Text = (avrgSpentTime / 60).ToString();
            avrgSpentMinutesO.Text = (avrgSpentTime % 60).ToString();

        }

        public void setAvrgRemTime()
        {
            string[] DoWs = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int spentDays = 7;
            for (int i = 0; i < 7; i++)
            {
                string DoW = DoWs[i];
                try
                {
                    int pos = fileText.IndexOf(DoW) + DoW.Length;
                    string subjectString = fileText.Substring(pos).ToString();
                    int.Parse(Regex.Match(subjectString, @"\d+").Value);
                }
                catch
                {
                    spentDays = i;
                    break;
                }
            }
            int remDays = 7 - spentDays;
            if (remDays == 0) remDays = 1;
            int avrgRemTime = (allTime - getAllSpentTime()) / remDays;
            
            avrgRemHoursO.Text = (avrgRemTime / 60).ToString();
            avrgRemMinutesO.Text = (avrgRemTime % 60).ToString();
        }

        public void ifMonday()
        {
            
        }

        public void update()
        {
            try
            {
                string DoW = dt.DayOfWeek.ToString();
                

                int pos = fileText.IndexOf(DoW) + DoW.Length;
                string subjectString = fileText.Substring(pos).ToString();
                int curMinutes = int.Parse(Regex.Match(subjectString, @"\d+").Value);
                todayHoursO.Text = (curMinutes / 60).ToString();
                todayMinutesO.Text = (curMinutes % 60).ToString();
            }
            catch
            {
                todayHoursO.Text = (0).ToString();
                todayMinutesO.Text = (0).ToString();
            }

           
            setAllSpentTime();
            setRemTime();
            setAvrgSpentTime();
            setAvrgRemTime();
        }

        public Form1()
        {
            InitializeComponent();
            update();
        }


        private void addTimeButton_Click(object sender, EventArgs e)
        {
            int addMinutes = 0;

            try
            {
                int minutes = int.Parse(addMinutesI.Text.ToString());
                addMinutes += minutes;
            }
            catch { }

            try
            {
                int hours = int.Parse(addHoursI.Text.ToString());
                addMinutes += hours * 60;
            }
            catch { }

            string DoW = dt.DayOfWeek.ToString();

            int pos = fileText.IndexOf(DoW) + DoW.Length;

            try
            {
                string subjectString = fileText.Substring(pos).ToString();
                int curMinutes = int.Parse(Regex.Match(subjectString, @"\d+").Value);
                addMinutes += curMinutes;

                int length = curMinutes.ToString().Length;

                //string toInsert = Regex.Replace(subjectString, @"\d+", addMinutes.ToString());
                string toInsert = addMinutes.ToString();
                


                //fileText = fileText.Replace(subjectString, toInsert);
                var aStringBuilder = new StringBuilder(fileText);
                aStringBuilder.Remove(pos, length);
                aStringBuilder.Insert(pos, toInsert);
                fileText = aStringBuilder.ToString();

            }
            catch
            {
                fileText = fileText.Insert(pos, addMinutes.ToString());
            }



            File.WriteAllText(filePath, fileText);
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DoW = dt.DayOfWeek.ToString();
            if (DoW == "Monday")
            {
                int remtime = allTime - getAllSpentTime();
                remtime = remtime > 0 ? remtime / 2 : remtime * 2;

                remtime += 1830;

                File.WriteAllText(fileTime, remtime.ToString());

                File.WriteAllText(filePath, File.ReadAllText(fileExample));

            }
        }
    }
}
namespace OOP
{
    public class Date
    {
        private int day, month, year;
        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {

                if(this.day > 0)//if the day is populated
                {
                    //Apply the check if the month is valid
                }

                if (value < 1 || value > 12)
                    Console.WriteLine("Month entered is not valid");
                else
                    this.month = value;
            }
        }

        public int Day
        {
            get { return this.day; }
            set
            {
                if(this.Month > 0)//if month is entered
                {
                    //add the additional check on the Day, based on month
                }
                if (value < 1 || value > 31)
                    Console.WriteLine("Day entered is not valid");
                else
                    this.day = value;
            }
        }

        public int Year
        {
            get { return this.year; }
            set {

                if(this.Month == 2 && this.Day == 29)
                {
                    //Check if the year valid
                }
                this.year = value;
            }
        }

        public int GetAgeDifference(Date date)//current Date - date we provide to the method/function
        {
            int age = this.Year - date.Year;//this - Date object the function/method is called from

            if((this.Month < date.Month) ||
                (this.Month == date.Month && this.Day < date.Day))
            {
                age--;
            }
            return age;
        }

        private Char DetermineDateSeparator(string format)
        {
            if (format.Contains('.'))
                return '.';
            else if (format.Contains('-'))
                return '-';
            else if (format.Contains('/'))
                return '/';
            else if (format.Contains(' '))
                return ' ';
            else if (format.Contains('_'))
                return '_';
            else
                return 'X';
        }

        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Date(string dateStr, string format)
        {
            this.SetDate(dateStr, format);
        }

        public static Date ConvertStringToDate(string dateStr, string format)
        {
            return new Date(dateStr, format);
        }

        public void SetDate(string dateStr,string format)//yyyy-dd-mm
        {
            //xx-xx-xxxx
            char separator = this.DetermineDateSeparator(format);
            string[] formatSplit = format.Split(separator);
            string[] dateSplit = dateStr.Split(separator);
          
            if (formatSplit[0] == "dd")
            {
                this.Day = Convert.ToInt32(dateSplit[0]);
            }
            else if(formatSplit[0] == "mm")
            {
                this.Month = Convert.ToInt32(dateSplit[0]);
            }
            else if (formatSplit[0] == "yyyy")
            {
                this.Year = Convert.ToInt32(dateSplit[0]);
            }
            else
            {
                Console.WriteLine("Wrong date format");
                return;
            }

            if (formatSplit[1] == "dd")
            {
                this.Day = Convert.ToInt32(dateSplit[1]);
            }
            else if (formatSplit[1] == "mm")
            {
                this.Month = Convert.ToInt32(dateSplit[1]);
            }
            else if (formatSplit[1] == "yyyy")
            {
                this.Year = Convert.ToInt32(dateSplit[1]);
            }
            else
            {
                Console.WriteLine("Wrong date format");
                return;
            }

            if (formatSplit[2] == "dd")
            {
                this.Day = Convert.ToInt32(dateSplit[2]);
            }
            else if (formatSplit[2] == "mm")
            {
                this.Month = Convert.ToInt32(dateSplit[2]);
            }
            else if (formatSplit[2] == "yyyy")
            {
                this.Year = Convert.ToInt32(dateSplit[2]);
            }
            else
            {
                Console.WriteLine("Wrong date format");
                return;
            }


        }

        public string GetString()
        {
            return this.Day + "-" + this.Month + "-" + this.Year;
        }


    }
}

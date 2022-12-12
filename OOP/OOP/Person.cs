namespace OOP
{
    public class Person
    {
        private string name, lastname;
        private Date dateOfBirth;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; } 
        }

        public Date DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string CalculateFullName()
        {
            return this.name + " " + this.lastname;
        }

        //string fullName = personObject.FullName;
        public string FullName
        {
            get { return this.name + " " + this.lastname;  }
        }

        public int Age
        {
            get {

                Date currentDate = new Date();
                string currentDateStr = DateTime.Now.Day + "-" + DateTime.Now.Month +
                    "-" + DateTime.Now.Year;
                currentDate.SetDate(currentDateStr, "dd-mm-yyyy");
                return currentDate.GetAgeDifference(this.dateOfBirth);

            }
        }

        public void Show()
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Last Name : " + this.LastName);
            Console.WriteLine("Date of Birth : " + this.DateOfBirth.GetString());
        }

    }
}

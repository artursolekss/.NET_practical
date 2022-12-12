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

        //public Person()//Constructor
        //{
        //    this.name = "";
        //    this.lastname = "";
        //    this.dateOfBirth = new Date();
        //}

        public Person(string name, string lastname, Date dateOfBirth)
        {
            this.name = name;
            this.lastname = lastname;
            this.dateOfBirth = dateOfBirth;
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

                
                string currentDateStr = DateTime.Now.Day + "-" + DateTime.Now.Month +
                    "-" + DateTime.Now.Year;
                Date currentDate = new Date(currentDateStr, "dd-mm-yyyy");
                return currentDate.GetAgeDifference(this.dateOfBirth);

            }
        }

        public void Show()
        {
            Console.WriteLine("Full Name : " + this.FullName);
            Console.WriteLine("Date of Birth : " + this.DateOfBirth.GetString());
            Console.WriteLine("Age : " + this.Age);
        }

    }
}

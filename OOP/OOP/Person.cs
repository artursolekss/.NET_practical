namespace OOP
{
    public class Person
    {
        private string name, lastname;
        private Date dateOfBirth;

        protected string protectedAttribute;

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
        //    //this.dateOfBirth = new Date();
        //    Console.WriteLine("Non-parameterized contructor of Person class called");
        //}

        public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            this.dateOfBirth = new Date("01-01-2000", "dd-mm-yyyy");
            this.protectedAttribute = "dummy";
        }

        public Person(string name, string lastname, Date dateOfBirth) : this(name,lastname)//calls another constructor of the same class
        {
            //this.name = name;
            //this.lastname = lastname;
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
            Console.WriteLine("Date of Birth : " + this.DateOfBirth);//ToString method called
            Console.WriteLine("Age : " + this.Age);
        }

        //person1 (obj);person2 (obj); person1.CompareAge(person2);
        public void CompareAge(Person person)
        {
            CompareAges(this, person);
        }

        public static void CompareAges(Person person1,Person person2)
        {
            int ageDiff = person1.Age - person2.Age;
            if(ageDiff > 0)
            {
                Console.WriteLine(person1.FullName + " is older than "
                    + person2.FullName);
            }
            else if(ageDiff < 0)
            {
                Console.WriteLine(person2.FullName + " is older than "
                    + person1.FullName);
            }
            else
            {
                Console.WriteLine("Both persons have the same age");
            }
        }

    }
}

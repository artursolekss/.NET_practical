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
            get { return 0; }
        }

    }
}

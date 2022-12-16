namespace OOP
{
    class Employee : Person
    {
        private string position;

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public Employee(string position,
            string firstName,string lastName):
            base(firstName,lastName)
        {
            this.position = position;
            //base.Name = "My new for name";
            this.protectedAttribute = "Available from here";
        }

    }
}

namespace OOP
{
    //sealed class Employee : Person // sealed means it can't be extended
    class Employee : Person
    {
        private string position;

        private bool workingtime = false;

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

        public void StartWork()
        {
            this.workingtime = true;
        }

        public void FinishWork()
        {
            this.workingtime = false;
        }

        public sealed override void Sleep()//if the method is defined as sealed, we can't override it anymore
        {
            if (this.workingtime)
                Console.WriteLine("It's working time, no time for sleep!");
            else
                 base.Sleep();
        }

    }
}

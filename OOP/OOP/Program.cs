namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {
            //Computer computer = new Computer();//object computer created
            //                                   //computer = Computer.GetInstance();
            //computer.TurnOn();
            ////computer.SetPrice(300);
            ////double price = computer.GetPrice();
            //computer.Price = 300;// set called (if we try to assign the valie)
            //double price = computer.Price; // get called (if we try to get the value)
            //                               //computer.price = 300;  double price = computer.price;

            //Date date = new Date();
            //date.Day = 12; date.Month = 10; date.Year = 2020;

            Person person = new Person();//create the object Person
            Console.WriteLine("Enter First Name : ");
            //person.FullName = "test";//not possible, because we didn't define the setter
            person.Name = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter date format (ex. dd-mm-yyyy))");
            string dateFormat = Console.ReadLine();

            Console.WriteLine("Enter date of birth:");
            string dateStr = Console.ReadLine();

            Date date = new Date();
            date.SetDate(dateStr, dateFormat);//date is set for the object

            person.DateOfBirth = date;

            person.Show();

        }

    }

    class Computer
    {
        private double price, weightKg;
        private string color;
        private bool on;

        public double Price
        {
            get
            {
                //any logic can be written here
                return this.price;
            }
            set
            {
                //any logic can be written here    
                this.price = value;
            }
        }


        //public static Computer GetInstance()
        //{
        //    return new Computer();
        //}

        public void TurnOn()
        {
            on = true;
        }

        //public double GetPrice()
        //{
        //    return this.price;
        //}

        //public void SetPrice(double price)
        //{
        //    this.price = price;
        //}

        public void RandomFunction()
        {

            Computer computer = new Computer();//
                                               //this keyword - refers to the current computer
                                               //(object) you are working from

            //computer variable will store another computer
        }

    }
}

namespace OOP
{
    class OOP
    {
        static void Main(string[] args)
        {

            //OOP.TestComputer();
            //OOP.TestPersons();
            //OOP.TestIndexers();
            //OOP.TestCustomArrayType();
            OOP.TestOverloading();
        }


        static void TestOverloading()
        {
            Shape shape = new Shape();
            Console.WriteLine(shape.CalculatePerimeter(12.1, 45.32));
            Console.WriteLine(shape.CalculatePerimeter(12.1));
            Console.WriteLine(shape.CalculatePerimeter(12.1, 45.32,45.10));

            double[] sides = new double[] { 1, 2, 3, 4, 5, 6 };
           Console.WriteLine(shape.CalculatePerimeter(sides));
        }
        static void TestCustomArrayType()
        {
            ImprovedArray arr = new ImprovedArray();
            arr[0] = "Element1";
            arr[1] = "Element2";
            arr[2] = "Element3";

            for (int i = 0; i < arr.Length;i++)
                Console.WriteLine(arr[i]);
        }

        static void TestIndexers()
        {
            CompositionOverloading obj = new CompositionOverloading(10);

            //obj.SetElement(0,"Text1234");
            //obj['A'] = "Text1234";
            //obj['B'] = "Second element";

            //Console.WriteLine(obj['B']);
            //Console.WriteLine(obj['A']);

            Console.WriteLine(obj.ToString());

        }

        static void TestComputer()
        {
            //Computer computer = new Computer();//object computer created
            //                                   //computer = Computer.GetInstance();
            //computer.TurnOn();
            ////computer.SetPrice(300);
            ////double price = computer.GetPrice();
            //computer.Price = 300;// set called (if we try to assign the valie)
            //double price = computer.Price; // get called (if we try to get the value)
            //                               //computer.price = 300;  double price = computer.price;


        }

        static void TestPersons()
        {

            //Date date = new Date();
            //date.Day = 12; date.Month = 10; date.Year = 2020;

            //Person person = new Person();//create the object Person
            //name = "";lastname = ""; dateOfBirth = (empty date object)
            //name = null; lastname = null; dateOfBirth = null;
            Console.WriteLine("Enter First Name : ");
            //person.FullName = "test";//not possible, because we didn't define the setter
            //person.Name = Console.ReadLine();
            string name = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            //person.LastName = Console.ReadLine();
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter date format (ex. dd-mm-yyyy))");
            string dateFormat = Console.ReadLine();

            Console.WriteLine("Enter date of birth:");
            string dateStr = Console.ReadLine();

            Date date = Date.ConvertStringToDate(dateStr, dateFormat);
            //Date date = new Date(dateStr, dateFormat);//date is set for the object

            //person.DateOfBirth = date;
            Person person = new Person(name, lastName, date);
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

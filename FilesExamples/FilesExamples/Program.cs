class Program
{

    public static void Main(string[] args)
    {
        string myFile =
            File.ReadAllText(@"C:\Users\AOLEKSS\Documents\dotnetPractical\Persons.csv");
        
        string[] fileLines = myFile.Split("\n");//split by lines

        LinkedList<Person> personList = new LinkedList<Person>();

        for(int i = 1; i < fileLines.Length; i++)//i=1 because we skip the header line
        {
            string[] lineFields = fileLines[i].Split(";");
            if(lineFields.Length != 3)
                continue;//skip this line
            Person person = new Person();
            person.Id = Int32.Parse(lineFields[0]);
            person.Name = lineFields[1];
            person.LastName = lineFields[2];
            personList.AddLast(person);
        }

          foreach(var person in personList)
            Console.WriteLine(person);

    }

    struct Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(int id,string name,string lastname)
        {
            Id = id;
            Name = name;
            LastName = lastname;
        }

        public override string ToString()
        {
            return "ID : " + this.Id + "; Name : "
                + this.Name + "; Last Name : " + this.LastName;
        }
    }

    //class Person
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }

    //    public Person(string name, string lastName)
    //    {
    //        this.Name = name;
    //        this.LastName = lastName;
    //    }
    //}

}
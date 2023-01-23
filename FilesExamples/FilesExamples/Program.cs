using MySqlConnector;
using System.Data;
using System.Text;
using System.Text.Json;

class Program
{
    public static string Separator { get; set; }


    public static void Main(string[] args)
    {
        //Console.WriteLine("Enter the list separator:");
        //Separator = Console.ReadLine();
        Console.WriteLine("Enter the file path:");
        string myFilePath = Console.ReadLine();
        string myFile = File.ReadAllText(myFilePath);
        Program.MigrateDepartemnts(myFile);
        Console.WriteLine(myFile);
        //string[] fileLines = myFile.Split(Environment.NewLine);//split by lines

        //LinkedList<Person> personList = new LinkedList<Person>();

        //for (int i = 1; i < fileLines.Length; i++)//i=1 because we skip the header line
        //{
        //    string[] lineFields = fileLines[i].Split(Separator);
        //    if (lineFields.Length != 3)
        //        continue;//skip this line
        //    Person person = new Person();
        //    person.Id = Int32.Parse(lineFields[0]);
        //    person.Name = lineFields[1];
        //    person.LastName = lineFields[2];
        //    personList.AddLast(person);
        //}

        //Console.WriteLine("What do you want to do?");
        //Console.WriteLine("I - insert, M - modify, D - delete,Migr - Migrate");
        //switch (Console.ReadLine())
        //{
        //    case "I":
        //        Program.AddRow(personList);
        //        break;
        //    case "M":
        //        Program.ModifyRow(personList);
        //        break;
        //    case "D":
        //        Program.DeleteRow(personList);
        //        break;
        //    case "Migr":
        //        Program.MigrateFromFile(personList);
        //        break;
        //    default:
        //        Console.WriteLine("Operation is not valid");
        //        break;
        //}

        //string modifiedFile = Person.GenerateCsvFile(personList);

        //File.WriteAllText(myFilePath, modifiedFile);
        //Console.WriteLine("File is modified");

    }

    public static void MigrateDepartemnts(string fileContent)
    {
        AllDepartements allDepartements = JsonSerializer.Deserialize<AllDepartements>(fileContent);
    }


    public static void MigrateFromFile(LinkedList<Person> personList)
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();


        int count = 0;
        foreach (var person in personList)
        {
            MySqlCommand mySqlCommand = connection.CreateCommand();

            //Prepared statement
            mySqlCommand.CommandText = "INSERT INTO persons (firstname, lastname, externalid) " +
                "VALUES (@firstname,@lastname,@externalid)";

            MySqlParameter firstNameParam = new MySqlParameter("@firstname", MySqlDbType.String);
            firstNameParam.Value = person.Name;
            mySqlCommand.Parameters.Add(firstNameParam);

            MySqlParameter lastNameParam = new MySqlParameter("@lastname", MySqlDbType.String);
            lastNameParam.Value = person.LastName;
            mySqlCommand.Parameters.Add(lastNameParam);

            MySqlParameter extIdParam = new MySqlParameter("@externalid", MySqlDbType.Int32);
            extIdParam.Value = person.Id;
            mySqlCommand.Parameters.Add(extIdParam);

            count += mySqlCommand.ExecuteNonQuery();
         
        }
        Console.WriteLine(count + " rows added");
        connection.Close();
    }

    public static void AddRow(LinkedList<Person> personList)
    {
        Person newPerson = new Person();
        Console.WriteLine("Enter the ID");
        newPerson.Id = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Name");
        newPerson.Name = Console.ReadLine();

        Console.WriteLine("Enter Last Name");
        newPerson.LastName = Console.ReadLine();

        personList.AddLast(newPerson);
    }

    public static void ModifyRow(LinkedList<Person> persons)
    {
        Console.WriteLine("Which entry (ID) should be deleted?");
        int id = Int32.Parse(Console.ReadLine());
        Person personToModify = new Person();
        bool personFound = false;
        foreach (var person in persons)
            if (person.Id == id)
            {
                personToModify = person;
                personFound = true;
                break;
            }

        if (personFound)
        {
            persons.Remove(personToModify);
            Console.WriteLine("Enter firstname:");
            personToModify.Name = Console.ReadLine();

            Console.WriteLine("Enter lastname:");
            personToModify.LastName = Console.ReadLine();
            persons.AddLast(personToModify);
        }
        else
        {
            Console.WriteLine("Entry does not exist");
        }
    }

    public static void DeleteRow(LinkedList<Person> persons)
    {
        Console.WriteLine("Which entry (ID) should be deleted?");
        int id = Int32.Parse(Console.ReadLine());
        Person personToDelete = new Person();
        bool personFound = false;
        foreach(var person in persons)
            if(person.Id == id)
            {
                personToDelete = person;
                personFound = true;
                break;
            }

        if (personFound)
            persons.Remove(personToDelete);
        else
            Console.WriteLine("Entry does not exist");
        
    }

}

   public struct Person
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

        public static string GenerateCsvFile(LinkedList<Person> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ID"+ Program.Separator + "Name" + 
                Program.Separator + "Last Name");//header line
            foreach (Person person in list)
                stringBuilder.AppendLine(person.Id +
                    Program.Separator + person.Name + Program.Separator
                    + person.LastName);

            return stringBuilder.ToString();
        }
    }


class AllDepartements
{
    public List<Department> allDepartments { get; set; }
}
class Department
{
    public string name { get; set; }
    public List<Employee> employees { get; set; }
}

class Employee
{
    public string name { get; set; }
    public string startdate { get; set; }

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
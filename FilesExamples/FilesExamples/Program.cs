using MySqlConnector;
using System;
using System.Data;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Schema;

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
        //Console.WriteLine(myFile);

        //Console.WriteLine("Enter the XSD file path:");
        //string myFilePathXsd = Console.ReadLine();
        //string myFileXsd = File.ReadAllText(myFilePathXsd);

        //XmlSchemaSet schemas = new XmlSchemaSet();
        //schemas.Add(null, myFilePathXsd);

        MigrateDepartemntsFromXml(myFile);
   
        //string msg = 
        //xmlFile.Validate(schemas, (o,e) =>
        //{

        //});

        //Console.WriteLine(myFileXsd);
        //Program.MigrateDepartemntsFromJson(myFile);
        //Program.ExtractToJson(myFilePath);
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

    public static void MigrateDepartemntsFromJson(string fileContent)
    {
        AllDepartements allDepartements = JsonSerializer.Deserialize<AllDepartements>(fileContent);
        Program.MigrateDepartements(allDepartements);
    }

    public static void MigrateDepartemntsFromXml(string fileContent)
    {
        XmlDocument xmlFile = new XmlDocument();
        xmlFile.LoadXml(fileContent);
        var rootNode = xmlFile.GetElementsByTagName("allDepartments")[0];
        var allDeparmentsNodes = rootNode.ChildNodes;

        AllDepartements allDepartements = new AllDepartements();
        allDepartements.allDepartments = new List<Department>();
        foreach(XmlNode departmentNode in allDeparmentsNodes)
        {
            if (departmentNode.Name != "Department")
                continue;

            Department department = new Department();
            department.name = departmentNode.Attributes.GetNamedItem("name").Value;
            department.employees = new List<Employee>();
            allDepartements.allDepartments.Add(department);

            var childNotes = departmentNode.ChildNodes;
            foreach(XmlNode departmentChildNode in childNotes)
            {
                if(departmentChildNode.Name == "externalId")
                {
                    department.externalId = departmentChildNode.InnerText;
                }
                else if(departmentChildNode.Name == "employee")
                {
                    Employee employee = new Employee();
                    department.employees.Add(employee);
                    var employeePropertyNodes = departmentChildNode.ChildNodes;
                    foreach(XmlNode employeePropertyNode in employeePropertyNodes)
                    {
                        if (employeePropertyNode.Name == "name")
                            employee.name = employeePropertyNode.InnerText;
                        else if (employeePropertyNode.Name == "startdate")
                            employee.startdate = employeePropertyNode.InnerText;
                    }
                }

            }

        }
        MigrateDepartements(allDepartements);


    }


    public static void MigrateDepartements(AllDepartements allDepartements)
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        List<Department> departments = allDepartements.allDepartments;
        foreach (Department department in departments)
        {
            string name = department.name;
            MySqlCommand mySqlCommand = connection.CreateCommand();

            //Prepared statement
            mySqlCommand.CommandText = "INSERT INTO departments (name,external_id) " +
                "VALUES (@name,@ext_id); select id from departments where external_id = @ext_id";


            MySqlParameter namePar = new MySqlParameter("@name", MySqlDbType.String);
            namePar.Value = name;
            mySqlCommand.Parameters.Add(namePar);

            MySqlParameter extIdPar = new MySqlParameter("@ext_id", MySqlDbType.String);
            extIdPar.Value = department.externalId;
            mySqlCommand.Parameters.Add(extIdPar);

            int departId = (int)mySqlCommand.ExecuteScalar();//return the inserted ID

            foreach(var employee in department.employees)
            {
                MySqlCommand mySqlCommandEmployee = connection.CreateCommand();
                mySqlCommandEmployee.CommandText = "INSERT INTO employees (name,dep,start_date) " +
                "VALUES (@name,@dep,@startDate)";

                MySqlParameter employeeNamePar = 
                    new MySqlParameter("@name", MySqlDbType.String);
                employeeNamePar.Value = employee.name;
                mySqlCommandEmployee.Parameters.Add(employeeNamePar);

                MySqlParameter employeeDepPar =
                   new MySqlParameter("@dep", MySqlDbType.String);
                employeeDepPar.Value = departId;
                mySqlCommandEmployee.Parameters.Add(employeeDepPar);

                MySqlParameter employeeStartDatePar =
                  new MySqlParameter("@startDate", MySqlDbType.String);
                employeeStartDatePar.Value = employee.startdate;
                mySqlCommandEmployee.Parameters.Add(employeeStartDatePar);

                mySqlCommandEmployee.ExecuteNonQuery();
            }

        }


        connection.Close();
    }

    public static void ExtractToJson(string filePath)
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM departments";
        var departmentsResult = command.ExecuteReader();

        AllDepartements allDepartements = new AllDepartements();
        allDepartements.allDepartments = new List<Department>();
        while (departmentsResult.Read())
        {
            Department department = new Department();
            allDepartements.allDepartments.Add(department);
            department.name = departmentsResult.GetString("name");
            department.externalId = departmentsResult.GetString("external_id");
            department.id = departmentsResult.GetInt32("id");
            department.employees = new List<Employee>();
        }

        foreach(var department in allDepartements.allDepartments) {
            connection.Close();

            connection.Open();

            MySqlCommand employeesCmd = connection.CreateCommand();
            employeesCmd.CommandText = "SELECT * FROM employees WHERE dep = @dep";

            MySqlParameter depParam = new MySqlParameter("@dep", MySqlDbType.Int32);
            depParam.Value = department.id;
            employeesCmd.Parameters.Add(depParam);

            var employeeResult = employeesCmd.ExecuteReader();
            while (employeeResult.Read())
            {
                Employee employee = new Employee();
                employee.name = employeeResult.GetString("name");
                DateTime dateTime = employeeResult.GetDateTime("start_date");
                string dateStr = dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day;
                employee.startdate = dateStr;
                department.employees.Add(employee);
            }

        }


        connection.Close();
        string jsonContent = JsonSerializer.Serialize(allDepartements);
        File.WriteAllText(filePath,jsonContent);
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
        foreach (var person in persons)
            if (person.Id == id)
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

    public Person(int id, string name, string lastname)
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
        stringBuilder.AppendLine("ID" + Program.Separator + "Name" +
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

    public string externalId { get; set; }

    public int id { get; set; }
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
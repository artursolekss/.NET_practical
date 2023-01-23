using MySqlConnector;

class Program
{

    public static void Main(string[] args)
    {

        //DatabaseWhereSelection();

        Console.WriteLine("What operation do you want to perform (S - selection, I - insertion)?");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "S":
                DataBaseFullSelection();
                break;
            case "I":
                DatabaseInsertion();
                break;
            default:
                Console.WriteLine("The operation isn't valid");
                break;

        }
        //DatabaseInsertion();
        //DataBaseFullSelection();

    }

    private static void DatabaseInsertion()
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        Console.WriteLine("Enter the First Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the Last Name");
        string lastname = Console.ReadLine();

        Console.WriteLine("Enter the Email");
        string email = Console.ReadLine();

        Console.WriteLine("Enter the Phone");
        string phone = Console.ReadLine();

        MySqlCommand mySqlCommand = connection.CreateCommand();

        //Prepared statement
        mySqlCommand.CommandText = "INSERT INTO customer (firstname, lastname, email, phone) " +
            "VALUES (@firstname,@lastname,@email,@phone)";

        MySqlParameter firstNameParam = new MySqlParameter("@firstname", MySqlDbType.String);
        firstNameParam.Value = name;
        mySqlCommand.Parameters.Add(firstNameParam);

        MySqlParameter lastNameParam = new MySqlParameter("@lastname", MySqlDbType.String);
        lastNameParam.Value = lastname;
        mySqlCommand.Parameters.Add(lastNameParam);

        MySqlParameter emailParam = new MySqlParameter("@email", MySqlDbType.String);
        emailParam.Value = email;
        mySqlCommand.Parameters.Add(emailParam);

        MySqlParameter phoneParam = new MySqlParameter("@phone", MySqlDbType.String);
        phoneParam.Value = phone;
        mySqlCommand.Parameters.Add(phoneParam);

        Console.WriteLine(mySqlCommand.ExecuteNonQuery() + " rows added");

        connection.Close();

    }

    private static void DatabaseWhereSelection()
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        Console.WriteLine("Enter the First Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the Last Name");
        string lastname = Console.ReadLine();

        MySqlCommand mySqlCommand = connection.CreateCommand();
        //mySqlCommand.CommandText = "SELECT * FROM Customer WHERE firstname = '" + name + "'";
        //"SELECT * FROM Customer WHERE firstname = 'Janis' AND lastname = 'Something;

        //Prepared statement
        mySqlCommand.CommandText = "SELECT * FROM Customer WHERE firstname = @firstname" +
            " AND lastname = @lastname";

        MySqlParameter firstNameParam = new MySqlParameter("@firstname", MySqlDbType.String);
        firstNameParam.Value = name;
        mySqlCommand.Parameters.Add(firstNameParam);

        MySqlParameter lastNameParam = new MySqlParameter("@lastname", MySqlDbType.String);
        lastNameParam.Value = lastname;
        mySqlCommand.Parameters.Add(lastNameParam);

        MySqlDataReader reader = mySqlCommand.ExecuteReader();

        Console.WriteLine("ID;FirstName;LastName;Email;Phone");
        //foreach(var line in reader)....
        while (reader.Read())//when Read is called, we go to the next line
                             //if the line does not exist, then it returns false
        {
            Console.Write(reader.GetInt32("id"));
            Console.Write(";");
            Console.Write(reader.GetString("firstname"));
            Console.Write(";");
            Console.Write(reader.GetString("lastname"));
            Console.Write(";");
            Console.Write(reader.GetString("email"));
            Console.Write(";");
            Console.Write(reader.GetString("phone"));
            Console.Write(";");
            Console.Write(Environment.NewLine);
        }

        connection.Close();
    }

    private static void DataBaseFullSelection()
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        MySqlCommand mySqlCommand = connection.CreateCommand();
        mySqlCommand.CommandText = "SELECT * FROM Customer";
        MySqlDataReader reader = mySqlCommand.ExecuteReader();

        Console.WriteLine("ID;FirstName;LastName;Email;Phone");
        //foreach(var line in reader)....
        while (reader.Read())//when Read is called, we go to the next line
                             //if the line does not exist, then it returns false
        {
            Console.Write(reader.GetInt32("id"));
            Console.Write(";");
            Console.Write(reader.GetString("firstname"));
            Console.Write(";");
            Console.Write(reader.GetString("lastname"));
            Console.Write(";");
            Console.Write(reader.GetString("email"));
            Console.Write(";");
            Console.Write(reader.GetString("phone"));
            Console.Write(";");
            Console.Write(Environment.NewLine);
        }

        connection.Close();
    }


}
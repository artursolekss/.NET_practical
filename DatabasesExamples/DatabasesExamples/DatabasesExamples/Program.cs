using MySqlConnector;

class Program
{

    public static void Main(string[] args)
    {
        string connectionString = "server=localhost;uid=root;database=dotnetdemo";
        MySqlConnection connection= new MySqlConnection(connectionString);
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
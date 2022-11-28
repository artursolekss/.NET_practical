
//class Class2
//{
//    static void Main(string[] args)//class + function name + pattern of the parameters ===>>>> uniquness of the function
//    {

//    }
//}

class UserInput
{
    //define the functions needed for the Input user
    public static int EnterIntNumber()
    {
        int input = 0;
        Console.WriteLine("Enter the integer number : ");
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("The value provided is wrong. Try again");
            }
        }
        return input;
    }

}

class Calculations
{
    //define the functions needed for any specific calculations

    public static void Pow2(ref int val)
    {
        val *= val;
    }

    public static int Multiply(ref int val1,ref int val2)
    {
        int result = val1 * val2;
        val1 = 748364343;
        val2 = 7634343;

        return result;
    }

}


class Functions {


    public static void Main(string[] args)
    {
        //int result = Functions.Multiply(23, 21);
        //Console.WriteLine(result);

        //Test(12121, "string1Elemen");
        //Test(121232, "string1Elemen");
        int element1 = UserInput.EnterIntNumber();
        int element2 = UserInput.EnterIntNumber();
        int result = Calculations.Multiply(ref element2,ref element1);
        Console.WriteLine(element1 + " * " + element2 + " = " + result);

        int element = 5;
        Calculations.Pow2(ref element);
        Calculations.Pow2(ref element);
        Console.WriteLine(element);

    }

    public static void Test(int element1, string element2)
    {
        
    }
}

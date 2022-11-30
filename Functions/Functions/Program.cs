
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

    public static int Factorial(int n)
    {
        //int result = 1;
        //for(int i = 1; i <= n; i++)
        //    result *= i;

        if (n == 1)
            return 1;
        else
            return n * Factorial(n - 1);//recursion
        //n! = n * (n-1)! = n * (n - 1) * (n-2)!...
    }

}


class Functions {


    static void Main(string[] args)
    {
        //int result = Functions.Multiply(23, 21);
        //Console.WriteLine(result);

        //Test(12121, "string1Elemen");
        //Test(121232, "string1Elemen");
        //int element1 = UserInput.EnterIntNumber();
        //int element2 = UserInput.EnterIntNumber();
        //int result = Calculations.Multiply(ref element2,ref element1);
        //Console.WriteLine(element1 + " * " + element2 + " = " + result);

        //int element = 5;
        //Calculations.Pow2(ref element);
        //Calculations.Pow2(ref element);
        //Console.WriteLine(element);

        //Test(12, "Test121");

        //Console.WriteLine("Hello 1234");//string
        //Console.WriteLine(1234);//int
        //Console.WriteLine("Goodbye " + 1234);//string
        //Console.WriteLine((12 + 15));//int
        //string[] arr = new string[3];

        //arr[0] = "Element 1";
        //arr[1] = "Element 2";
        //arr[2] = "Element 3";
        //ChangeArray(1, ref arr, "Changed value");
        //PrintArray(arr);

        //string numberStr;
        //double number;
        //do
        //{
        //    Console.WriteLine("Please, enter the number");
        //    numberStr = Console.ReadLine();
        //} 
        //while(!Double.TryParse(numberStr, out number));

        //Console.WriteLine("The number is " + number);

        int number = UserInput.EnterIntNumber();
        Console.WriteLine(Calculations.Factorial(number));
    }

    public static void Test(int element1, string element2)
    {
        
    }

    public static void Test(int element1, string element2,int element3)
    {

    }

    public static void ChangeArray(int index, ref string[] arr,string value)
    {
        string[] copyArray;
        CopyArray(arr,out copyArray);
        copyArray[index] = value;
        arr = copyArray;//change the reference assigned to the variable arr
    }

    public static void PrintArray(string[] arr)
    {
        foreach(string value in arr)
            Console.WriteLine(value);
    }

    public static void CopyArray(string[] arr,out string[] arrCopy)
    {
        arrCopy = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            arrCopy[i] = arr[i];

    }
}

class Practical1
{
    static void Main(string[] args)
    {

        //int valInt = 7;
        //double valDob = valInt;//casting done automatically, because there is no
        ////potential data lose
        //Console.WriteLine(valDob);
        //valDob = 10.56;
        //valInt = (int) valDob;//casting done manually, because there is
        //// the potential data lose
        //Console.WriteLine(valInt);
        //char charVar = 'A';
        //valInt = (int)charVar;
        //Console.WriteLine(valInt);

        //char unicodeVar = '\u0023';
        //Console.WriteLine(unicodeVar);

        //string str = "\\u0023";
        //Console.WriteLine(str);
        //string strAt = @"\u0023";
        //Console.WriteLine(strAt);

        //string str1 = "C:\\Users\\AOLEKSS\\Documents\\dotnetPractical\\Practical1\\Practical1";//need to use the escape characters
        //string str2 = @"C:\Users\AOLEKSS\Documents\dotnetPractical\Practical1\Practical1";//don't need to use the escape characters


        //Console.WriteLine("Please, enter something:");
        //string input = Console.ReadLine();
        //Console.WriteLine("Please, enter something again:");
        //string input2 = Console.ReadLine();
        //string result = input + input2;
        //Console.WriteLine(result);
        //Console.WriteLine("You entered : " + input);
        //Console.WriteLine("You entered : {0}", input);
        Console.WriteLine("Enter number 1");
        string number1str = Console.ReadLine();

        Console.WriteLine("Enter number 2");
        string number2str = Console.ReadLine();

        double number1 = Double.Parse(number1str);
        double number2 = Double.Parse(number2str);
        
        double resultAdd = number1 + number2;
        Console.WriteLine(number1 + " + " + number2 + " = " + resultAdd);

        double resultSubstr = number1 - number2;
        Console.WriteLine(number1 + " - " + number2 + " = " + resultSubstr);

        double resultDiv = number1 / number2;
        Console.WriteLine(number1 + " / " + number2 + " = " + resultDiv);

        double resultMultip = number1 * number2;
        Console.WriteLine(number1 + " * " + number2 + " = " + resultMultip);

        //resultDiv = Math.Round(resultDiv, 2);//round in two decimal places
        //Console.WriteLine(resultDiv);



    }
}

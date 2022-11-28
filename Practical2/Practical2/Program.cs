using System.Globalization;
using System.Text;

class Practical2
{
    static void Main(string[] args)
    {
        //string str1 = "Hello";
        //string str2 = "World";
        //int number = 2121;
        //int number2 = 134;
        //string strResult = str1 + " " + str2 + number;
        ////string strNumberRes = number + number2; //not possible, because int + int = int
        //string strNumberRes = str1 + (number + number2);
        //Console.WriteLine(strNumberRes);
        ////string strMinus = str1 - str2;//such operation isn't defined
        //int modResult = 10 % 3;// 10 - 3 * [10 / 3] = 10 - 3 * 3 = 10 - 9 = 1
        //int modResult2 = 16 % 7;// 16 - 7 * [16/7] = 16 - 7 * 2 = 16 - 14 = 2
        //Console.WriteLine(modResult);
        //Console.WriteLine(modResult2);
        /////797868686866564 % 100 --->> the result will be in the range of 0 to 99
        //modResult++;//same as modResult = modResult + 1;
        //modResult *= 3;//same as modResult = modResult * 3;
        //double valueDouble = 23.9878;
        //double valueRound = Math.Round(valueDouble++, 2);
        ////at this point valueDouble = 24.9878
        //Console.WriteLine(valueRound);

        //valueRound = Math.Round(++valueDouble, 2);
        //Console.WriteLine(valueRound);
        ////index = 0;
        ///list.getByIndex(index++);
        ///list.getByIndex(index++);
        ///

        //bool answer;
        //answer = 13 > 7;//true
        //answer = 19 < 7;//false
        //answer = 13 >= 7;//true
        //answer = 13 > 13;//false
        //answer = 13 >= 13;//true
        //answer = 13 == 13;//true
        //answer = 13 != 13;//false != means NOT Equal to
        //answer = !true;//false (the opossite of true)
        //answer = !false;//true (the opposite of false)
        //answer = true && true;//true
        //answer = (13 >= 13) && (13 == 13);//would be the same as true && true

        //answer = true && false;//false
        //answer = false && false;//false

        //double val1 = 23.6543;
        //double val2 = 56.56565;
        //answer = ++val1 == 21 && ++val2 == 57.56565;//the right side won't be executed, because the left side is false
        //Console.WriteLine(answer);
        //Console.WriteLine(val1);
        //Console.WriteLine(val2);

        //answer = true || true;//true
        //answer = true || false;//true
        //answer = false || false;//false
        //answer = false || true;//true

        ////answer = true && true || false && false;//I don't know
        //answer = true && (false || (false || true));//true
        //                                            //// true && (false || (false || true)) --->> true && (false || true)
        /////--->> true && true == true

        //Random rand = new Random();

        //double randomResult = rand.NextDouble();//it returns the random value from 0 to 1
        //int oneToTen = (int) (1 + (randomResult * 10));
        //Console.WriteLine(oneToTen);

        //bool isMorning = true;


        //if(isMorning)
        //{
        //    Console.WriteLine("Wake up!");
        //}

        //string time = Console.ReadLine();
        //if (time == "Morning")
        //{
        //    Console.WriteLine("Good morning!");
        //}
        //else if (time == "Afternoon")
        //{
        //    Console.WriteLine("Good afternoon!");
        //}
        //else if (time == "Evening")
        //{
        //    Console.WriteLine("Good evening!");
        //}

        //int time = Int32.Parse(Console.ReadLine());
        //if (time >= 5 && time <9)
        //{
        //    if (time <= 7)
        //    {
        //        Console.WriteLine("Good early morning!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Good morning!");
        //    }
        //}
        //else if (time >= 9 && time < 16)
        //{
        //    Console.WriteLine("Good afternoon!");
        //    if (time <= 11)
        //    {
        //        Console.WriteLine("Good late morning!");
        //    }
        //    else if(time >=12 && time <= 13)
        //    {
        //        Console.WriteLine("Enjoy your lunch");
        //    }
        //}
        //else if (time < 24 && time >= 0)
        //{
        //    Console.WriteLine("Good evening!");
        //}
        //else
        //{
        //    Console.WriteLine("Input is not valid");
        //}

        //string val = "ACD";

        //if(val == "BCD")
        //{
        //    Console.WriteLine("BCD");
        //}
        //else if(val == "AUY")
        //{
        //    Console.WriteLine("AUY");
        //}
        //else
        //{
        //    Console.WriteLine("Default");
        //}

        //switch (val)
        //{
        //    case "BCD":
        //        Console.WriteLine("BCD");
        //        break;
        //    case "ACD":
        //        Console.WriteLine("AUY");
        //        break;
        //    default:
        //        Console.WriteLine("Default");
        //        break;
        //}

        //bool condition1 = true;
        //bool condition2 = false;

        //if (condition1)
        //{
        //    Console.WriteLine("Print something");
        //}
        //else if(condition2)
        //{
        //    Console.WriteLine("Print something more");
        //}
        //else
        //{
        //    Console.WriteLine("Print something else");
        //}

        //Console.WriteLine("Enter number");
        //string num1str = Console.ReadLine();
        //Console.WriteLine("Enter number again");
        //string num2str = Console.ReadLine();
        //int num1 = Int32.Parse(num1str);
        //int num2 = Int32.Parse(num2str);
        //Console.WriteLine("Enter operationacter (*/%+-) to proceed the operation");
        //string operation = Console.ReadLine();

        ////bool invalidOperation = false;
        //int result = 0;

        //switch (operation) {
        //    case "+":
        //    result = num1 + num2;
        //        break;
        //    case "-":
        //    result = num1 - num2;
        //        break;
        //    case "*":
        //    result = num1 * num2;
        //        break;
        //    case "/":
        //    result = num1 / num2;
        //        break;
        //default:
        //    //invalidOperation = true;
        //    Console.WriteLine("Operation is not valid, please try again providing correct chatacter.");
        //    return;//exit the current method (program)
        //}
        ////if (!invalidOperation)
        //Console.WriteLine(num1 + operation + num2 + "=" + result);

        //DateOnly date = new DateOnly();
        //CultureInfo.CurrentCulture = new CultureInfo("en-GB");//recet the culture info for the program execution

        CultureInfo ci = new CultureInfo("en-GB");///date-format = dd/mm/yyyy

        DateOnly date;
        try
        {
            Console.WriteLine("Enter the date");
            date = DateOnly.Parse(Console.ReadLine(), ci);
        }
        catch
        {
            Console.WriteLine("Date is wrong, please, try again");
        }
        int day = date.Day;
        int month = date.Month;
        int year = date.Year;

        Console.WriteLine("Year : " + year + ", Month : " + month + ", Day : " + day);
        //Convert.ToDateTime(date, ci);
        //Console.WriteLine(date.Day + "." + date.Month + "." + date.Year);
        //CultureInfo culture = CultureInfo.CurrentCulture;
        //Console.WriteLine(culture.Name);

        //Console.InputEncoding = Encoding.UTF8;
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        //const char Capricorn = '\u2651';

        //Console.Write("Test " + Capricorn);


    }
}

using System.Text.RegularExpressions;

class StringsDemo
{
    public static void Main(string[] args)
    {
        //string str = null;
        //Console.WriteLine(str);

        //int[] arr = { 1, 2, 3 };
        //int[] arr2 = arr;//arr and arr2 both store the same array/object/reference

        //arr[1] = 7;
        //Console.WriteLine(arr2[1]);

        //bool stopInput = false;
        //string concatenation = "";
        //Console.WriteLine("Enter STOP to finish");
        //while (!stopInput)
        //{
        //    string value = Console.ReadLine();
        //    concatenation += value;// { 'A','B','C' } + { 'D','F','H' } = { 'A','B','C','D','F','H'}
        //    if (value == "STOP")
        //        stopInput = true;
        //}
        //Console.WriteLine("You entered " + concatenation);

        //string str = "A;BC;DE;T";
        //string[] arraySplit = str.Split(";");
        //foreach(string str2 in arraySplit)
        //    Console.WriteLine(str2);

        //12 45 87 90 ==> get integer array int[] arr = {12,45,87,90}



        //string str = "Here is the string\"";
        //Console.WriteLine(str.ToUpper());
        //string[] strArr = { "Element1", "Element2", "Element3" };
        //int[] intArr = { 1, 2, 3, 4, 5 };
        ////string concatString = String.Concat(strArr);
        //string concatString = String.Concat(intArr) + String.Concat(strArr);//"12345"
        //Console.WriteLine(concatString);
        //Console.WriteLine(concatString[4]);

        //string str1 = "ABC";
        //string str2 = "DEF";
        //string str3 = "ABCDEF";
        //string str4 = str1 + str2;

        //Console.WriteLine((str4 == str3));
        //Console.WriteLine(str4.Equals(str3));
        //Console.WriteLine(str4.IndexOf("c"));
        //Console.WriteLine(str4.Substring(3,2));

        //string str = null;
        //str.ToLower();//this will trigger null reference exception

        //string str = "My name is Arturs";
        ////string strReplaced = str.Replace("Arturs", "Janis");
        //string strReplaced = str.Replace('s', 'S');
        //Console.WriteLine(strReplaced);

        //string str = "My email is arturs.olekss@gmail.com";
        //string strReplaced = Regex.Replace(str, @"[\w\-\.]+@([\w\-]+\.)+[\w-]{2,4}", @"new.email@gmail.com");
        //Console.WriteLine(strReplaced);

        //Console.WriteLine("Please, enter your email");
        //string email = Console.ReadLine();
        //bool match = Regex.Match(email, @"^[\w\-\.]+@([\w\-]+\.)+[\w-]{2,4}$").Success;
        //if (match)
        //{
        //    Console.WriteLine("Email provided is correct");
        //    //(..){0,1}
        //}
        //else
        //{
        //    Console.WriteLine("Wrong email provided");
        //}

        Console.WriteLine("Please, enter your mobile phone number");
        string phoneNo = Console.ReadLine();
        bool matchLatvian = Regex.Match(phoneNo, @"^((\+371) {0,1}){0,1}2[0-9]{7}$").Success;
        bool matchLithuanian = Regex.Match(phoneNo, @"^((\+370) {0,1}){0,1}6[0-9]{7}$").Success;
        if (matchLatvian || matchLithuanian)
        {
            Console.WriteLine("Phone number provided is correct");
            //(..){0,1}
        }
        else
        { 
            Console.WriteLine("Wrong phone number provided");
        }


    }
}
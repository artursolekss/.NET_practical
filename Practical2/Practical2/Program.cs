class Practical2
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "World";
        int number = 2121;
        int number2 = 134;
        string strResult = str1 + " " + str2 + number;
        //string strNumberRes = number + number2; //not possible, because int + int = int
        string strNumberRes = str1 + (number + number2);
        Console.WriteLine(strNumberRes);
        //string strMinus = str1 - str2;//such operation isn't defined
        int modResult = 10 % 3;// 10 - 3 * [10 / 3] = 10 - 3 * 3 = 10 - 9 = 1
        int modResult2 = 16 % 7;// 16 - 7 * [16/7] = 16 - 7 * 2 = 16 - 14 = 2
        Console.WriteLine(modResult);
        Console.WriteLine(modResult2);
        ///797868686866564 % 100 --->> the result will be in the range of 0 to 99
    }

}

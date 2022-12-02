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

        string str = "A;BC;DE;T";
        string[] arraySplit = str.Split(";");
        foreach(string str2 in arraySplit)
            Console.WriteLine(str2);

        //12 45 87 90 ==> get integer array int[] arr = {12,45,87,90}

        Console.ReadLine();
    }
}
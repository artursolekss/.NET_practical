class Practical3
{

    static void Main(string[] args)
    {
        //Console.WriteLine(args[0]);
        //Console.WriteLine(args[1]);
        //Console.WriteLine(args[2]);
        //int[] arr = { 1, 2, 3 };
        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);
        //Console.WriteLine(arr[3]);

        //int[] arr = new int[3];
        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);
        //arr[0] = 1;
        //arr[1] = 2;
        //arr[2] = 3;
        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);

        //string[] arrstr = new string[2];
        //arrstr[0] = "Element1";
        //arrstr[1] = "Element2";

        //string[] arrstr2 = new string[2];
        //arrstr2[0] = "Element1";
        //arrstr2[1] = "Element2";

        //bool arraysEqual = false;

        //if (arrstr[0] == arrstr2[0]
        //    && arrstr[1] == arrstr2[1])
        //{
        //    arraysEqual = true;
        //}

        //arrstr[2] = "Element3";

        //Console.WriteLine(arraysEqual);

        //Array.Equals(arrstr, arrstr2);
        //bool compare = arrstr == arrstr2;
        //Console.WriteLine(compare);
        //Console.WriteLine();

        //string[] arrNewElement = new string[3];
        //arrNewElement[0] = arrstr[0];
        //arrNewElement[1] = arrstr[1];
        //arrNewElement[2] = "New Element";

        //int arraySize = Int32.Parse(Console.ReadLine());
        //string[] array = new string[arraySize];


        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Hello");
        //}


        ////bool correctSize = false;
        ///for(;!corretSize;){
        ///if(Int32.TryParse(.....) == true){
        ///correctSize = true;
        ///}
        ///}

        //var val = "Something";
        int arraySize = 0;
        bool arraySizeNotProvided = true;

        //for (; arraySizeNotProvided;)
        //for (;;)
        //while (true)
        //while (arraySizeNotProvided)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter the size of the array:");
        //        arraySize = Int32.Parse(Console.ReadLine());
        //        arraySizeNotProvided = false;
        //        //break;//goes out of the loop
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Number provided is not valid");
        //    }
        //}
        //string[] elements = new string[arraySize];

        //var valDouble = 6;

        //for (int i = 0; i < elements.Length; i++)
        ////for (int i = 0; i < arraySize; i++)//the same
        //{
        //    Console.WriteLine("Enter the element " + i);
        //    string element = Console.ReadLine();
        //    elements[i] = element;
        //}

        //int i = 0;
        //while(i < elements.Length)
        //{
        //    Console.WriteLine("Enter the element " + i);
        //    string element = Console.ReadLine();
        //    elements[i] = element;
        //    i++;
        //}


        //i = 0;
        //for (; i < elements.Length; i++)
        //{
        //    Console.WriteLine(elements[i]);
        //}

        bool arraySizeProvided = true;
        do
        {
            try
            {
                Console.WriteLine("Enter the size of the array:");
                arraySize = Int32.Parse(Console.ReadLine());
                //break;//goes out of the loop
                arraySizeProvided = true;
            }
            catch
            {
                Console.WriteLine("Number provided is not valid");
                arraySizeProvided = false;//point out to the error in catch
            }
        }
        while (!arraySizeProvided);//while condition will focus on the error
        string[] elements = new string[arraySize];

        for (int i = 0; i < arraySize; i++)//the same
        {
            Console.WriteLine("Enter the element " + i);
            string element = Console.ReadLine();
            elements[i] = element;
        }

        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }

}
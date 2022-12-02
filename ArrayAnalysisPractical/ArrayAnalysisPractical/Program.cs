
class ArrayAnalysisPractical
{


    public static void Main(string[] args)
    {
        int[] array = UserInput.EnterIntArray();
        ArrayAnalysis.PrintNegativeElements(array);
        ArrayAnalysis.PrintOddElements(array);
        ArrayAnalysis.VerifyDuplicate(array);
        ArrayAnalysis.PrintEachSecond(array);
        double average = ArrayAnalysis.ComputeAverage(array);
        ArrayAnalysis.ShowAverageValue(average);
        ArrayAnalysis.NoElementsSmallerthanAverage(array, average);
        
    }

}

class ArrayAnalysis
{

    public static void NoElementsSmallerthanAverage(int[] arr,double average)
    {
        int counter = 0;
        foreach (int element in arr)
            if (element < average)
                counter++;

        Console.WriteLine("Number of the elements smaller than the average value : " + counter);
    }

    public static void PrintEachSecond(int[] arr)
    {
        Console.Write("Each second element :");
        for(int i = 0; i < arr.Length; i += 2)
        {
            Console.Write(" " + arr[i]);
        }
        Console.Write("\n");
    }

    public static void ShowAverageValue(double average)
    {
        Console.WriteLine("Average value : " + average);
    }

    public static double ComputeAverage(int[] arr)
    {
        double average = 0;
        foreach (int number in arr)
            average += number;
        
        average /= arr.Length;//average = average / arr.Length // a += 2 <=> a = a + 2;   a -= 2 <=> a = a - 2; a /= 2 <=> a = a / 2;
        return average;
    }

    public static void VerifyDuplicate(int[] array)
    {
        //bool duplicatesFound = false;
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = i + 1; j < array.Length; j++)//x0 x1 x2 x3....xn
            {
                if (array[i] == array[j])
                {
                    //duplicatesFound = true;
                    Console.WriteLine("Duplicates found");
                    //break;
                    return;
                }
            }
        }

        //if (duplicatesFound)
            //Console.WriteLine("Duplicates found");
        //else
            Console.WriteLine("Duplicates not found");

        //For the sorted array
        //for(int i = 1; i < array.Length; i++)
        //{
        //    if(array[i] == array[i - 1])
        //    {
        //        Console.WriteLine("Duplicates found");
        //        return;
        //    }

        //}
        //Console.WriteLine("Duplicates not found");
    }

   public static void PrintNegativeElements(int[] arr)
    {
        //bool emptyLine = true;
        Console.Write("Negative elements :");
        foreach (int element in arr)
        {
            if (element < 0)
                //if (emptyLine) {
                //Console.Write(element);
                //emptyLine = false;
                //}
                //else
                Console.Write(" " + element);// -1 -5 -7  
        }
        Console.Write("\n");
    }

    public static void PrintOddElements(int[] arr)
    {
        int counter = 0;
        Console.Write("Odd elements :");
        foreach (int element in arr)//arraySize iterations
        {
            if (element % 2 != 0)
            {
                //if (Math.Abs((element % 2)) == 1)
                Console.Write(" " + element);// -1 -5 -7  
                counter++;
            }
        }
        Console.Write("\n");
        Console.WriteLine("Number of odd numbers : " + counter);
    }
}
class UserInput
{
    //define the functions needed for the Input user
    public static int EnterIntNumber()
    {
        int input = 0;
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

    public static int[] EnterIntArray()
    {
        Console.WriteLine("Enter the size of the array");
        int arraySize = EnterIntNumber();
        int[] array = new int[arraySize];

        for(int i = 0; i < arraySize; i++)
        {
            Console.WriteLine($"Enter element {i} of the array");//"Enter element " + i + " of the array" 
            array[i] = EnterIntNumber();
        }
        return array;
    }

}

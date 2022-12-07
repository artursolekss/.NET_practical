using System.Text;

class Algorithms
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array");
        string[] arrStr = Console.ReadLine().Split(" ");
        int[] arrInt = new int[arrStr.Length];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arrInt[i] = Convert.ToInt32(arrStr[i]);
        }
        //int[] arrSort = new int[arrInt.Length];

        //O(n) * O(n) * O(n) = O(n^3)
        //for (int i = 0; i < arrInt.Length; i++)//O(n)
        //{
        //    for (int j = 0; j < (i + 1); j++)//O(n)
        //    {
        //        //1 4 7 9 0 0
        //        if (i == j)//don't need to shift
        //        {
        //            arrSort[j] = arrInt[i];
        //        }
        //        else if (arrSort[j] > arrInt[i])
        //        {
        //            ShiftElements(arrSort, j, i); //O(n)
        //            arrSort[j] = arrInt[i];
        //            break;//break inner loop
        //        }

        //    }
        //}

        // 3 4 5 7 8 9
        // 

        //O(n) + O(n) + O(n) = O(n)
        //O(n) * O(n) = O(n^2)


        for(int i = 0; i < arrInt.Length; i++)//O(n)
        {
            for(int j = 1; j < arrInt.Length - i; j++)//O(n)
            {
                if (arrInt[j-1] < arrInt[j])
                {
                    int current = arrInt[j];
                    arrInt[j] = arrInt[j - 1];
                    arrInt[j - 1] = current;
                }
            }
        }

        Console.WriteLine(GetArrayAsString(arrInt));
    }

    public static string GetArrayAsString(int[] arr)
    {
        StringBuilder strBuild = new StringBuilder("");
        bool firstElement = true;
        foreach(int item in arr)
        {
            if (!firstElement)
                strBuild.Append(" ");
            else
                firstElement = false;
            strBuild.Append(item);
        }
        return strBuild.ToString();
    }

    public static void ShiftElements(int[] arr,int from,int to)
    {//1 2 3 4 _ _ _ _ --->> 1 2 _ 3 4 _ _ _
        int next = arr[from];
        arr[from] = 0;
        for (int i = from + 1; i < to + 1; i++)
        {
            int current = next;
            next = arr[i];
            arr[i] = current;
        }
    }

}
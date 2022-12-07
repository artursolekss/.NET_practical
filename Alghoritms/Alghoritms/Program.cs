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
        int[] arrSort = new int[arrInt.Length];
        for (int i = 0; i < arrInt.Length; i++)
        {
            if (i == 0)
            {
                arrSort[0] = arrInt[0];
            }
            for (int j = 1; j < (i + 1); j++)
            {
                if (i == j)//don't need to shift
                {
                    arrSort[j] = arrInt[i];
                }
                else if (arrSort[j] > arrInt[i])
                {
                    ShiftElements(arrSort, j, i);
                    arrSort[j] = arrInt[i];
                }

            }
        }
        Console.WriteLine(String.Concat(arrSort));

    }

    public static void ShiftElements(int[] arr,int from,int to)
    {//1 2 3 4 _ _ _ _ --->> 1 2 _ 3 4 _ _ _
        int next = arr[from];
        arr[from] = 0;
        for (int i = from + 1; i < to; i++)
        {
            int current = next;
            next = arr[i];
            arr[i] = current;
        }
    }

}
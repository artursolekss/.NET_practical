class Program
{
    public static void Main(string[] args)
    {
        //List<string> list2 = new List<string>();

        //Time complexity for search
        //Lists - O(n), we need to go through all the elements
        //of the collection

       
        //SortedSet
        //12 15 18 24 28 34 38 43 47 51

        


        SortedSet<string> list = new SortedSet<string>();

        list.Add("Element 11");
        list.Add("Element");//OK
        //list.Add(2121);//Not OK

        list.Add("Element 21");
        //list.RemoveAt(0);//removes the element at the position 0
        //list.Clear();//clears all the elements

        List<string> list2 = new List<string>();


        //list.ForEach(x => list2.Add(x));

        foreach (var x in list)
            list2.Add(x);

        foreach (var x in list)
            list2.Add(x);

        //foreach (var x in list2)
        //     Console.WriteLine(x);

        list2.ForEach(x =>
        {
            Console.WriteLine(x);
            Console.WriteLine(x);
        });

       
    }
}
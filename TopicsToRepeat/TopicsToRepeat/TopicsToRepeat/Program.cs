
class Program
{

    public static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Element1");
        list.Add("Element2");

        list.Add("Element3");
        list.Add("Element4");

        list.Add("Element5");
        list.Add("Element6");

        //for(int i=0;i<list.Count;i++) {
        //     if (list[i] == "Element4")
        //         Console.WriteLine("Element4 is located at position " + i);
        // }

        //foreach(var item in list)
        //{
        //    Console.WriteLine(item);
        //}

        //bool stop = false;
        //while (!stop)
        //while (true)
        //{
        //    var input = Console.ReadLine();
        //    if (input == "stop")
        //        //stop = true;
        //        break;//goes out of the loop
        //    else if (input == "next")
        //        continue;//go to the next iteration - everything below to be skipped
        //    Console.WriteLine("Print");

        //}
        //bool cond = false;
        //do
        //{
        //    var input = Console.ReadLine();
        //    if (input == "stop")
        //        //stop = true;
        //        break;//goes out of the loop
        //    else if (input == "next")
        //        continue;//go to the next iteration - everything below to be skipped
        //    Console.WriteLine("Print");
        //}
        //while (cond);

        List<string> copyList = new List<string>();
        list.ForEach( (x) => {
            copyList.Add(x);
        });
        copyList.ForEach(x=>Console.WriteLine(x));

    }

}
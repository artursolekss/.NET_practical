using System.Collections;

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


        //SortedSet<string> list = new SortedSet<string>();

        //list.Add("Element 11");
        //list.Add("Element");//OK
        ////list.Add(2121);//Not OK

        //list.Add("Element 21");
        ////list.RemoveAt(0);//removes the element at the position 0
        ////list.Clear();//clears all the elements

        //List<string> list2 = new List<string>();


        ////list.ForEach(x => list2.Add(x));

        //foreach (var x in list)
        //    list2.Add(x);

        //foreach (var x in list)
        //    list2.Add(x);

        ////foreach (var x in list2)
        ////     Console.WriteLine(x);

        //list2.ForEach(x =>
        //{
        //    Console.WriteLine(x);
        //    Console.WriteLine(x);
        //});
        //SortedList<int, string> persons = new SortedList<int, string>();

        //persons.Add(1, "Arturs");
        //persons.Add(2, "Janis");
        //persons.Add(3, "Jack");

        //foreach(var person in persons)
        //    Console.WriteLine("Key : " + person.Key 
        //        + "; Value : " + person.Value);

        //SortedList<Person,string> persons2 = new SortedList<Person, string>();

        //Person person1 = new Person();
        //person1.Name = "Arturs";
        //person1.LastName = "Olekss";

        //Person person2 = new Person();
        //person2.Name = "Jack";
        //person2.LastName = "Smith";

        //persons2.Add(person1, "person1");
        //persons2.Add(person2, "person2");

        //foreach (var person in persons2)
        //    Console.WriteLine("Key : " + person.Key
        //        + "; Value : " + person.Value);


        //Hashtable hashtable = new Hashtable();

        //hashtable.Add(1, "Element 1");
        //hashtable.Add(2, "Element 2");
        //hashtable.Add(3, "Element 3");
        //hashtable.Add(4, "Element 4");
        //hashtable.Add(5, "Element 5");
        //hashtable.Add(6, "Element 6");

        //foreach(var element in hashtable.Values)
        //    Console.WriteLine(element); 


        TestClass<string,int> myObj = new TestClass<string,int>();
        myObj.Value = "MyString";

        TestClass<int,string> myObj2 = new TestClass<int,string>();
        //myObj2.Value = "MyString"; NOK - the type T is int for 
        // this object
        myObj2.Value = 1234;

        //TestClass<int, MyRandomClass> test
        //= new TestClass<int, MyRandomClass>();//NOK - because MyRandomClass doesn't implement IComparable
    }

    class MyRandomClass
    {

    }

    class TestClass<T,V> where V: IComparable<V>
    {

        public T Value { get; set; }

    }

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            this.Name = "";
            this.LastName = "";
        }


       public int CompareTo(Person person)
        {
            string fullNameCurrent = this.Name + this.LastName;
            string fullNamePerson = person.Name + person.LastName;

          return fullNameCurrent.CompareTo(fullNamePerson);
        }


        public override string ToString()
        {
            return "Name : " + this.Name + ", Last Name : "
                + this.LastName;
        }
    }
}
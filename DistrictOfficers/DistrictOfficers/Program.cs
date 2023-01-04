using DistrictOfficers;

class Program
{
    public static void Main(String[] args)
    {
        //Officer officer = new Officer();
        //Program.PrintObjectInfo(officer);
        //Console.WriteLine(officer.Level);


        //District district1 = new District();
        //District district2 = new District();

        //float avgDistr1 = district1.AverageLevel;
        //float avgDistr2 = district2.AverageLevel;

        Officer officer1 = new Officer(
            "Jack","Sparrow","District 1",1,30);

        Officer officer2 = new Officer(
            "Mary", "Len", "District 1", 2, 25);

        Officer officer3 = new Officer(
            "Rayhan", "Luna", "District 2", 3, 73);

        Officer officer4 = new Officer(
            "Muhammad", "Downs", "District 2", 4, 65);

        Officer officer5 = new Officer(
            "Nia", "Gilmore", "District 3", 5, 85);

        Officer officer6 = new Officer(
            "Norman", "Blair", "District 3", 6, 55);

        Officer officer7 = new Officer(
            "Brenda", "Romero", "District 3", 7, 75);

        District district1 = new District("District 1",
            "Riga", 1);
        District district2 = new District("District 2",
            "Vilnus", 2);

        District district3 = new District("District 3",
            "Kaunas", 3);

        district1.AddNewOfficer(officer1);
        district1.AddNewOfficer(officer2);

        district2.AddNewOfficer(officer3);
        district2.AddNewOfficer(officer4);

        district3.AddNewOfficer(officer5);
        district3.AddNewOfficer(officer6);
        district3.AddNewOfficer(officer7);

        District.CompareDistricts(district1, district2);
        District.CompareDistricts(district1, district3);
        District.CompareDistricts(district2, district3);

        Console.WriteLine(district2.AverageLevel);
        Console.WriteLine(district3.AverageLevel);

        //Console.WriteLine(officer1);
        //Console.WriteLine(officer2);
        //Console.WriteLine(officer3);
        //Console.WriteLine(officer4);
        //Console.WriteLine(officer5);
        //Console.WriteLine(officer6);
        //Console.WriteLine(officer7);

        district3.PrintAllOfficers();
        district3.RemoveOfficer(officer6);
        Console.WriteLine("Officer removed");
        district3.PrintAllOfficers();
        district3.AddNewOfficer(officer6);
        Console.WriteLine("Officer added");
        district3.PrintAllOfficers();

        Officer officerN = new Officer();
        //district3.AddNewOfficer(officerN);
        officerN.OfficerId = 10;
        officerN.Name = "John";
        officerN.Surname = "McLay";
        officerN.CrimesSolved = 68;
        district3.AddNewOfficer(officerN);

        Console.WriteLine("Officer added");
        district3.PrintAllOfficers();
    }

    //public static void PrintObjectInfo(object obj)
    //{
    //    Console.WriteLine(obj);
    //}
}

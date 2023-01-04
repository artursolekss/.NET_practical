
namespace DistrictOfficers
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person() {
            this.Name = "";
            this.Surname = "";
        }

        public override string ToString()
        {
            return "Name : " + this.Name + "; Surname : "
                + this.Surname;
        }
    }
}

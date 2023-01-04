namespace DistrictOfficers
{
    public class Lawyer : Person
    {

        public int LawyerId
        {
            get;set;
        }

        public int HelpedInCrimesSolved { get; set; }
        public Lawyer()
        {

        }

        public Lawyer(string name,string surname,
            int lawyerId, int helpedInCrimesSolved):base(name,surname)
        {
            this.LawyerId = lawyerId;
            this.HelpedInCrimesSolved = helpedInCrimesSolved;
        }

        public override string ToString()
        {
            return base.ToString() + "Lawyer ID : "
                + this.LawyerId + "; Helped in Crimes Solved " 
                + this.HelpedInCrimesSolved;
        }

    }
}

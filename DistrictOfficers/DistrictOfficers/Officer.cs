using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DistrictOfficers
{
    public class Officer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int OfficerId { get; set; }
        public string WorkingDistrict { get; set; }
        public int CrimesSolved { get; set; }

        public Officer()
        {
            this.Name = "";
            this.Surname = "";
            this.WorkingDistrict = "";
        }

        public Officer(string name,string surname,string workingDistrict,
            int officerId,int crimesSolved)
        {
            this.Name = name;
            this.Surname = surname;
            this.OfficerId = officerId;
            this.WorkingDistrict = workingDistrict;
            this.CrimesSolved = crimesSolved;
        }

        public int CalculateLevel()
        {
            if (this.CrimesSolved < 20)
            {
                return 1;
            }
            else if (this.CrimesSolved > 20 
                && this.CrimesSolved < 40)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public int Level
        {
            get
            {
                return this.CalculateLevel();
            }
        }

        public override string ToString()
        {
            string details = "Name: " + this.Name + " ; " +
                "Surname: " + this.Surname + " ; " +
                "OfficerID: " + this.OfficerId
             + " ; " + " Crimes solved: " + this.CrimesSolved + "\n";
            return details;
        }


    }
}

using System.Collections;

namespace DistrictOfficers
{
    class District
    {

        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictId { get; set; }

        private List<Officer> officersInDistrict;
        //private ArrayList officersInDistrict;

        public District()
        {
            this.officersInDistrict = new List<Officer>();
        }

        public District(string title, string city, int districtId)
        {
            Title = title;
            City = city;
            DistrictId = districtId;
            this.officersInDistrict = new List<Officer>();
        }

        public bool AddNewOfficer(Officer officer)
        {
            this.officersInDistrict.Add(officer);
            return true;
        }

        public bool RemoveOfficer(Officer officer)
        {
            //foreach(Officer ofc in this.officersInDistrict)
            //{

            //}

            //for (int i = 0; i < this.officersInDistrict.Count; i++)
            //{
            //    if (this.officersInDistrict[i] == officer)
            //    {
            //        this.officersInDistrict.RemoveAt(i);
            //        break;
            //    }
            //}

            this.officersInDistrict.Remove(officer);//searches for the 
            //corresponding officer in the list and removes it from the list
            //(if it is found)

            return true;
        }

        public int Compare(District district)
        {
            float avrgDist1 = this.AverageLevel;
            float avrgDist2 = district.AverageLevel;

            if (avrgDist1 > avrgDist2)
                return 1;
            else if (avrgDist2 > avrgDist1)
                return -1;
            else
                return 0;
        }


        public static void CompareDistricts(District district1,
            District district2)
        {
            float avrgDist1 = district1.AverageLevel;
            float avrgDist2 = district2.AverageLevel;
            if (avrgDist1 > avrgDist2)
                Console.WriteLine("District 1 is better than District 2");
            else if (avrgDist1 < avrgDist2)
                Console.WriteLine("District 2 is better than District 1");
            else
                Console.WriteLine("The average level of both districts is the same");  

        }

        public static float CalculateAverageLvl(District district1,
            District district2)
        {
            return (district1.AverageLevel + district2.AverageLevel) / 2;
        } 

        public float AverageLevel
        {
            get
            {
                if (this.officersInDistrict.Count == 0)
                    return -1;

                float levelSum = 0;
                foreach(Officer officer in this.officersInDistrict)
                {
                    levelSum += officer.Level;
                }
                return levelSum / this.officersInDistrict.Count;

            }
        }


    }
}

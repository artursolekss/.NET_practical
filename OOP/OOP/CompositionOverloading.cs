using System;

namespace OOP
{

    class Shape
    {

        public double CalculatePerimeter(double[] sides)
        {
            double sum = 0;
            foreach (var side in sides)
                sum += side;

            return sum;
        }
        public double CalculatePerimeter(double a)
        {
            return a;
        }

        public double CalculatePerimeter(double a,double b)
        {
            return this.CalculatePerimeter(a) + b;
        }

        public double CalculatePerimeter(double a, double b,double c)
        {
            return this.CalculatePerimeter(a,b) + c;//enhanced logic
        }

        public double CalculatePerimeter(double a, double b, double c,double d)
        {
            return a + b + c + d;
        }

    }

    class CompositionOverloading
    {
        //private Date date;//example of compostion
        //private CompositionOverloading obj1;
        string[] names;

        public string this[char indx]
        {
            get {

                int i = this.GetCharMap(indx);
                return this.names[i]; 
            }
            set {
                int i = this.GetCharMap(indx);
                this.names[i] = value;
            }
        }

        public override string ToString()//overriding
        {
            return "Abcd";
        }

        public string ToString(string text)//overloading
        {
            return text; ;
        }


        public int GetCharMap(char c)
        {
            int i;
            switch (c)
            {
                case 'A':
                    i = 0;
                    break;
                case 'B':
                    i = 1;
                    break;
                case 'C':
                    i = 2;
                    break;
                default:
                    i = -1;
                    break;
            }
            return i;
        }

        public void Test()
        {
            names[0] = "Text";
        }

        public CompositionOverloading(int size)
        {
            this.names = new string[size];
        }

    }

    class ImprovedArray
    {
        string[] arr = new string[0];

        public string this[int i]
        {
            get { return this.arr[i]; }
            set
            {
               if(i < this.arr.Length)
                    this.arr[i] = value;
                else
                {
                    string[] arrL = new string[i + 1];
                    //Array.Copy(this.arr, arrL,this.arr.Length);
                    for(int j=0;j< this.arr.Length; j++)
                    {
                        arrL[j] = this.arr[j];
                    }
                    this.arr = arrL;
                    //arrL[i] = value; --same, because at this point they both have the same reference assigned
                    this.arr[i] = value;
                    
                }

            }

        }

        public int Length
        {
            get { return this.arr.Length; }
        }

    }
}



namespace Abstraction
{

    public interface IMovable
    {

        protected int Value { get; set; }//this must be implemented in the class
        void Move(int val)
        {
            this.Value = val;
        }

        void SameMethod1()
        {
            Console.WriteLine("Default implementation 2");
        }


    }

    public interface IAlive
    {
        int Age { get; set; }

        void SameMethod1()
        {
            Console.WriteLine("Default implementation 1");
        }
    }
}

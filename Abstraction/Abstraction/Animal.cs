namespace Abstraction
{
    public abstract class Animal : IMovable, IAlive
    {

        protected int age;//

        public int Value { get; set; }

        public int Age { get { return this.age; }
            set { this.age = value; } }
        public string Name
        {
            get; set;
        }

        public abstract void Move();

    }

    //AnotherAbstract.Something();
    public abstract class AnotherAbstract : Animal
    {
        //not mandatory, but you can implement the abstract methods
        //inherited from the super-class
        //public override void Move()
        //{
        //    Console.WriteLine("The method is implemented");
        //}
        public abstract void AnotherAbstractMethod();

        public static void Something()
        {
            //
        }
    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The dog is moving");
        }
    }

    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The cat is moving");
        }
    }
}

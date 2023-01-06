using Abstraction;

class Program
{

    public static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Move();
        cat.Name = "Jack";

        Dog dog = new Dog();
        dog.Move();
        dog.Name = "Jesicca";

        //Animal animal = new Animal();//not possible, because
        //// the abstract classes can't be instatiated


        //Casting rules when using the abstract classes
        //are totaly the same

        Animal animal = cat;//up-casting
        animal.Move();

        animal = dog;//up-casting
        animal.Move();

        SoMethod(dog);//up-casting
        SoMethod(cat);//up-casting
        SoMethod(animal);

        dog = (Dog)animal;//down-casting
        //cat = (Cat)animal;//cast exception, because animal
        //variable stores the Dog object,
        //not the Cat object

        if(animal is Cat)
            cat = (Cat)animal;

        IMovable movable = animal;
        movable.Move(10);

        IAlive aliveObject = cat;
        aliveObject.Age = 13;

        movable.SameMethod1();
        aliveObject.SameMethod1();

    }


    public static void AnotherMethod(IMovable obj)
    {
        //do someting to the obj
        //use (call) all the properties and methods from
        //IMovable interface
    }
    public static void SoMethod(Animal obj)
    {
        //use obj in this method
    }


}
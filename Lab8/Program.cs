namespace Lab8;
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.animalSound();

        Animal myCat = new Cat();
        Animal myDog = new Dog();
        myCat.animalSound();
        myDog.animalSound();
    }
}

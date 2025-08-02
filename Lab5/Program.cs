using System;

// Step 1 - Create a Base Class
class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
// Step 2 - Derived class: Cat and Dog
class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says:bow wow");
    }
}

//Step 3 - Test in Main
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.AnimalSound(); 
        myCat.AnimalSound();
        myDog.AnimalSound();

    }
}
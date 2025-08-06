using System;


public class Animal
{
    
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound.");
    }
}


public class Dog : Animal
{
    
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}

// Derived class Cat
public class Cat : Animal
{
   
    public override void MakeSound()
    {
        Console.WriteLine("Meow.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Inheritance and Method Overriding ---");
        
    
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

      
        myAnimal.MakeSound(); 
        myDog.MakeSound();   
        myCat.MakeSound();    
    }
}
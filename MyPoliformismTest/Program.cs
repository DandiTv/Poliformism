// See https://aka.ms/new-console-template for more information

// Create an array of Animal objects

using DefaultNamespace;

Animal[] animals = new Animal[3];

Animal animal1 = new Dog();
Animal animal2 = new Cat();
Animal animal3 = new Cow();

animals[0] = animal1;
animals[1] = animal2;
animals[2] = animal3;

// Demonstrate polymorphism
foreach (Animal animal in animals)
{
    animal.MakeSound();
}
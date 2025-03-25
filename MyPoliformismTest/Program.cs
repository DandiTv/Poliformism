// See https://aka.ms/new-console-template for more information

// Create an array of Animal objects

using MypoliformismTest;

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
//Upcasting is an operation that creates a base class reference from a subclass reference. (subclass -> superclass) (i.e. Manager -> Employee)
//downcasting is an operation that creates a subclass reference from a base class reference. (superclass -> subclass) (i.e. Employee -> Manager)


//Upcasting
Dog myDog = new Dog();
Animal myAnimal = new Dog();
Console.WriteLine("Downcast Animal to Dog");
myAnimal.MakeSound();

animal1 = myDog;




//Downcasting
Cat myCat = new Cat();
Animal downcastAnimal = myCat as Cat;
downcastAnimal.MakeSound();


Cat myCat2 = new Cat();
if (myCat2 is Animal )
{
    Animal downcastAnimal2 = (Animal)myCat2;
    downcastAnimal2.MakeSound();
    
}
else
{
    myCat2.MakeSound();
}
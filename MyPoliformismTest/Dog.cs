namespace MypoliformismTest;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
    public override void GetGenere()
    {
        Console.WriteLine("The dog's genere.");
    }
}
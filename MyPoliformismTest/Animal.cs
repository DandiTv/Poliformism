namespace MypoliformismTest;
//base class
public abstract class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }

    public abstract void GetGenere();
}
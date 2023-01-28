using System;
public class GetValue
{
    public string name { get; } = "Bat";
}
class RandomNumber
{
    private string ran;
    public RandomNumber()
    {
        
    }
    static void MyMethod(string myString)
            {
                Random rnd = new Random();
                int rndNum = rnd.Next(1, 100);
                Console.WriteLine(rndNum + myString);
            }
    static void Main(string[] args)
    { 
        MyMethod("Ananya");
        GetValue val = new GetValue();
        Console.WriteLine(val.name);
    }
}
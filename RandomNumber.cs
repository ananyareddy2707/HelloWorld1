using System;
class RandomNumber
{
    private string name;

    //parameterized constructor 
    public RandomNumber (string userName)
    {
        name = userName;
    }
    static void MyMethod(string user)
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(1, 100);
        Console.WriteLine (rndNum + user);
    } 
    static void Main(string[] args)
    {
        RandomNumber rndNum = new RandomNumber("Ananyaa");
        MyMethod(rndNum.name);
    }
}


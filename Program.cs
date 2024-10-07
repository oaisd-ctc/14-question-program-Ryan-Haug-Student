using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Whats your name?");
        string name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        int agePlus = age + 5;

        Console.WriteLine("What color are your eyes?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What size shoe do you wear?");
        string shoeSize = Console.ReadLine();

        Console.WriteLine("Whats your favorite color?");
        string color = Console.ReadLine();

        Console.WriteLine("Whats your favorite Tv show or movie?");
        string media = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string teacher = Console.ReadLine();

        Console.WriteLine("Whats your favorite class?");
        string fclass = Console.ReadLine();

        Console.WriteLine("Whats your favorite holiday");
        string holiday = Console.ReadLine();

        Console.WriteLine("Whats your favorite season?");
        string season = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string job = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();

        Console.WriteLine("My friends name is: " + name + ". "+ 
        name + " is " + age + " Years old. " + 
        name + "'s eye color is " + eyeColor + ". " +
        name + "'s shoe size is " + shoeSize + ". " + 
        name + "'s favorite color is " + color + ". " + 
        name + "'s favorite show or movie is " + media + ". " +
        name + "'s favorite teacher is " + teacher + ". " +
        name + "'s favorite class is " + fclass + ". " + 
        name + "'s favorite holiday is " + holiday + ". " +
        name + "'s favorite season is " + season + ". " +
        name + "'s dream job is " + job + ". " +
        name + " will be " + agePlus + " in 5 years. " +
        name + " has " + siblings + " siblings.");



    }
}
using System;

public class Program
{

    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;
    static int ageIn5Years;


    public static void Main(string[] args)
    {
        Console.Clear();

        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();


    }
    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }

    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        age = Console.ReadLine();
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What color are your eyes?");
        eyeColor = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair?");
        hairColor = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What size shoe do you wear?");
        shoeSize = Console.ReadLine();
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("Whats your favorite color?");
        favoriteColor = Console.ReadLine();
    }

    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("Whats your favorite Tv show or movie?");
        favoriteTVorMovie = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("Whats your favorite class?");
        favoriteClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("Whats your favorite holiday");
        favoriteHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("Whats your favorite season?");
        favoriteSeason = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(string age)
    {
        ageIn5Years = int.Parse(age) + 5;
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {
        Console.WriteLine($"Users name is {name}, {name} is {age} years old, {name} has {eyeColor} eyes, {name} has {hairColor} hair, {name}'s shoe size is {shoeSize}, {name}'s favorite color is {favoriteColor}, {name}'s favorite tv or movie is {favoriteTVorMovie}, {name}'s favorite teacher is {favoriteTeacher}, {name}'s favorite class is {favoriteClass}, {name}'s favorite holiday is {favoriteHoliday}, {name}'s favorite season is {favoriteSeason}, {name}'s dream job is {dreamJob}, {name} has {numberOfSiblings} siblings, {name} will be {ageIn5Years} old in 5 years.");
    }
}
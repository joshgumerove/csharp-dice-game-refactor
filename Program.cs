﻿
var random = new Random();
var diceRollResult = random.Next(1, 7);

Console.WriteLine($"What is value {diceRollResult}");
Console.ReadKey();

public class GeussingGame
{
    private const int InitialTries = 3;
    private readonly Dice _dice;

    public GeussingGame(Dice dice)
    {
        _dice = dice;
    }

    public void Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");
        var triesLeft = InitialTries;

        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");
            --triesLeft;
        }
    }


}

static public class ConsoleReader
{
    static public int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out result));

        return result;
    }
}

public class Dice
{
    private const int sidesCount = 6;
    private readonly Random _random;

    public Dice(Random random)
    {
        _random = random;
    }


    public int Roll() => _random.Next(1, sidesCount + 1);

}
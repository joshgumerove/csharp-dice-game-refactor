
//var random = new Random();
//var dice = new Dice(random);
//var guessingGame = new GeussingGame(dice);

//guessingGame.Play();

Season firstSeason = Season.Spring;
int firstSeasonAsNumber = (int)firstSeason;

Season lastSeason = Season.Winter;
int lastSeasonAsNumber = (int)lastSeason;

Console.WriteLine($"What is firstSeason: {firstSeason}");
Console.WriteLine($"What is firstSeasonAsNumber: {firstSeasonAsNumber}");

Console.WriteLine($"What is lastSeason: {lastSeason}");
Console.WriteLine($"What is lastSeasonAsNumber: {lastSeasonAsNumber}");

Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Fall,
    Winter
}

public class GeussingGame
{
    private const int InitialTries = 3;
    private readonly Dice _dice;

    public GeussingGame(Dice dice)
    {
        _dice = dice;
    }

    public bool Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");
        var triesLeft = InitialTries;

        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");
            if(guess == diceRollResult)
            {
                Console.WriteLine("You win");
                return true;
            }
            Console.WriteLine("Wrong Number.");
            --triesLeft;
        }
        return false;
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
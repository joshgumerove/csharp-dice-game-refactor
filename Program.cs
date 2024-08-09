var random = new Random();
var diceRollResult = random.Next(1, 7);

Console.WriteLine($"What is value {diceRollResult}");
Console.ReadKey();

class Dice
{
    private Random _random;
}
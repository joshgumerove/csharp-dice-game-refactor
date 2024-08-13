namespace DiceGameRefactor.Game
{
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGameRefactor.UserCommunication;

namespace DiceGameRefactor.Game
{
    public class GeussingGame
    {
        private const int InitialTries = 3;
        private readonly Dice _dice;



        public GeussingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");
            var triesLeft = InitialTries;

            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong Number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        static public void PrintResult(GameResult result)
        {
            string message = result == GameResult.Victory ? "You Win" : "You Lose";
            Console.WriteLine(message);

        }


    }
}

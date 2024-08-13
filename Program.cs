using DiceGameRefactor.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GeussingGame(dice);

GameResult gameResult = guessingGame.Play();

GeussingGame.PrintResult(gameResult);

Console.ReadKey();


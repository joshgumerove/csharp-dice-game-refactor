namespace DiceGameRefactor.UserCommunication
{
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
}

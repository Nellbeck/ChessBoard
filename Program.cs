using System.Net.Security;

/*
 * Fredrik Nellbeck
 * .NET23_OOP
 * Systemutveckling.NET med AI-kompetens
*/
namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Just a line of code to make the chessboard appear.
            Console.WriteLine("Skriv in en siffra för hur stort shackbräde du vill ha:"); // Asks the user to typ in an number so the program knows how big chessboard it will make.
            int Number; // Declares an variable

            while (true)
            {
                try
                {
                    Number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Använd bara siffror.");
                }
            } // Checks so the user only use digits so the program won't crash.

            int[] ANumber = new int[Number]; // Creates an array.

            Console.WriteLine("Hur ska de svarta rutorna se ut?");

            string userInputBlack = Console.ReadLine(); // Asks the user how the black chessboard tiles should look like.

            Console.WriteLine("Hur ska de vita rutorna se ut?");

            string userInputWhite = Console.ReadLine(); // Asks the user how the white chessboard tiles should look like.


            for (int LoopNumber = 0; LoopNumber < ANumber.Length; LoopNumber++)
            {
                for (int ArrayNumber = 0; ArrayNumber < ANumber.Length; ArrayNumber++)
                {
                    if (ArrayNumber % 2 == LoopNumber % 2)
                    {
                        Console.Write(userInputBlack);
                    }
                    else
                    {
                        Console.Write(userInputWhite);
                    }
                } // Nestled for-loop that creates the number of tiles the user put in.
                Console.WriteLine();
            }
        }
    }
}
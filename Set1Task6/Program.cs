using System;

namespace Set1Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int player1 = dice.Next(1,7);
            int player2 = dice.Next(1,7);
            int player3 = dice.Next(1, 7);
            int player4 = dice.Next(1, 7);
            int player5 = dice.Next(1, 7);

            Console.WriteLine("Player 1: " + player1);
            Console.WriteLine("Player 2: " + player2);
            Console.WriteLine("Player 3: " + player3);
            Console.WriteLine("Player 4: " + player4);
            Console.WriteLine("Player 5: " + player5);

            if ((player1 == player2)|| (player1 == player3)|| (player1 == player4)|| (player1 == player5))
            {
                Console.WriteLine("Player1 won the game and moved to next level");
            }
            else
            {
                Console.WriteLine("Player1 didnt move to the next level");
            }
            if ((player2 == player1) || (player2 == player3) || (player2 == player4) || (player2 == player5))
            {
                Console.WriteLine("Player2 won the game and moved to next level");
            }
            else
            {
                Console.WriteLine("Player2 didnt move to the next level");
            }
            if ((player3 == player1) || (player3 == player2) || (player3 == player4) || (player3 == player5))
            {
                Console.WriteLine("Player3 won the game and moved to next level");
            }
            else
            {
                Console.WriteLine("Player3 didnt move to the next level");
            }
            if ((player4 == player1) || (player4 == player2) || (player4 == player3) || (player4 == player5))
            {
                Console.WriteLine("Player4 won the game and moved to next level");
            }
            else
            {
                Console.WriteLine("Player4 didnt move to the next level");
            }
            if ((player5 == player1) || (player5 == player2) || (player5 == player3) || (player5 == player4))
            {
                Console.WriteLine("Player5 won the game and moved to next level");
            }
            else
            {
                Console.WriteLine("Player5 didnt move to the next level");
            }
        }
    }
}

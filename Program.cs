using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
			while (g.Play() ) {}
        }
    }
	
	class Game
	{
		Random rnd = new Random();
		string [] weapons = {"Rock","Paper","Scissors"};
		string [] weaponsWins = {"Scissors","Rock","Paper"};
		string [] outcomeMsg = {"It is a tie !!!", "You Won !!!","Computer Won !!!"};
		
		public Game()
		{
			
		}
		
		// Show menu choices for player
		private void ShowMenu()
		{
			Console.WriteLine("1) Rock");
			Console.WriteLine("2) Paper");
			Console.WriteLine("3) Scissors");
			
		}
		
		// Ask player for a selection 'Rock - paper - Scissors
		private int PlayerSelection()
		{
			Console.Write("Select your weapon: ");
			return int.Parse(Console.ReadLine())-1;
		}

		// Computer random selection
		private int ComputerSelection()
		{
			return rnd.Next(3);
		}
		
		// find out who wins 
		private int FindWinner(int player, int computer)
		{
			if (player == computer) {
				return 0;
			} else if (weaponsWins[player] == weapons[computer]) {
				return 1;
			} else {
				return 2;
			}
			
		}
		
		// play again mesage
		private bool PlayAgain()
		{
			Console.Write("Play again : [y/n]");
			string k = Console.ReadLine();
			return ((k=="y") || (k=="Y"));
		}
		
		
		// play game
		public bool Play()
		{
			ShowMenu();
			
			int player = PlayerSelection();
			int computer = ComputerSelection();
			int winner = FindWinner(player, computer);
			
			Console.WriteLine("your weapon is {0:G}", weapons[player]);
			Console.WriteLine("computer weapon is {0:G}", weapons[computer]);
			Console.WriteLine(outcomeMsg[winner]);
			
			return PlayAgain();
			
		}
	}
}

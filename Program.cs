using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
			while (g.play() ) {}
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
		private void showMenu()
		{
			Console.WriteLine("1) Rock");
			Console.WriteLine("2) Paper");
			Console.WriteLine("3) Scissors");
			
		}
		
		// Ask player for a selection 'Rock - paper - Scissors
		private int UserSelection()
		{
			Console.Write("Select your weapon: ");
			return int.Parse(Console.ReadLine())-1;
		}

		// Computer random selection
		private int aiSelection()
		{
			return rnd.Next(3);
		}
		
		// find out who wins 
		private int findWinner(int player, int computer)
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
		private bool playAgain()
		{
			Console.Write("Play again : [y/n]");
			string k = Console.ReadLine();
			return ((k=="y") || (k=="Y"));
		}
		
		// return paper - rock - scissors string based on index 0,1,2
		private string weapon(int w)
		{
			return weapons[w];
		}
		
		// play game
		public bool play()
		{
			showMenu();
			
			int player = UserSelection();
			int computer = aiSelection();
			int winner = findWinner(player, computer);
			
			Console.WriteLine("your weapon is {0:G}", weapon(player));
			Console.WriteLine("computer weapon is {0:G}", weapon(computer));
			Console.WriteLine(outcomeMsg[winner]);
			
			return playAgain();
			
		}
	}
}

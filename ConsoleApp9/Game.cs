using System;

namespace ConsoleApp9
{
    public class Game
    {
        private static Game _instance = null;
        public static Game Instance => _instance ?? (_instance = new Game());

        public Player[] Players { get; }
        private Board _board;


        public Game()
        {
            Players = new Player[]
            {
                new Player("Per"),
                new Player("Pål"),
                new Player("Espen"),
            };
            _board = new Board();
        }

        public void Run()
        {
            while (true)
            {
                foreach (var player in Players)
                {
                    try
                    {
                        DoGetSoldiers(player);
                        DoAttacks();
                        DoMovements();
                    }
                    catch (GameWonException g)
                    {
                        Console.WriteLine($"Spillet er over. Vinneren er {g.Player.Name}.");
                        return;
                    }
                }

            }
        }

        private void DoGetSoldiers(Player player)
        {
            var countryCount = _board.CountCountries(player);
            
            var newSoldiers = countryCount * 3;
            // ..
        }

        private void DoAttacks()
        {
        }

        private void DoMovements()
        {
        }
    }
}

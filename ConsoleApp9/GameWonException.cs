using System;

namespace ConsoleApp9
{
    public class GameWonException : ApplicationException
    {
        public Player Player { get; }

        public GameWonException(Player player)
        {
            Player = player;
        }
    }
}

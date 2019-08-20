using System.Linq;

namespace ConsoleApp9
{
    public class Board
    {
        private Country[] _countries;

        public Board()
        {
            var a = new Country("A");
            var b = new Country("B");
            var c = new Country("C");
            var d = new Country("D");
            var e = new Country("E");
            a.AddBorderingLocation(b);
            a.AddBorderingLocation(e);
            b.AddBorderingLocation(e);
            b.AddBorderingLocation(c);
            b.AddBorderingLocation(d);
            c.AddBorderingLocation(d);

            var players = Game.Instance.Players;
            a.Owner = players[0];
            b.Owner = players[0];
            c.Owner = players[1];
            d.Owner = players[1];
            e.Owner = players[2];
            a.SoldierCount = 15;
            b.SoldierCount = 15;
            c.SoldierCount = 15;
            d.SoldierCount = 15;
            e.SoldierCount = 30;

            _countries = new Country[] { a, b, c, d, e };
        }

        public int CountCountries(Player player)
        {
            //var count = 0;
            //foreach (var country in _countries)
            //{
            //    if (country.Owner == player) count++;
            //}
            //return count;
            var count = _countries.Count(c => c.Owner == player);
            if (count == _countries.Length) throw new GameWonException(player);
            return count;
        }
    }
}

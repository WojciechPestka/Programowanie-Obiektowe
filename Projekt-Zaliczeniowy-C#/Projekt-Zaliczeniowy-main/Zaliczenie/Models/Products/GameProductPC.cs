using System.Security.AccessControl;
using Zaliczenie.Types;

namespace Zaliczenie.Models
{
    public class GameProductPC : Product
    {
        public GameProductPC(string name, float price, DateTime expirationDate, GameTypePC gameType) : base(name, price)
        {
            Name = name;
            Price = price;
            RealaseDate = expirationDate;
            GameTypePc = gameType;
        }

        public DateTime RealaseDate { get; }
        public GameTypePC GameTypePc { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Realase date: {RealaseDate}, Game type: { GameTypePc}");
        }
    }
}

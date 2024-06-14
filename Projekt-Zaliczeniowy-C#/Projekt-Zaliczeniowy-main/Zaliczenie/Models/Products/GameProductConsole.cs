using Zaliczenie.Types;

namespace Zaliczenie.Models.Products
{
    public class GameProductConsole : Product
    {
        public GameProductConsole(string name, float price, GameTypeConsole gameType) : base(name, price)
        {
            Name = name;
            Price = price;
            GameType = gameType;
        }

        public GameTypeConsole GameType { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Game type: {GameType}");
        }
    }
}
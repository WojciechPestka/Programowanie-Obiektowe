using Zaliczenie.Models;
using Zaliczenie.Models.Products;
using Zaliczenie.Types;

namespace Zaliczenie.Extensions
{
    public static class ItemsExtensions
    {
        public static void MockStock(this Items item)
        {
            item.Electronics = new Models.Categories.ElectronicCategory()
            {
                Products = new List<Models.Product>
                {
                    new ComputerProduct("G4M3R HERO i5-12400F/16GB/1TB/RTX3060", 6000, Types.ComputerType.PC),
                    new ComputerProduct("Lenovo Legion 5-15 Ryzen 7 5800H/16GB/512/Win11 RTX3060", 6099, Types.ComputerType.Laptop),
                    new ComputerProduct("HP Victus 15 i5-12450H/16GB/512 RTX3050", 3699.99f, Types.ComputerType.Laptop),
                    new HeadphoneProduct("Logitech G PRO X GAMING HEADSET", 500, false),
                    new HeadphoneProduct("SPC Gear VIRO Plus USB", 215, false),
                    new HeadphoneProduct("JBL Tune 510BT", 190, true)
                }
            };
            item.Games = new Models.Categories.GameCategory()
            {
                Products = new List<Models.Product>
                {
                    new GameProductPC("Europa Universalis IV", 150, new DateTime(2013, 08, 13, 15, 0, 0, 0), Types.GameTypePC.RTS),
                    new GameProductPC("Galaxy Life", 1, new DateTime(2022, 10, 11, 15, 0, 0, 0), Types.GameTypePC.RTS),
                    new GameProductPC("theForest", 120, new DateTime(2014, 10, 11, 15, 0, 0, 0), Types.GameTypePC.Survival),

                    new GameProductConsole("Darkest Dungeon", 100, Types.GameTypeConsole.RougeLike),
                    new GameProductConsole("Battlefield 1", 150, Types.GameTypeConsole.FPS),
                    new GameProductConsole("God of War", 250, Types.GameTypeConsole.AAA),

                }
            };
        }
    }
}
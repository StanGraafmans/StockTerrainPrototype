using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceLibrary;

namespace StockTerrainPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stock Terrain Prototype";
            Console.SetWindowSize(140, 60);

            Console.WriteLine("\nPlease enter stock exchange X: ");
            string exchangeX = Console.ReadLine();

            Console.WriteLine("\nPlease enter ticker X: ");
            string tickerX = Console.ReadLine();

            Console.WriteLine("\nPlease enter start year X: ");
            int startX = -1;
            while (!int.TryParse(Console.ReadLine(), out startX))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter start year X: ");
            }

            Console.WriteLine("\nPlease enter end year X: ");
            int endX = -1;
            while (!int.TryParse(Console.ReadLine(), out endX))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter end year X: ");
            }

            Console.WriteLine("\n\nPlease enter stock exchange Y: ");
            string exchangeY = Console.ReadLine();

            Console.WriteLine("\nPlease enter ticker Y: ");
            string tickerY = Console.ReadLine();

            Console.WriteLine("\nPlease enter start year Y: ");
            int startY = -1;
            while (!int.TryParse(Console.ReadLine(), out startY))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter start year Y: ");
            }

            Console.WriteLine("\nPlease enter end year Y: ");
            int endY = -1;
            while (!int.TryParse(Console.ReadLine(), out endY))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter end year Y: ");
            }

            Console.WriteLine("\n\nPlease enter the grid width: ");
            int width = -1;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter the grid width: ");
            }

            Console.WriteLine("\nPlease enter the grid height: ");
            int height = -1;
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("\nYour input was not a numeric value. Please enter the grid height: ");
            }

            Console.WriteLine();
            Console.WriteLine();

            if (startX != -1 && endX != -1 && startY != -1 && endY != -1)
            {
                StockTerrain terrain = new StockTerrain
                (
                    Finance.GetHistoricalData(exchangeX, tickerX, startX, endX),
                    Finance.GetHistoricalData(exchangeY, tickerY, startY, endY),
                    width,
                    height
                );

                terrain.Show();
            }

            Console.ReadKey();
        }
    }
}

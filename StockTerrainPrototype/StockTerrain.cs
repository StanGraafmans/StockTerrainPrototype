using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceLibrary;

namespace StockTerrainPrototype
{
	public class StockTerrain
	{
		private HistoricalData[] _axisX;
		private HistoricalData[] _axisY;

		private int _width;
		private int _height;

		public StockTerrain(HistoricalData[] x, HistoricalData[] y, int width, int height)
		{
			_axisX = x;
			_axisY = y;

			_width = width;
			_height = height;
		}

		public void Show()
		{
			if (_axisX.Length == 0 || _axisY.Length == 0)
			{
				if (_axisX.Length <= 0)
				{
					Console.WriteLine("Found no historical data for stock X with the given parameters!");
				}

				if (_axisY.Length <= 0)
				{
					Console.WriteLine("Found no historical data for stock Y with the given parameters!");
				}

				return;
			}

			Console.WriteLine($"X: { _axisX[0].Exchange }:{ _axisX[0].Ticker }");
			Console.WriteLine($"Y: { _axisY[0].Exchange }:{ _axisY[0].Ticker }\n");

			int lenX = _axisX.Length;
			int lenY = _axisY.Length;

			Console.WriteLine($"Actual Width: { lenX }");
			Console.WriteLine($"Actual Height: { lenY }\n");

			for (float y = 0; y < _height; y++)
			{
				for (float x = 0; x < _width; x++)
				{
					float closeX = float.Parse(_axisX[(int) ((lenX / _width) * x)].Close);
					float closeY = float.Parse(_axisY[(int) ((lenY / _height) * y)].Close);

					int average = (int) ((closeX + closeY) / 2);

					Console.Write($"{ average.ToString() } ");
				}

				Console.WriteLine();
			}
		}
	}
}

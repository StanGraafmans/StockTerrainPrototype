using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanceLibrary
{
	[Serializable]
	public struct HistoricalData
	{
		public string Exchange { get; set; }
		public string Ticker { get; set; }

		public string Date { get; set; }

		public string Open { get; set; }
		public string High { get; set; }
		public string Low { get; set; }
		public string Close { get; set; }

		public HistoricalData(string exchange, string ticker, string date, string open, string high, string low, string close)
		{
			Exchange = exchange;
			Ticker = ticker;

			Date = date;

			Open = open;
			High = high;
			Low = low;
			Close = close;
		}
	}
}

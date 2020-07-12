using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace FinanceLibrary
{
	public static class Finance
	{
		private static string[] DownloadRawHistoricalData(string exchange, string ticker, int startYear, int endYear)
		{
			WebClient client = new WebClient();

			return client.DownloadString($"http://www.google.com/finance/historical?q={ exchange }:{ ticker }&startdate=Jan+01%2C+{ startYear }&enddate=Aug+2%2C+{ endYear }&output=csv")
				.Split('\n');
		}

		/// <summary>
		/// Downloads raw historical finance data from Google's servers and returns the information as an array of structs.
		/// </summary>
		/// <param name="exchange"></param>
		/// <param name="ticker"></param>
		/// <param name="startYear"></param>
		/// <param name="endYear"></param>
		/// <returns></returns>
		public static HistoricalData[] GetHistoricalData(string exchange, string ticker, int startYear, int endYear)
		{
			List<HistoricalData> historicalDataList = new List<HistoricalData>();

			string[] data = DownloadRawHistoricalData(exchange, ticker, startYear, endYear);

			for (int i = 1; i < data.Length; i++)
			{
				string[] elements = data[i].Split(',');

				if (elements.Length < 4)
					continue;

				historicalDataList.Add(new HistoricalData(exchange, ticker, elements[0], elements[1], elements[2], elements[3], elements[4]));
			}

			return historicalDataList.ToArray();
		}
	}
}

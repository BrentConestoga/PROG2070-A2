using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_A2_Group_10
{
	public class Product
	{
		public int ProdID { get; set; }
		public string ProdName { get; set; }
		public float ItemPrice { get; set; }
		public int StockAmount { get; set; }

		public Product(int ProdID, string ProdName, float ItemPrice, int StockAmount)
		{
			this.ProdID = ProdID;
			this.ProdName = ProdName;
			this.ItemPrice = ItemPrice;
			this.StockAmount = StockAmount;
		}

		public void IncreaseStock(int amount)
		{
			if (amount < 0)
			{
				return;
			}
			StockAmount += amount;
		}

		public void DecreaseStock(int amount)
		{
			if (StockAmount == 0 || amount < 0)
			{
				return;
			}
			StockAmount -= amount;
		}
	}
}

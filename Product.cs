using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_A2_Group_10
{
	public class Product
	{
		private int _ProdID;
		private float _ItemPrice;
		private int _StockAmount;

		public int ProdID
		{
			get { return _ProdID; }
			set
			{
				if (value >= 5 && value <= 50000)
				{
					_ProdID = value;
				}
				else if (value < 5)
				{
					_ProdID = 5;
				}
				else if(value > 50000)
				{
					_ProdID = 50000;
				}
			}
		}
		public string ProdName { get; set; }
		public float ItemPrice
		{
			get { return _ItemPrice; }
			set
			{
				if (value >= 5 && value <= 5000)
				{
					_ItemPrice = value;
				}
				else if (value < 5)
				{
					_ItemPrice = 5;
				}
				else if (value > 5000)
				{
					_ItemPrice = 5000;
				}
			}
		}
		public int StockAmount
		{
			get { return _StockAmount; }
			set
			{
				if (value >= 5 && value <= 500000)
				{
					_StockAmount = value;
				}
				else if (value < 5)
				{
					_StockAmount = 5;
				}
				else if (value > 500000)
				{
					_StockAmount = 500000;
				}
			}
		}

		public Product(int ProdID = 5, string ProdName = "", float ItemPrice = 5, int StockAmount = 5)
		{

			this.ProdID = ProdID;
			this.ProdName = ProdName;
			this.ItemPrice = ItemPrice;
			this.StockAmount = StockAmount;
		}

		public void IncreaseStock(int amount)
		{
			if (amount < 0 || StockAmount + amount > 500000)
			{
				return;
			}
			StockAmount += amount;
		}

		public void DecreaseStock(int amount)
		{
			if (amount < 0)
			{
				return;
			}
			if (StockAmount - amount < 5)
			{
				StockAmount = 5;
			}
			else
			{
				StockAmount -= amount;
			}
		}
	}
}

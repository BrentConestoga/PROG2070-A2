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
        public string ProdName { get; set; }
        public int ProdID
		{
			get => _ProdID;
			set
			{
				if (value >= 5 && value <= 50000)
				{
					_ProdID = value;
				}
			}
		}
		
		public float ItemPrice
		{
			get => _ItemPrice;
			set
			{
				if (value >= 5 && value <= 5000)
				{
					_ItemPrice = value;
				}
			}
		}
        public int StockAmount
        {
            get => _StockAmount;
            set
            {
                if (value >= 5 && value <= 500000)
                {
                    _StockAmount = value;
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
           

            this.StockAmount += amount;
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

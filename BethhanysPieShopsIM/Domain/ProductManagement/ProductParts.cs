using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethhanysPieShopsIM.Domain.ProductManagement
{
    public partial class Product
    {
        public static int StockThreshold = 5;

        public static void ChangeStockThreshold(int newStockThreshold)
        {
            if(newStockThreshold > 0)
                StockThreshold = newStockThreshold;
        }
        private void Log(string text)
        {
            Console.WriteLine(text); ;
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {Id} {Name}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethhanysPieShopsIM.Domain
{
    internal class Order
    {
        bool fulfilled;
        public int id;
        List<string[]> orderItems = null;
        DateTime fulfilmentDate;

        public void OrderList() { }
        public void ShowOrdersDetails() { }

    }
}

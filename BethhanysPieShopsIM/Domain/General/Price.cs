using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethhanysPieShopsIM.Domain.General
{
    public class Price
    {
        public Currency Currency { get; set; }
        public double ItemPrice { get; set; }

        public override string ToString()
        {
            return $"{ItemPrice} {Currency}";
        }
    }
}

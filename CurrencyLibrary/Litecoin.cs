using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Litecoin : Currency
    {
        //ctor
        public Litecoin(decimal cashValue)
        {
            CashValue = 0.023808m;
        }


        //method
        public decimal GetLitecoinConversion(decimal amount)
        {
            decimal cashValue = amount / CashValue;
            return cashValue;
        }
    }
}

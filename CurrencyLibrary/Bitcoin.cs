using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Bitcoin : Currency
    {


        //ctor
        public Bitcoin(decimal cashValue)
        {
            CashValue = 1.496m;
        }


        //method
        public decimal GetBitcoinConversion(decimal amount)
        {
            decimal cashValue = amount / CashValue;
            return cashValue;
        }

        

    }
}

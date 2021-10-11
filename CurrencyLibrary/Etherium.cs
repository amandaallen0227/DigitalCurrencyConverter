using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Etherium : Currency
    {

        //ctor
        public Etherium(decimal cashValue)
        {
            CashValue = 0.11723m;
        }


        //method
        public decimal GetEtheriumConversion(decimal amount)
        {
            decimal cashValue = amount / CashValue;
            return cashValue;
        }
    }
}

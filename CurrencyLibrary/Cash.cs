using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CurrencyLibrary
{
    public class Cash : Currency
    {




        //ctor
        public Cash(decimal amount, decimal cashValue)
        {
            Amount = amount;
            CashValue = 1;
        }


        //method
        public override decimal GetCashConversion()
        {
            decimal cash = Amount * CashValue;
                return cash;
         }

        public override decimal GetBitcoinConversion()
        {
            decimal bitcoin = Amount * CashValue;
        }
               
        public override decimal GetEtheriumConversion();
              
        public override decimal GetLitecoinConversion();


    }
}

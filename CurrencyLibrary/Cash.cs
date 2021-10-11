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
        public Cash(decimal cashValue)
        {
            CashValue = 1;
        }


        //method
        public decimal GetCashConversion(decimal amount)
        {
            decimal cashValue = amount / CashValue;
                return cashValue;
        }

        //Digital Currency conversions
        //Conversion for  Cash to Bitcoin
        public decimal GetBitcoin(decimal amount)
        {
            decimal cashAmount = GetCashConversion(amount);
            decimal bitcoin = cashAmount * 1.496m;
            return bitcoin;
        }

        //Converion for Cash to Etherium
        public decimal GetEtherium(decimal amount)
        {
            decimal cashAmount = GetCashConversion(amount);
            decimal etherium = cashAmount * 0.11723m;
            return etherium;
        }

        //Conversion for Cash to Litecoin
        public decimal GetLitecoin(decimal amount)
        {
            decimal cashAmount = GetCashConversion(amount);
            decimal litecoin = cashAmount * 0.023808m;
            return litecoin;
        }

    }
}

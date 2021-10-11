using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public abstract class Currency : IConvertable
    {
        public decimal Amount { get; set; }
        public decimal CashValue { get; set; }
      

        public abstract decimal GetConversion();

        //public abstract decimal GetBitcoinConversion();

        //public abstract decimal GetEtheriumConversion();
       
        //public abstract decimal GetLitecoinConversion();


    }
}

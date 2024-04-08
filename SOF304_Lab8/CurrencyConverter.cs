using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab8
{
    public class CurrencyConverter(IConvertRate rate)
    {
       /* private ConverRate rate;
        public CurrencyConverter(ConverRate rate) 
        {
            this.rate = rate;
        }*/
        public double ConvertUsdToVnd(double amount)
        {
            return amount * rate.UsdRate();
        }
    }
}

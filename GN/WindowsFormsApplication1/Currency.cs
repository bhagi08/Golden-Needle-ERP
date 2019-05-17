using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public class  Currency
    {
     public static decimal getCurrencyRate(string currFrom, string currTo)
        {
            decimal result;
            try
            {
                using (WebClient c = new WebClient())
                {
                    string data = c.DownloadString(string.Format("http://download.finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=sl1d1t1ba&e=.csv", currFrom, currTo));
                    string rate = data.Split(',')[1];
                    var style = NumberStyles.Number;
                    var culture = CultureInfo.CreateSpecificCulture("en-US");
                    decimal.TryParse(rate, style, culture, out result);
                }
                return result;
            }
            catch(Exception e)
            {

                return 0;
            }
        }
    }

}

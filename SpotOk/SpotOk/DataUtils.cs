using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotOk
{
    public class Utils
    {
        public static List<string> GetUsdt()
        {
            return new List<string>() {
                "eos","ltc"
            };
        }

        public static DateTime GetDateById(long id)
        {
            return new DateTime(id * 10000000 + new DateTime(1970, 1, 1, 8, 0, 0).Ticks);
        }
    }
}

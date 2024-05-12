using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class EuropeanDateTimePrinter : IDateTimePrinter
    {

        public string Print()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

    }
}

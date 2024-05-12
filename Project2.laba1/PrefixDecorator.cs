using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class PrefixDecorator : DateTimeDecorator
    {

        private string prefix;

        public PrefixDecorator(IDateTimePrinter dateTimePrinter, string prefix) : base(dateTimePrinter)
        {
            this.prefix = prefix;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prefix);
            sb.Append(dateTimePrinter.Print());
            return sb.ToString();
        }

    }
}

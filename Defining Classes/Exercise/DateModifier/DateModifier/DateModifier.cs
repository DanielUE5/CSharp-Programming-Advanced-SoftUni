using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDifferenceInDays(string first, string second)
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);

            TimeSpan diff = firstDate - secondDate;
            return Math.Abs(diff.Days);
        }
    }
}

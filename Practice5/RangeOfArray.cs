using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    public class RangeOfArray
    {
        private object[] array;
        public RangeOfArray(int beginningOfRange, int endOfRange)
        {
            BeginningOfRange = beginningOfRange;
            EndOfRange = endOfRange;
            array = new object[endOfRange - beginningOfRange + 1];
        }
        public int BeginningOfRange { get; set; }
        public int EndOfRange { get; set; }

        public object this[int i]
        {
            get
            {
                if (BeginningOfRange > 0)
                    return array[Math.Abs(i) - BeginningOfRange];
                else
                    return array[Math.Abs(BeginningOfRange) + i];
            }
            set
            {
                if (BeginningOfRange > 0)
                    array[Math.Abs(i) - BeginningOfRange] = value;
                else
                    array[Math.Abs(BeginningOfRange) + i] = value;
            }
        }
    }
}

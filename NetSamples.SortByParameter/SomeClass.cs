using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSamples.SortByParameter
{
    public class SomeClass : IComparable<SomeClass>
    {
        public int A { get; set; }
        public int B { get; set; }

        public int CompareTo(SomeClass? other)
        {
            if (other ==  null)
            {
                return 1;
            }
            if (other.A < A)
            {
                return 1;
            }
            if (other.A == A)
            {
                return 0;
            }
            else
                return -1;
        }
    }
}

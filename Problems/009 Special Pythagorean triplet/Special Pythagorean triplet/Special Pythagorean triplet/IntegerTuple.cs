using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
    class IntegerTuple
    {
        private List<int> _elements;

        public IntegerTuple(List<int> elements)
        {
            _elements = elements;
        }



        public int GetProduct()
        {
            int product = 1;

            foreach (int element in _elements)
            {
                product *= element;
            }

            return product;
        }

    }

}

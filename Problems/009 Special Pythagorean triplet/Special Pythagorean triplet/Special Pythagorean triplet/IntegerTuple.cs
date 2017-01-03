using System.Collections.Generic;

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

        public List<int> ToList()
        {
            return _elements;
        }
    }

}

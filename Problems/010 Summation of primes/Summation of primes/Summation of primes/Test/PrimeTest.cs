﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Summation_of_primes.Test
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void GetFirstPrime()
        {
            int upperBound = 3;
            List<int> expected = new List<int>{2};

            List<int> actual = Prime.GetPrimesBelow(upperBound);

            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void GetSomePrimes()
        {
            int upperBound = 6;
            List<int> expected = new List<int>{2,3,5};

            List<int> actual = Prime.GetPrimesBelow(upperBound);

            CollectionAssert.AreEqual(expected,actual);
        }
    }
}

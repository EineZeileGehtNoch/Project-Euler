using System;
using System.Collections.Generic;
using System.Numerics;

namespace Largest_product_in_a_series
{
    static class MagicStringUser
    {
        private static string MAGIC_STRING =
            "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        private static int EMPTY_PRODUCT = 1;

        private static Queue<int> _digits;
        private static List<int> _factors;
        private static BigInteger _biggestProduct;

        private static BigInteger _candidateForBiggestProduct;

        private static string _tempString;

        public static BigInteger GetBiggestProductOfAdjacentDigits(int numberOfDigits)
        {
            UseDefaultString();

            FindBiggestProduct(numberOfDigits);

            return GetBiggestFoundProduct();
        }

        public static BigInteger GetBiggestProductOfAdjacentDigits(string magicString, int numberOfDigits)
        {
            UseThisAsMagicString(magicString);

            FindBiggestProduct(numberOfDigits);
            
            return GetBiggestFoundProduct();
        }

        private static void FindBiggestProduct(int numberOfDigits)
        {
            CreateDigitList();

            SetBiggestProductOnDefault();

            ComputeAllPossibleProducts(numberOfDigits);
        }

        private static void UseThisAsMagicString(string magicString)
        {
            _tempString = magicString;
        }

        private static void UseDefaultString()
        {
            _tempString = MAGIC_STRING;
        }

        private static void ComputeAllPossibleProducts(int numberOfDigits)
        {
            AnalyzeFirstFactors(numberOfDigits);

            while (DigitsLeft())
            {
                AnalyzeNextFactors();
            }
        }

        private static bool DigitsLeft()
        {
            return _digits.Count > 0;
        }

        private static void AnalyzeNextFactors()
        {
            GetNextFactorList();
            ComputeAndSaveCandidateIfBigger();
        }

        private static void AnalyzeFirstFactors(int numberOfDigits)
        {
            CreateFirstFactorsList(numberOfDigits);
            ComputeAndSaveCandidateIfBigger();
        }

        private static void ComputeAndSaveCandidateIfBigger()
        {
            ComputeCandidate();
            SetCandidateAsBiggestIfBigger();
        }

        private static void GetNextFactorList()
        {
            RemoveOldestFactor();
            AddNextFactorToList();
        }

        private static void AddNextFactorToList()
        {
            _factors.Add(_digits.Dequeue());
        }

        private static void RemoveOldestFactor()
        {
            _factors.RemoveAt(0);
        }

        private static void ComputeCandidate()
        {
            SetCandidateOnDefault();
            AddFactorsToCandidate();
        }

        private static BigInteger GetBiggestFoundProduct()
        {
            return _biggestProduct;
        }

        private static void SetBiggestProductOnDefault()
        {
            _biggestProduct = EMPTY_PRODUCT;
        }

        private static void SetCandidateAsBiggestIfBigger()
        {
            if (CandidateIsBigger())
            {
                SetCandidateAsBiggest();
            }
        }

        private static void SetCandidateAsBiggest()
        {
            _biggestProduct = _candidateForBiggestProduct;
        }

        private static bool CandidateIsBigger()
        {
            return _candidateForBiggestProduct>_biggestProduct;
        }

        private static void AddFactorsToCandidate()
        {
            foreach (int factor in _factors)
            {
                AddFactorToCandidate(factor);
            }
        }

        private static void AddFactorToCandidate(int factor)
        {
            _candidateForBiggestProduct *= factor;
        }

        private static void SetCandidateOnDefault()
        {
            _candidateForBiggestProduct = EMPTY_PRODUCT;
        }

        private static void CreateFirstFactorsList(int numberOfDigits)
        {
            CreateEmptyFactorsList();

            FillFactorsList(numberOfDigits);
        }

        private static void FillFactorsList(int numberOfDigits)
        {
            for (int i = 0; i < numberOfDigits; i++)
            {
                _factors.Add(_digits.Dequeue());
            }
        }

        private static void CreateEmptyFactorsList()
        {
            _factors = new List<int>();
        }

        private static void CreateDigitList()
        {
            CreateEmptyDigitList();

            FillDigitList();
        }

        private static void FillDigitList()
        {
            for (int i = 0; i < _tempString.Length; i++)
            {
                _digits.Enqueue(Int16.Parse(_tempString[i].ToString()));
            }
        }

        private static void CreateEmptyDigitList()
        {
            _digits = new Queue<int>();
        }
    }
}

namespace Sum_square_difference
{
    class SumAndSquare
    {
        public static int DifferenceBetweenDifferentOrder(int upperBound)
        {
            int sumFirstSquareThenSum = 0;
            for (int number = 1; number <= upperBound; number++)
            {
                sumFirstSquareThenSum += number*number;
            }

            int sumFirstSumThenSquare = 0;
            for (int number = 1; number <= upperBound; number++)
            {
                sumFirstSumThenSquare += number;
            }
            sumFirstSumThenSquare = sumFirstSumThenSquare*sumFirstSumThenSquare;

            int difference = sumFirstSumThenSquare - sumFirstSquareThenSum;
            return difference;
        }
    }
}
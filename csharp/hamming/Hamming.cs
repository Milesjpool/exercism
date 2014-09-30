using System;

namespace HamEx
{
    public class Hamming
    {
        public static int Compute(string strandA, string strandB)
        {
            int strandLength = GetStrandLengths(strandA, strandB);

            return HammingDistance(strandA, strandB, strandLength);
        }

        private static int GetStrandLengths(string a, string b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException();
            }
            return a.Length;
        }

        private static int HammingDistance(string stringA, string stringB, int strandLength)
        {
            int hammingDistance = 0;

            for (int pair = 0; pair < strandLength; pair++)
            {
                if (stringA[pair] != stringB[pair])
                {
                    hammingDistance++;
                }
            }
            return hammingDistance;
        }
    }
}
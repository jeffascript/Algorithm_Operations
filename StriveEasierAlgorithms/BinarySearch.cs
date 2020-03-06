using System;

using System.Collections.Generic;


namespace StriveEasierAlgorithms
{
    public class BinarySearch
    {
        

        public int[] Search(List<int> ourArray, int targetValue)
        {
            if ((ourArray == null) || (ourArray.Count == 0))
                ourArray = new List<int>(20) { 5, 8, 9, 11, 12, 13, 15, 18, 19, 24, 25, 27, 29, 34, 35, 39};

            int loopCounter = 0;
            int[] RESULT = new int[2];
            int min = 0;
            int max = ourArray.Count - 1;
            int oneGuess;

            while (min<= max)
            {
                oneGuess = (min + max) / 2;

                if (ourArray[oneGuess] == targetValue)
                {
                    loopCounter++;
                    RESULT[0] = oneGuess + 1;
                    RESULT[1] = loopCounter;
                   return RESULT;
                }
                else if (ourArray[oneGuess] < targetValue)
                {
                    min = oneGuess + 1;
                    loopCounter++;
                }
                else
                {
                    max = oneGuess - 1;
                    loopCounter++;
                }
            }
            return RESULT;
        }
    }
}

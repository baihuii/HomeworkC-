using System;
using System.Numerics;
using System.Text;

namespace SecretSequence
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            BigInteger N = BigInteger.Parse(number);
            int numberLenght = number.Length;
            int test = number.Length;
            int specialSum = 0;

            if (N < 0)
            {
                N *= -1;
            }


            int currentDigitPos = 0;
            while (numberLenght > 0)
            {
                BigInteger current = N % 10;
                currentDigitPos++;
                if (currentDigitPos % 2 == 0)
                {

                    specialSum = specialSum+( (int)(current * current) * (currentDigitPos));
                }else
                {
                    specialSum = specialSum + (((int)current * (int)Math.Pow(currentDigitPos, 2)));
                }
                N /= 10;
                numberLenght -= 1;
                
            }
            

            //For example if the number is 37 its special sum is 7 * 1^2 + 3^2 * 2 = 25




            Console.WriteLine(specialSum);
            int alphaSequenceLength = specialSum % 10;
            
            BigInteger R = specialSum % 26;
            StringBuilder alphaSequence = new System.Text.StringBuilder();
            //string alphaSequence = (char)65;


            if (alphaSequenceLength == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                for (int i = 1; i <= alphaSequenceLength; i++)
                {
                    if(R <= 25)
                    {
                        alphaSequence.Append((char)(65 + R));
                    }
                    else
                    {
                        R = -1;
                        i--;
                    }
                    
                    R += 1;
                }
            }
            Console.WriteLine(alphaSequence);
        }
    }
}


//The secret alpha-sequence of a number is a sequence of capital letters from the English alphabet constructed by the number’s special sum.
//The length of the sequence is indicated by the last digit of the number’s special sum.If this length is 0 the number has no secret alpha-sequence.
//The number R represents the remainder of a number’s special sum divided by the number of letters in the alphabet (26). The first letter of the alpha-sequence
//is the letter from the English alphabet at position equal to the sum R + 1. Every next letter in the secret alpha-sequence is the next letter of the alphabet.
//If the last letter (‘Z’) is reached the sequence afterwards continues from the first letter of the alphabet (‘A’).
//For example if the special sum of a number is 3, its secret alpha-sequence is “DEF”. Another example: if the special sum of a number is 48 its secret alpha-sequence is “WXYZABCD”.

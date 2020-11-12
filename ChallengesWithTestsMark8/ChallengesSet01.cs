using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var answ = minuend - subtrahend;
            return answ;
        }

        public int Add(int number1, int number2)
        {
            var a = number1;
            var b = number2;
            var answ = a + b;
            return answ;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var prod = factor1 * factor2;
            return prod;

        }

        public string GetGreeting(string nameOfPerson)
        {
            var x = nameOfPerson;
            if (x == "")
            {
                var a = "Hello!";
                return a;
            }
            else
            {
                var b = "Hello, " + x + "!";
                return b;
            }
            
        }

        public string GetHey()
        {
            var a = "HEY!";
            return a;
        }
    }
}

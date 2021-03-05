using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference --- DONE



        // Create an Add method that passes 3 integers
        public int Addition(int num1, int num2, int num3)
        {


            return num1 + num2 + num3;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtraction(int minuend, int subtrahend)
        {


            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiplication(int num1, int num2)
        {


            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers


        public int Division(int numerator, int divisor)
        {


            return numerator / divisor;
        }
        // Create 2 methods that will utilize the [Fact] tests you wrote

        public bool IsASymbol(char input)
        {
            return Char.IsSymbol(input);
        }

        public bool IsALetter(char input)
        {
            return Char.IsLetter(input);
        }
    }
}

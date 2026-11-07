using System;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Addition(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Division(float num1, float num2)
        {
            if (num2 == 0) return 0;
            return num1 / num2;
        }
    }
}
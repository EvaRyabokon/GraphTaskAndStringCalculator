using NUnit.Framework;
using StringCalculation;
using System;
using System.Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimpleTest()
        {
            var inputString = "1+2-3+4-5";

            var calculator = new StringCalculation.StringCalculator();

            Assert.AreEqual(-1, calculator.CalculateString(inputString));
        }

        [Test]
        public void ExpressionWithSum()
        {
            var inputString = "11+12+25+1000";

            var calculator = new StringCalculation.StringCalculator();

            Assert.AreEqual(1048, calculator.CalculateString(inputString));
        }

        [Test]
        public void ExpressionWithSubstraction()
        {
            var inputString = "300-40-333-1";

            var calculator = new StringCalculation.StringCalculator();

            Assert.AreEqual(-74, calculator.CalculateString(inputString));
        }

        [Test]
        public void OneNumber()
        {
            var inputString = "100";

            var calculator = new StringCalculator();

            Assert.AreEqual(100, calculator.CalculateString(inputString));
        }

        [Test]
        public void InputStringWithNewLine()
        {
            var inputString = "100+1\n";

            var calculator = new StringCalculator();

            Assert.AreEqual(101, calculator.CalculateString(inputString));
        }

        [Test]
        public void OneHundredThousandSymbols()
        {
            var inputString = new StringBuilder(100000);

            inputString.Append("1");

            for (int i = 1; i < 50000; i++)
            {
                inputString.Append("+");
                inputString.Append("1");
            }

            var calculator = new StringCalculator();

            Assert.AreEqual(50000, calculator.CalculateString(inputString.ToString()));
        }

        [Test]
        public void LargeExpression()
        {
            Random rnd = new Random();
            var inputString = new StringBuilder(100000);
            int value = rnd.Next(1, 1000);
            var expectedResult = value;
            inputString.Append(value.ToString());

            for (int i = 0; i < 50000; i++)
            {
                value = rnd.Next(1, 1000);

                if (value % 2 == 0)
                {
                    inputString.Append("+");
                    expectedResult += value;
                }
                else
                {
                    inputString.Append("-");
                    expectedResult -= value;
                }

                inputString.Append(value.ToString());
            }

            var calculator = new StringCalculator();

            Assert.AreEqual(expectedResult, calculator.CalculateString(inputString.ToString()));
        }
    }
}

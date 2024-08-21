using UnitTestUzduotys.Models;

namespace SimpleCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            ISimpleCalculator operations = new SimpleCalculator();
            int a = 8;
            int b = 9;
            int result = 17;

            int actualResult = operations.Add(a, b);

            Assert.Equal(result, actualResult);
        }

        [Fact]
        public void TestSubtract()
        {
            ISimpleCalculator operations = new SimpleCalculator();
            int a = 8;
            int b = 7;
            int result = 1;

            int actualResult = operations.Subtract(a, b);

            Assert.Equal(result, actualResult);
        }

        [Fact]
        public void TestMultiply()
        {
            ISimpleCalculator operations = new SimpleCalculator();
            int a = 8;
            int b = 7;
            int result = 56;

            int actualResult = operations.Multiply(a, b);

            Assert.Equal(result, actualResult);
        }

        [Fact]
        public void TestDivide()
        {
            ISimpleCalculator operations = new SimpleCalculator();
            DivideByZeroException exception = new DivideByZeroException();
            int a = 8;
            int b = 0;
            //int result = exception;

            //int actualResult = operations.Divide(a, b);

            Assert.Throws<DivideByZeroException>(() => operations.Divide(a,b));
        }
    }
}
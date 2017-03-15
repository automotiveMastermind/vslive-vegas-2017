namespace AM.VSLive.Library.Test
{
    using System;

    using Xunit;

    public class ExampleTest
    {
        [Fact]
        public void DivideByZero_Throws()
        {
            // arrange
            var left = 5;
            var right = 0;

            var target = new Example();

            // act
            Action act = () => target.Divide(left, right);

            // arrange
            Assert.Throws<DivideByZeroException>(act);
        }
    }
}

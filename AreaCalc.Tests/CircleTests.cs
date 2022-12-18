
using Xunit;

namespace AreaCalc.Tests
{
    public class CircleTests
    {

        [Fact]
        public void AreaCircleResult()
        {

            Circle circle = new Circle(5);

            double result = circle.GetArea();

            Assert.Equal(78.54, Math.Round(result,2));
        }
  

    }
}

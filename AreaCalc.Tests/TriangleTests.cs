using Xunit;

namespace AreaCalc.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void AreaTrianglResult()
        {

            Triangle triangle = new Triangle(5, 5, 6);

            double result = triangle.GetArea();

            Assert.Equal(12, result);
        }
        [Fact]
        public void ExistenceTrianglСheked()
        {

            Triangle triangle = new Triangle(1, 5, 7);

            double result = triangle.GetArea();

            Assert.Equal(0, result);
        }
        [Fact]
        public void RectangularTrianglСheked()
        {

            Triangle triangle = new Triangle(4, 5, 3);

            bool result = triangle.Rectangular;

            Assert.True(result);
        }
    }
}

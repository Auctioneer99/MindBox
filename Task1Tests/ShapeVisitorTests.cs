using Task1.Models.Figures;
using Task1.Services.Visitors;

namespace Task1Tests
{
    public class ShapeVisitorTest
    {
        private ShapeVisitor _visitor;

        public ShapeVisitorTest()
        {
            _visitor = new ShapeVisitor();
        }

        [Fact]
        public void TestCircle0()
        {
            var circle = new Circle();

            Assert.True(CheckShape(circle, 0));
        }

        [Fact]
        public void TestCircle1()
        {
            var circle = new Circle() { Radius = 1 };

            Assert.True(CheckShape(circle, 3.1415, 0.001));
        }

        [Fact]
        public void TestCircle10()
        {
            var circle = new Circle() { Radius = 10 };

            Assert.True(CheckShape(circle, 314.15, 0.01));
        }

        [Fact]
        public void TestTriangle0()
        {
            var triangle = new Triangle() 
            { 
                A = new Triangle.Point(),
                B = new Triangle.Point(),
                C = new Triangle.Point()
            };

            Assert.True(CheckShape(triangle, 0));
        }

        [Fact]
        public void TestTriangle1()
        {
            var triangle = new Triangle()
            {
                A = new Triangle.Point(0, 2),
                B = new Triangle.Point(0, 0),
                C = new Triangle.Point(1, 0)
            };

            Assert.True(CheckShape(triangle, 1));
        }

        [Fact]
        public void TestBox0()
        {
            var box = new Box();

            Assert.True(CheckShape(box, 0));
        }

        [Fact]
        public void TestBox1()
        {
            var box = new Box()
            {
                Width = 1,
                Height = 1,
            };

            Assert.True(CheckShape(box, 1));
        }

        private bool CheckShape(AFigure figure, double value, double epsilon = 0.00001)
        {
            var shape = _visitor.Visit(figure);

            return IsApproximatly(shape, value, epsilon);
        }

        private bool IsApproximatly(double a, double b, double epsilon = 0.00001)
        {
            return Math.Abs(a - b) <= epsilon;
        }
    }
}
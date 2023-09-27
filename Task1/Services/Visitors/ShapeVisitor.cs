using Task1.Models;
using Task1.Models.Figures;

namespace Task1.Services.Visitors
{
    public class ShapeVisitor : IFigureVisitor<double>
    {
        public double Visit(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public double Visit(Triangle triangle)
        {
            var shape = 0.5 * Math.Abs((triangle.B.X - triangle.A.X) * (triangle.C.Y - triangle.A.Y)
                - (triangle.C.X - triangle.A.X) * (triangle.B.Y - triangle.A.Y));

            return shape;
        }

        public double Visit(Box box)
        {
            return box.Width * box.Height;
        }
    }
}

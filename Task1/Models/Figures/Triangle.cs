namespace Task1.Models.Figures
{
    public class Triangle : AFigure
    {
        public Point A { get; set; }

        public Point B { get; set; }

        public Point C { get; set; }

        public bool IsRightTriangle(double epsilon = 0.000001)
        {
            var ab = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            var ac = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            var bc = Math.Sqrt(Math.Pow(B.X - C.X, 2) + Math.Pow(B.Y - C.Y, 2));

            var sides = new List<double>() { ab, bc, ac }
                .OrderBy(x => x)
                .ToArray();

            var hypotenuse = Math.Pow(sides[2], 2);
            var cathets = Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);

            return Math.Abs(hypotenuse - cathets) < epsilon;
        }

        public override TOut AcceptVisitor<TOut>(IFigureVisitor<TOut> visitor)
        {
            return visitor.Visit(this);
        }

        public record struct Point(double X, double Y);
    }
}

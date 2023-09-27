namespace Task1.Models.Figures
{
    public class Circle : AFigure
    {
        public double Radius { get; set; }

        public override TOut AcceptVisitor<TOut>(IFigureVisitor<TOut> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

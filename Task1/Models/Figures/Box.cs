namespace Task1.Models.Figures
{
    public class Box : AFigure
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public override TOut AcceptVisitor<TOut>(IFigureVisitor<TOut> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

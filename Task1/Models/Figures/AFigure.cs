namespace Task1.Models.Figures
{
    public abstract class AFigure
    {
        public abstract TOut AcceptVisitor<TOut>(IFigureVisitor<TOut> visitor);
    }
}

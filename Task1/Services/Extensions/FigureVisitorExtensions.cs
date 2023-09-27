using Task1.Models;
using Task1.Models.Figures;

namespace Task1.Services.Visitors
{
    public static class FigureVisitorExtensions
    {
        public static TOut Visit<TOut>(this IFigureVisitor<TOut> visitor, AFigure figure)
        {
            return figure.AcceptVisitor(visitor);
        }
    }
}

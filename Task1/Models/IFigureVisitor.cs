using Task1.Models.Figures;

namespace Task1.Models
{
    public interface IFigureVisitor<TOut>
    {
        public TOut Visit(Circle circle);

        public TOut Visit(Triangle triangle);

        public TOut Visit(Box box);
    }
}

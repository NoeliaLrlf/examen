namespace ConsoleApp1
{
    public class Rectangle : AbstractGeometricFigure
    {
        public int rectangleBase;
        public int rectangleHeight;

        public Rectangle(int figureBase, int figureHeight)

        {
            rectangleBase = figureBase;
            rectangleHeight = figureHeight;
        }

        public override double GetArea()
         => rectangleBase * rectangleHeight;
        
    }
}
    namespace Geo_Fig
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            Square s2 = new Square(30, 10);
            
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(width: 30f, height: 10f, 20f, 30f);

            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(10, 30, 20, 10);

            Circle c1 = new Circle();
            Circle c2 = new Circle(3, 5, 5);

            // Print positions
            s1.PrintPosition();
            s2.PrintPosition();
            r1.PrintPosition();
            r2.PrintPosition();
            t1.PrintPosition();
            t2.PrintPosition();
            c1.PrintPosition();

            var figures = new List<Figure> { s1, s2, r1, r2, t1, t2, c1, c2 };
            foreach (var figure in figures)
            {
                figure.PrintPosition();
                figure.PrintArea();
            }

        }
    }
}
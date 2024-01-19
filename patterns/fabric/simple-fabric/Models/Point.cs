public class Point
{
    private double x, y;

    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"x: {x}, y: {y}";
    }

    public static PointFactory Factory =
        new PointFactory();

    // if we want private class constructor we should put fabric inside class we want to instantiate
    public class PointFactory
    {
        public Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), theta * Math.Sin(theta));
        }
    }
}
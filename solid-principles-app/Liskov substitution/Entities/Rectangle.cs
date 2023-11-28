public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle()
    {

    }

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Area => Width * Height;

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}}}";
    }


    // we can define square not as entity 
    //but as rectangle class functional

    public Rectangle NewSquare(int side)
    {
        return new Rectangle(side, side);
    }

    public bool IsSquare => Width == Height;
}
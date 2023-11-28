public static class Helper
{
    public static void UseIt(Rectangle r)
    {
        int width = r.Width;
        r.Height = 10;
        //10*width
        Console.WriteLine($"Expect area of {10 * width}, " +
        $"got {r.Area}");
    }
}
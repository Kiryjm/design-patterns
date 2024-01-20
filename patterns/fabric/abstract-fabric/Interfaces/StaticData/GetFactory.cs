public static class FactoryCreator
{
    public static ShapeFactory GetFactory(bool rounded)
    {
        if (rounded)
            return new RoundedShapeFactory();
        else
            return new BasicShapeFactory();
    }
}
public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAsA(this PersonBuilder builder, string position)
    {
        // you may use Add directly instead of AddAction method

        // builder.Actions.Add(p =>
        //    {
        //        p.Position = position
        //         return p;
        //    })

        // or use public method Do
        builder.Do(p => p.Position = position);
        return builder;
    }
}
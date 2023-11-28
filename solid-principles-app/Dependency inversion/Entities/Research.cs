public class Research
{
    // public Research(Relationships relationships)
    // {
    //     // high-level modules should depends on low-level modules
    //     // relations can be modified in future and then 
    //     // might not support foreach iteration

    //     //you should depends on interface or some abstract insteads 
    //     var relations = relationships.Relations;

    //     foreach (var r in relations
    //     .Where(x => x.Item1.Name == "John"
    //     && x.Item2 == Relationship.Parent))
    //     {
    //         Console.WriteLine($"John has child called {r.Item3.Name}");
    //     }
    // }


    public Research(IRelationshipBrowser browser)
    {

        //you should depends on interface or some abstract insteads 
        foreach (var p in browser.FindAllChildrenOf("John"))
        {
            Console.WriteLine($"John has child called {p.Name}");
        }
    }
}
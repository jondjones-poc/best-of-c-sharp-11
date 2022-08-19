using JonDJones.NetCore6.Examples.Examples.Entities;

namespace JonDJones.NetCore6.Examples;

public class PropertyMatchingClass
{
    public string NewPropertyMatching()
    {
        var superhero = new Superhero
        {
            Location = new Location()
        };
        superhero.Location.Name = "London";

        if (superhero is { Location.Name: "London" })
        {
            return "Match";
        };

        return string.Empty;
    }

    public string PatternMatchingComparison(Superhero superhero)
    {
        var result = superhero switch
        {
            { Location: {  Name: "London"}} => "Superman",
            { Location.Name: "money" } => "Iron man",
            { Location.Name: "development" } => "Jon Jones",
            _ => "No match"
        };

        return result;
    }
}

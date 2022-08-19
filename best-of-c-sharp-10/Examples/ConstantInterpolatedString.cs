namespace JonDJones.NetCore6.Examples;

public class ConstantInterpolatedString
{
    //string OldWay = "This is an "
    //    + Example1 + "which is "
    //    + Example2 +
    //    "longwinded";

    const string Example1 = $"Another example {Example2}";

    const string Example2 = $"This is an {"example"}";

    //const string Example3 = $"Needs to be constant {1 + 1}";

}

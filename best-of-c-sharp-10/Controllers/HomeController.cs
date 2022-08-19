namespace JonDJones.NetCore6.Examples.Controllers;

[Route("/")]
public class HomeController : Controller
{
    public string Index()
    {
        return "Hello";
    }
}
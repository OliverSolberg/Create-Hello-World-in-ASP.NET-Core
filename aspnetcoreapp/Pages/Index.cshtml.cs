using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    Controllers ctrl = new Controllers();
    informationOrganizer ino = new informationOrganizer();
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public string Hobbies {get; private set;} = "I have no hobbies test";
    public void OnGet()
    {
        Hobbies = ino.listOutHobbies(ctrl.GetPerson(1) ?? new Person());
    }
}

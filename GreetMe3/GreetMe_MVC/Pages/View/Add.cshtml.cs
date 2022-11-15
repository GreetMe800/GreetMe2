using GreetMe_API.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreetMe_MVC.Pages.View
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public ViewDto View { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./index");
        }
    }
}
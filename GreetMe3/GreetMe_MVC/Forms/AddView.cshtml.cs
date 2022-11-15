using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetMe_API.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreetMe_MVC.Forms
{
    public class AddViewModel : PageModel
    {
        [BindProperty]
        public ViewDto view { get; set; }

        public void OnGet()
        {
        }
    }
}

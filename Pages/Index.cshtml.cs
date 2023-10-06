using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CoreTestApp.Pages
{
    public class NameMessageTaskModel : PageModel
    {
        public StringValues name;
        public void OnGet()
        {

        }
        public void OnPost() 
        { 
            this.name = Request.Form["name"];
        }
    }
}


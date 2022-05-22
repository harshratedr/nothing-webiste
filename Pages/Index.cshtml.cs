using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace registration_form.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public bool hasdata = false;
        public string firstName = "";
        public string middleName = "";
        public string lastName = "";
        public string email = "";
        public string message = "";



        public void OnGet()
        {

        }
        public void Onpost()
        { 
          hasdata = true;
            firstName = Request.Form["firstname"];
            middleName = Request.Form["middlename"];
            lastName = Request.Form["Lastname"];
            email = Request.Form["email"];
            message = Request.Form["message"];


        }
    }
}
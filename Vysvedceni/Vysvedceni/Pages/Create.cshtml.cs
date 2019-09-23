using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vysvedceni.Services;

namespace Vysvedceni.Pages
{
    public class CreateModel : PageModel
    {
        private DataService _service;
        public CreateModel(DataService service)
        {
            service = _service;
        }
        public void OnGet()
        {

        }
    }
}
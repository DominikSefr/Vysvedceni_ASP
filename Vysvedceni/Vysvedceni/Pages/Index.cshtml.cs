using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vysvedceni.Data;
using Vysvedceni.Services;

namespace Vysvedceni.Pages
{
    public class IndexModel : PageModel
    {
        public DataService _service { get; set; }
        public ViewModel VM;
        public IndexModel(DataService service)
        {
            _service = service;
            VM = new ViewModel();
        }
        public void OnGet()
        {
            VM.Collection = _service.Grades;
        }
        public class ViewModel
        {
            public List<Grade> Collection { get; set; } = new List<Grade>();
        }
    }
}

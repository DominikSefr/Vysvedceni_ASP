﻿using System;
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
        public Service _service { get; set; }
        private ViewModel VM;
        public IndexModel(Service Service)
        {
            Service = _service;
        }
        public void OnGet()
        {

        }
        class ViewModel : Grade { }
    }
}

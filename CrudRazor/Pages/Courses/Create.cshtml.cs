using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudRazor.Pages.Courses
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Course Course { get; set; }
        public void OnGet()
        {
        }
    }
}

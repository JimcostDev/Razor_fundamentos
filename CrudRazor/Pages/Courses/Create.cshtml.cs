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
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Course Course { get; set; }
        [TempData]
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Add(Course);
            await _db.SaveChangesAsync();

            Message = "Curso creado correctamente";
            return RedirectToPage("Index");
        }
    }
}

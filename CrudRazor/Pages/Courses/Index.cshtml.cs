using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrudRazor.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Course> Courses { get; set; }

        
        public async Task OnGet()
        {
            Courses = await _db.Courses.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}

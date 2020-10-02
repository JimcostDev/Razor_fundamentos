using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudRazor.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]// vincular con su respectiva vista
        public Course Course { get; set; }
        [TempData]
        public string Message { get; set; }
        public async Task OnGet(int id)
        {
            Course = await _db.Courses.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeDb = await _db.Courses.FindAsync(Course.ID);
                CursoDesdeDb.Name= Course.Name;
                CursoDesdeDb.NumberClasses = Course.NumberClasses;
                CursoDesdeDb.Price = Course.Price;

                await _db.SaveChangesAsync();

                Message = "Curso actualizado correctamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}

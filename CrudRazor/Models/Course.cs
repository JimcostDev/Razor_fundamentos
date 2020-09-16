using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRazor.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Nombre de curso")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Cantidad de clases")]
        public int NumberClasses { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public double Price { get; set; }

    }
}

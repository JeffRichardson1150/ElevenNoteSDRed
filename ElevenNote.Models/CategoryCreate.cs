using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [Display(Name ="Category Name")]
        [MinLength(2, ErrorMessage = "Category Name must be at least 2 characters long")]
        public string CategoryName { get; set; }

        [Display(Name = "Category Description")]
        [MaxLength(200, ErrorMessage = "Description must be 200 characters or less")]
        public string CategoryDescription { get; set; }
    }
}

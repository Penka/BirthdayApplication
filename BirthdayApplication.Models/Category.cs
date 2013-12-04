using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApplication.Models
{
    public class Category
    {
        public Category()
        {
            this.Images = new HashSet<Image>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "The name of the category must be between 2 and 20 symbols long.")]
        public string Name { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}

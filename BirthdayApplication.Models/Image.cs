using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApplication.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}

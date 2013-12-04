using BirthdayApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IDbSet<Image> Images  { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}

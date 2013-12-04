using BirthdayApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApplication.Data
{
    public class MigrationsConfiguration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            if (context.Categories.Count() == 0)
            {
                context.Categories.Add(new Category()
                {
                    Name = "Friends"
                });
                context.Categories.Add(new Category()
                {
                    Name = "Family"
                });
                context.Categories.Add(new Category()
                {
                    Name = "Pets"
                });

                context.SaveChanges();
            }
        }
    }
}

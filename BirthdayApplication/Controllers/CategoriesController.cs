using BirthdayApplication.Data;
using BirthdayApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApplication.Controllers
{
    public class CategoriesController : BaseController
    {
        public ActionResult Friends()
        {
            return GetImagesByCategory("Friends");
        }

        public ActionResult Family()
        {
            return GetImagesByCategory("Family");
        }

        public ActionResult Pets()
        {
            return GetImagesByCategory("Pets");
        }

        private ActionResult GetImagesByCategory(string categoryName)
        {
            var category = this.data.Categories.All().Select(x => new CategoryViewModel()
                {
                    CategoryId = x.CategoryId,
                    Name = x.Name,
                    Images = x.Images.Select(y => new ImageViewModel()
                    {
                        Description = y.Description,
                        ImageId = y.ImageId,
                        Url = y.Url
                    })
                }).FirstOrDefault(x=> x.Name == categoryName);

            if (category == null)
            {
                throw new ArgumentException("The category's name is not correct.");
            }

            return View("Details", category);
        }
    }
}
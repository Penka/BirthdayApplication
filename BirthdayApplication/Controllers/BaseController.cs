using BirthdayApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApplication.Controllers
{
    public class BaseController : Controller
    {
        protected IUnitOfWork data;

        protected BaseController(IUnitOfWork data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }
            this.data = data;
        }

        public BaseController()
            : this(new UnitOfWork())
        {

        }
    }
}
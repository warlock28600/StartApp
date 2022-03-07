using learn_2.DAL;
using learn_2.Models.Person.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learn_2.Controllers
{
    public class PersonController : Controller
    {
        private Farhang ff = new Farhang();
        // GET: Person
        public ActionResult Index()
        {
            return View(ff.PersonInfos.Select(c=> new PersonViewModel() { 
            ID=c.ID,
            Name=c.Name,
            LastName=c.LastName,
            Mobile=c.Mobile,
            Email=c.Email,
            Address=c.Address,
            Position=c.Position.Name,
            unit=c.Unit.Title
            
            
            }));
        }
    }
}
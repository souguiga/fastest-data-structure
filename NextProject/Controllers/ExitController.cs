using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDataStructures.Controllers
{
    public class ExitController : Controller
    {
        // GET: Exit
        public ActionResult Exit()
        {
            return Redirect("http://www.byu.edu");
        }
    }
}

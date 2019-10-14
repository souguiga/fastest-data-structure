using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class StackController : Controller
    {
        // GET: Stack
        public ActionResult Stack()
        {
            Stack<string> simpleStack = new Stack<string>();

            simpleStack.Push("Go to church");
            simpleStack.Push("Put shoes on");
            simpleStack.Push("Put socks on");
            simpleStack.Push("As long as I got my suit & tie");
            simpleStack.Push("Shower");
            simpleStack.Push("Brush teeth");
            simpleStack.Push("Wake up");

            ViewBag.churchPrepStack = simpleStack;

            return View();
        }

    }
}
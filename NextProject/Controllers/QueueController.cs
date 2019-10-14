using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class QueueController : Controller
    {
        // GET: Queue
        public ActionResult Queue()
        {
            Queue<String> myQueue = new Queue<string>();

            myQueue.Enqueue("Joseph Smith");
            myQueue.Enqueue("Brigham Young");
            myQueue.Enqueue("John Taylor");
            myQueue.Enqueue("Wilford Woodruff");
            myQueue.Enqueue("Lorenzo Snow");
            myQueue.Enqueue("Joseph F. Smith");
            myQueue.Enqueue("Heber J. Grant");
            myQueue.Enqueue("George Albert");
            myQueue.Enqueue("David O. McKay");
            myQueue.Enqueue("Joseph Fielding Smith");
            myQueue.Enqueue("Harold B. Lee");
            myQueue.Enqueue("Spencer W. Kimball");
            myQueue.Enqueue("Ezra Taft Benson");
            myQueue.Enqueue("Howard W. Hunter");
            myQueue.Enqueue("Gordon B. Hinckley");
            myQueue.Enqueue("Thomas S. Monson");
            myQueue.Enqueue("Russell M. Nelson");

            ViewBag.prophetsQueue = myQueue;
            return View();
        }
    }
}
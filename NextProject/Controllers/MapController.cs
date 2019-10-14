using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class MapController : Controller
    {
        private static Dictionary<string, string> myMap = new Dictionary<string, string>();

        [HttpPost]
        public ActionResult AddToMap(string key, string value)
        {
            
            
            if (!myMap.ContainsKey(key) && key != "" && value != "")
            {
                myMap.Add(key, value);
            }
            ViewBag.myMap = myMap;

            return View("Map");
        }

        
        public ActionResult EraseOne(string key)
        {
            if (myMap.Remove(key))
            {
                // key removed
            }
            else
            {
                // dictionary doesn't contain the key
            }

            ViewBag.myMap = myMap;
            return View("Map");
        }

        [HttpPost]
        public ActionResult EraseAll(string key)
        {
            myMap.Clear();

            ViewBag.myMap = myMap;
            return View("Map");
        }

        [HttpPost]
        public ActionResult AddMany()
        {
            for (int counter = 1; counter <= 2000; counter++)
            {
                myMap.Add("New Entry " + counter, counter.ToString());
            }

            ViewBag.myMap = myMap;
            return View("Map");
        }

        [HttpPost]
        public ActionResult Search(string searchTerm)
        {
            string swMessage = "Fool, \"" + searchTerm + "\" is not a key in the dictionary. Cheeky move.";

            if (searchTerm == "")
            {
                swMessage = "Real funny. Enter a valid search term and I'll get back to you.";

            } else if (myMap.ContainsKey(searchTerm))
            {

                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                ViewBag.foundFromSearch = myMap[searchTerm];
                sw.Stop();

                TimeSpan ts = sw.Elapsed;

                swMessage = "Milliseconds elapsed during search: " + ts.Milliseconds;
            }

            ViewBag.StopWatchMessage = swMessage;

            ViewBag.myMap = myMap;
            return View("Map");
        }

        // GET: Map
        public ActionResult Map()
        {


            ViewBag.myMap = myMap;
            return View();
        }

    }
}
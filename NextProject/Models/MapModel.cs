using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.Models
{
    public class MapModel
    {
        public string Input { get; set; }
        public Dictionary<string, HashSet<int>> Map { get; set; }
    }
}
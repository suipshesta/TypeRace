using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{
    public class ParserRequest
    {
        public List<string> Locations { get; set; }
        public string Request { get; set; }
        public string Position { get; set; }
        public string Extract_type { get; set; }
        public bool Case_insensitive { get; set; }
    }
}

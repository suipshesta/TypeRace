using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{
    public class SearchBundle
    {
        public List<string> Locations { get; set; }
        public string Request { get; set; }
        public string Position { get; set; }
        public string Extract_type { get; set; }
        public bool Case_insensitive { get; set; }
    }
    public class ImgCrop
    {
        public bool Status { get; set; }
        public List<double> Norm_values { get; set; }
    }

    public class SearchReq
    {
        public string Parsing_rule_name { get; set; }
        public int Request_page { get; set; }
        public string Request { get; set; }
        public string Position { get; set; }
        public string Extract_type { get; set; }
        public bool Case_insensitive { get; set; }
        public ImgCrop Crop { get; set; }
    }
}

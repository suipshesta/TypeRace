using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{
    public class UploadResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Filename { get; set; }
    }
    public class ParserUploadResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Filename { get; set; }
        public string Format { get; set; }
        public string RawFilename { get; set; }
        public int? ParsedStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Info { get; set; }
        public string DocId { get; set; }
    }
 
}

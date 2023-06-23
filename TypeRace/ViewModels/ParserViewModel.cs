using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{
    public class ParserViewModel
    {
        
        public string UserId { get; set; }
        public string ParserName { get; set; }

       
        public string OriginalDocName { get; set; }
        public string Format { get; set; }
        public string DocId { get; set; }

        public List<string> RawChild { get; set; }
        public List<string> ProcessedChild { get; set; }
    }
    public class ExtractResultFrm
    {
        public string Massage { get; set; }
        public ICollection<PaResult> Result { get; set; }
        public bool Status { get; set; }
    }
    public class PaResult
    {
        public string Extract_type { get; set; }
        public paImg Img { get; set; }
        public string Page { get; set; }
        public string Position { get; set; }
        public string Request { get; set; }
        public IList<string> Text { get; set; }
        public IList<string> Without_currency_sign { get; set; }
    }
    public class paImg
    {
        public string Input_img { get; set; }
        public string Output_img { get; set; }
    }
    public class ResultCollection
    {
        public ICollection<PaResult> Result { get; set; }
    }
    public class Message
    {
        [JsonProperty("message")]
        public object ResponseMessage { get; set; }
    }
}
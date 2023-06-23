using System;
using System.ComponentModel.DataAnnotations;


namespace TypeRace.Models
{
    public class DocDetails
    {
       [Key]
        public string DocId { get; set; }
        public string UploadedBy { get; set; }
        public string RawFileName { get; set; }
        public string ParserName { get; set; }
        public string AssociateParserId { get; set; }
        public string OriginalDocName { get; set; }
        public string Format { get; set; }
        public string RawChild { get; set; }
        public string RawChildOnGoogle { get; set; }
        public string ProcessedChild { get; set; }
        public string ProcessedChildOnGoogle { get; set; }
        public string AppliedParsingRules { get; set; }
        public int? ParserStatus { get; set; } //0-imported,1-parsed,2-dataparsing queue,3-import queue,4-preprocessing
        public string ParsedData { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ProcessedDocInfo { get; set; }
        public int SampleFlag { get; set; }
        public string FlagStatus { get; set; }
        public string ErrorLog { get; set; }
        public int ParserType { get; set; }
    }
}

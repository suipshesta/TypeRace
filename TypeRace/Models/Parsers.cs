using System;
using System.ComponentModel.DataAnnotations;


namespace TypeRace.Models
{
    public class Parsers
    {
        [Key]
        public string ParserId { get; set; }
        public string UserId { get; set; }
        public string ParserName { get; set; }
        public string EnrolledDocs { get; set; }
        public string EnrolledRules { get; set; }
        public string SampleDoc { get; set; }
        public string WholeParsedData { get; set; }
        public int Type { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

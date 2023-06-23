using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TypeRace.Models
{
    public class ParsingRules
    {
        [Key]
        public string RuleId { get; set; }
        public string AssociateParserId { get; set; }
        public string ReferenceRuleId{get;set;}
        public string TargetSampleDocId { get; set; }
        public string ParserName { get; set; }
     
        public string UserId { get; set; }
        public string SearchOptions { get; set; }
        public string BusinessRule { get; set; }
        public string SearchResult { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; }
        public int? TargetPageNo{get;set;}
        public string OutputImage { get; set; }

    }
    public class TempRule
    {
        public string RuleId { get; set; }
        public string ReferenceRuleId { get; set; }
        public string TargetSampleDocId { get; set; }
        public string ParserName { get; set; }
        public string UserId { get; set; }
        public string SearchOptions { get; set; }
        public string SearchResult { get; set; }
        public DateTime CreatedDate { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; }
        public int? TargetPageNo { get; set; }
        public string OutputImage { get; set; }
        public string BusinessRule { get; set; }

    }

    public class TempRules
    {
        public List<TempRule> rules { get; set; }

    }

    public class ParsersDetails
    {
        public Parsers Parser { get; set; }
        public List<Object> RulesList { get; set; }
        public DocDetails DocDetails { get; set; }

    }
}

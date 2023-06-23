using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{
    public class ReturnResult
    {
        public bool Status { get; set; }
        public string SuccessMessage { get; set; }
        public string SuccessResult { get; set; }
        public string ProcessedData { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorResult { get; set; }
    }
    
}

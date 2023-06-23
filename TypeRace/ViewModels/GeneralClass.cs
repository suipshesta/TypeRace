using MailKit.Security;
using System.Collections.Generic;

namespace TypeRace.ViewModels
{
    public class ProcessedRawData
    {
        public ProcessedRawData()
        {
            //ProcessedParser = new List<Parser>();
            //RawParser = new List<Parser>();
            //IntegratedParser = new List<Parser>();
        }
        //public List<Parser> ProcessedParser { get; set; }
        //public List<Parser> RawParser { get; set; }
        //public List<Parser> IntegratedParser { get; set; }

    }
    public class PkfTable
    {
        public string Filename { get; set; }
        public string ParsedData { get; set; }
        public string Processtime { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }

    }
    public class ParseRequest
    {
        public List<TargetFile> Locationlist { get; set; }
        public List<ParsingRule> Requests { get; set; }
    }
    public class TargetFile
    {
        public string File { get; set; }
        public List<string> Locations { get; set; }
    }
    public class ParsingRule
    {
        public string Parsing_rule_name { get; set; }
        public string Request { get; set; }
        public string Position { get; set; }
        public string Extract_type { get; set; }
        public bool Case_insensitive { get; set; }
    }
    public class ApiReply
    {
        public bool Status { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
    }
    //class jsonResponse
    //{
    //    public bool status { get; set; }
    //    public string message { get; set; }
    //    public string data { get; set; }
    //}
    //public class Locations
    //{
    //    public string Original_pdf { get; set; }
    //    public Array Img_locations { get; set; }

    //}
    //public class PreprocessReq
    //{
    //    public Locations Locations { get; set; }
    //    public bool Contrast { get; set; }
    //    public int Filter { get; set; }
    //    public bool Crop { get; set; }

    //}
    public class ImgLocation
    {
        public string img_loc { get; set; }
    }

    public class TemplateLocations
    {
        public string Original_pdf { get; set; }
        public List<ImgLocation> Img_locations { get; set; }
        public string Document_id { get; set; }
        public string img_loc { get; set; }
    }

    public class LineSlipReq
    {
        public TemplateLocations Locations { get; set; }
    }

    public class ImgLoc
    {
        public string img_id { get; set; }
        public string img_loc { get; set; }
    }

    public class Pages
    {
        public string Document_id { get; set; }
        public string Original_pdf { get; set; }
        public List<ImgLoc> Img_locations { get; set; }
    }

    public class Preprocessreq
    {
        public Pages Locations { get; set; }
        public bool Contrast { get; set; }
        public int Filter { get; set; }
        public bool Crop { get; set; }
    }
    public class OriginalImage
    {
        public string img_id { get; set; }
        public string img_loc { get; set; }
    }

    public class ResultList
    {
        public string location { get; set; }
        public bool norm_values_detected { get; set; }
        public OriginalImage original_image { get; set; }
        public int page { get; set; }
    }

    public class PreprocessResponse
    {
        public string Original_pdf { get; set; }
        public List<ResultList> Result_list { get; set; }
        public bool Status { get; set; }
    }
    public class Rule
    {
        public string RuleName { get; set; }
        public bool status { get; set; }
    }
    //public class PreProcessResult
    //{
    //    public object Data { get; set; }
    //    public bool Status { get; set; }
    //    public string SuccessMessage { get; set; }
    //    public string SuccessResult { get; set; }
    //    public string ProcessedData { get; set; }
    //    public int ErrorCode { get; set; }
    //    public string ErrorMessage { get; set; }
    //    public string ErrorResult { get; set; }
    //}

   
public class MailKitEmailSenderOptions
    {
        public MailKitEmailSenderOptions()
        {
            Host_SecureSocketOptions = SecureSocketOptions.Auto;
        }

        public string Host_Address { get; set; }

        public int Host_Port { get; set; }

        public string Host_Username { get; set; }

        public string Host_Password { get; set; }

        public SecureSocketOptions Host_SecureSocketOptions { get; set; }

        public string Sender_EMail { get; set; }

        public string Sender_Name { get; set; }
    }

}

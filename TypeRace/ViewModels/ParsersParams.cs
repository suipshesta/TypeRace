using TypeRace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypeRace.ViewModels
{

    

    public class ParsersParams
    {
        public List<Locationlist> Locationlist { get; set; }
    }
   
    
    public class Crop
    {
        public bool Status { get; set; }
        public List<double> Norm_values { get; set; }

    }
    public class Temprules
    {
        public List<string> temprules { get; set; }
    }

    public class RequestList
    {
        public string Parsing_rule_name { get; set; }
        public int Request_page { get; set; }
        public string Request { get; set; }
        public string Position { get; set; }
        public string Extract_type { get; set; }
        public bool Case_insensitive { get; set; }
        public Crop Crop { get; set; }

    }

    public class LocationsAndRequest
    {
        public int h_for_norm { get; set; }
        public string location { get; set; }
        public bool normvalues_detected { get; set; }
        public string original_image { get; set; }
        public int page { get; set; }
        public int w_for_norm { get; set; }
        public int x_min { get; set; }
        public int y_min { get; set; }
        public List<RequestList> Request_list { get; set; }

    }

    public class Locationlist
    {
        public string File { get; set; }
        public List<LocationsAndRequest> Locations_and_Requests { get; set; }

    }


    public class Roi
    {
        public bool Status { get; set; }
        public List<object> Crop_coordinates { get; set; }
    }

    public class RequestsParamReq
    {
        public string Request { get; set; }
        public string Position { get; set; }
        public string Cover { get; set; }
        public bool Case_insensetive { get; set; }
    }

    public class RulesReq
    {
        public string Parsing_rule_name { get; set; }
        public int Request_page { get; set; }
        public string Extract_type { get; set; }
        public Roi Roi { get; set; }
        public RequestsParamReq Requests { get; set; }
    }

    public class ParseReq
    {
        public List<string> Document_id_list { get; set; }
        public string Template_document_id { get; set; }
        public List<RulesReq> Requests_list { get; set; }
    }

    public class GoogleDriveFileParams
    {
        public string Description { get; set; }
        public bool DriveSuccess { get; set; }
        public string EmbedUrl { get; set; }
        public string IconUrl { get; set; }
        public string LastEditedUtc { get; set; }
        public string ParentId { get; set; }
        public string ServiceId { get; set; }
        public int SizeBytes { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string MimeType { get; set; }
    }
    public class BoxFileParams
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Authenticated_download_url { get; set; }
        public string Extension { get; set; }
    }

   

}

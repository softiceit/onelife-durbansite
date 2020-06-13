//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneLifeDurban.API.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSLOGRequestHistory
    {
        public int LoginHistoryId { get; set; }
        public string SystemUserGUID { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public string URL { get; set; }
        public string QueryString { get; set; }
        public int TotalBytes { get; set; }
        public string HTTPMethod { get; set; }
        public string FormParameters { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedByUserName { get; set; }
        public string PersonIdentifier { get; set; }
        public string RequestFormObject { get; set; }
        public string UserEnvironment { get; set; }
        public string UIVersion { get; set; }
        public string DeviceUUID { get; set; }
        public string LoginGUID { get; set; }
        public Nullable<bool> IsLoginGUIDExtracted { get; set; }
        public Nullable<bool> IsMessageUpdatedWithLoginGUID { get; set; }
    }
}

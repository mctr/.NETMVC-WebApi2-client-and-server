//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meetings
    {
        public int id { get; set; }
        public string MeetingTopic { get; set; }
        public System.DateTime MeetingDate { get; set; }
        public Nullable<System.TimeSpan> MeetingStartTime { get; set; }
        public Nullable<System.TimeSpan> MeetingFinishTime { get; set; }
        public string Participants { get; set; }
    }
}
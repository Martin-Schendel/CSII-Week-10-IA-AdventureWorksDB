﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Schendel_Week_10_Individual_Assignment.Models
{
    /// <summary>
    /// Job candidate names and resumes.
    /// </summary>
    public partial class VJobCandidate
    {
        public int JobCandidateId { get; set; }
        public int? BusinessEntityId { get; set; }
        public string NamePrefix { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string NameSuffix { get; set; }
        public string Skills { get; set; }
        public string AddrType { get; set; }
        public string AddrLocCountryRegion { get; set; }
        public string AddrLocState { get; set; }
        public string AddrLocCity { get; set; }
        public string AddrPostalCode { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Schendel_Week_10_Individual_Assignment.Models
{
    /// <summary>
    /// Sales representiatives (names and addresses) and their sales-related information.
    /// </summary>
    public partial class VSalesPerson
    {
        public int BusinessEntityId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }
        public string EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceName { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegionName { get; set; }
        public string TerritoryName { get; set; }
        public string TerritoryGroup { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
    }
}
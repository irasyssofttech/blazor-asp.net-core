using System;
using System.Collections.Generic;

namespace CustomDYO.Api.DataAccess
{
    public partial class Wmsuser
    {
        public int Id { get; set; }
        public string ActivationToken { get; set; }
        public string PasswordAnswer { get; set; }
        public string PasswordQuestion { get; set; }
        public string CompanyName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool EmailConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string FaxNumber { get; set; }
        public int TimezoneId { get; set; }
        public string ShortName { get; set; }
        public string Position { get; set; }
        public string Skype { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public int? UpdatedBy { get; set; }
        public string ProfileImage { get; set; }
        public DateTime? LastLoginOnUtc { get; set; }
        public DateTime? LastPasswordChangedOnUtc { get; set; }
    }
}

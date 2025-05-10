namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    namespace AdressBookAppWeb.Models
    {
        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string UserKey { get; set; }
            public string ProfileImage { get; set; }
            public UserRole Role { get; set; }
            public DateTime RegistrationDate { get; set; }
            public DateTime? LastLoginDate { get; set; }

            public ICollection<Contact> Contacts { get; set; }
            public ICollection<Group> Groups { get; set; }
            public ICollection<AccessRequest> SentRequests { get; set; }
            public ICollection<AccessRequest> ReceivedRequests { get; set; }
            public ICollection<SharedAccess> OwnedAccesses { get; set; }
            public ICollection<SharedAccess> ViewableAccesses { get; set; }
            public ICollection<Notification> Notifications { get; set; }
            public ICollection<Log> Logs { get; set; }
            public ICollection<ContactReport> ContactReports { get; set; }
        }
    }
}

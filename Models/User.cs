namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    namespace AdressBookAppWeb.Models
    {
        public class User
        {
            public int Id { get; set; }

            [Required]
            public string FirstName { get; set; }

            [Required]
            public string LastName { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

            [Required]
            public string Phone { get; set; }

            [Required]
            public string UserKey { get; set; }

            public string ProfileImage { get; set; }

            [Required]
            public UserRole Role { get; set; }

            [Required]
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

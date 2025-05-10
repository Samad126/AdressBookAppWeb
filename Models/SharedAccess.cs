namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;

    namespace AdressBookAppWeb.Models
    {
        public class SharedAccess
        {
            public int Id { get; set; }
            public int OwnerId { get; set; }
            public int ViewerId { get; set; }
            public AccessStatus AccessStatus { get; set; }
            public DateTime GrantedDate { get; set; }
            public DateTime? RevokedDate { get; set; }

            // Navigation properties
            public User Owner { get; set; }
            public User Viewer { get; set; }
        }
    }
}

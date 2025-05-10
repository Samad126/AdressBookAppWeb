namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;

    namespace AdressBookAppWeb.Models
    {
        public class Notification
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public int? ContactId { get; set; }
            public NotificationType Type { get; set; }
            public string Message { get; set; }
            public bool IsRead { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime? ReadDate { get; set; }

            // Navigation properties
            public User User { get; set; }
            public Contact Contact { get; set; }
        }
    }
}

namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class Notification
        {
            public int Id { get; set; }

            [Required]
            public int UserId { get; set; }

            public int? ContactId { get; set; }

            [Required]
            public NotificationType Type { get; set; }

            [Required]
            public string Message { get; set; }

            [Required]
            public bool IsRead { get; set; }

            [Required]
            public DateTime CreatedDate { get; set; }

            public DateTime? ReadDate { get; set; }

            public User User { get; set; }
            public Contact Contact { get; set; }
        }
    }
}

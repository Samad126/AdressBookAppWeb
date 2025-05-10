namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class ContactReport
        {
            public int Id { get; set; }

            [Required]
            public int UserId { get; set; }

            [Required]
            public string SenderName { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Subject { get; set; }

            [Required]
            public string Message { get; set; }

            // Admin response to the contact report
            public string AdminResponse { get; set; }

            [Required]
            public ReportStatus Status { get; set; }

            [Required]
            public DateTime ReportDate { get; set; }

            public DateTime? ReviewDate { get; set; }

            public User User { get; set; }
        }
    }
}

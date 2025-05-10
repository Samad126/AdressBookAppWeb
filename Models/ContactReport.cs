namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;

    namespace AdressBookAppWeb.Models
    {
        public class ContactReport
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string SenderName { get; set; }
            public string Email { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }
            public ReportStatus Status { get; set; }
            public DateTime ReportDate { get; set; }
            public DateTime? ReviewDate { get; set; }

            public User User { get; set; }
        }
    }
}

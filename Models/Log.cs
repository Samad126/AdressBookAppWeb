namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class Log
        {
            public int Id { get; set; }
            public int? UserId { get; set; }

            [Required]
            public LogModule Module { get; set; }

            [Required]
            public LogAction Action { get; set; }

            [Required]
            public string Message { get; set; }

            [Required]
            public DateTime LogDate { get; set; }

            [Required]
            public string IPAddress { get; set; }

            public User User { get; set; }
        }
    }
}

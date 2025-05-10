namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;

    namespace AdressBookAppWeb.Models
    {
        public class Log
        {
            public int Id { get; set; }
            public int? UserId { get; set; }
            public LogModule Module { get; set; }
            public LogAction Action { get; set; }
            public string Message { get; set; }
            public DateTime LogDate { get; set; }
            public string IPAddress { get; set; }

            public User User { get; set; }
        }
    }
}

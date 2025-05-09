namespace AdressBookAppWeb.Models
{
    using AdressBookAppWeb.Models.Enums;
    using global::AdressBookAppWeb.Models.Enums;
    using System;

    namespace AdressBookAppWeb.Models
    {
        public class AccessRequest
        {
            public int Id { get; set; }
            public int RequesterId { get; set; }
            public int ReceiverId { get; set; }
            public RequestType RequestType { get; set; }
            public Direction Direction { get; set; }
            public RequestStatus Status { get; set; }
            public DateTime RequestDate { get; set; }
            public DateTime? AcceptDate { get; set; }
            public DateTime? RejectDate { get; set; }

            // Navigation properties
            public User Requester { get; set; }
            public User Receiver { get; set; }
        }
    }
}

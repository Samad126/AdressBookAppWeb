namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class AccessRequest
        {
            public int Id { get; set; }

            [Required]
            public int RequesterId { get; set; }

            [Required]
            public int ReceiverId { get; set; }

            [Required]
            public RequestType RequestType { get; set; }

            [Required]
            public Direction Direction { get; set; }

            [Required]
            public RequestStatus Status { get; set; }

            [Required]
            public DateTime RequestDate { get; set; }

            public DateTime? AcceptDate { get; set; }
            public DateTime? RejectDate { get; set; }

            public User Requester { get; set; }
            public User Receiver { get; set; }
        }
    }
}

namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class SharedAccess
        {
            public int Id { get; set; }

            [Required]
            public int OwnerId { get; set; }

            [Required]
            public int ViewerId { get; set; }

            [Required]
            public AccessStatus AccessStatus { get; set; }

            public DateTime? GrantedDate { get; set; }

            public DateTime? RevokedDate { get; set; }

            public User? Owner { get; set; }
            public User? Viewer { get; set; }
        }
    }
}

namespace AdressBookAppWeb.Models
{
    using global::AdressBookAppWeb.Models.AdressBookAppWeb.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string ContactImage { get; set; }

        [Required]
        public bool IsStarred { get; set; }

        // Comma-separated string of tags
        public string Tags { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public User User { get; set; }
        public ICollection<ContactGroup> ContactGroups { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}

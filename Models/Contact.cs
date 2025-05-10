namespace AdressBookAppWeb.Models
{
    using System;
    using System.Collections.Generic;

    public class Contact
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string ContactImage { get; set; }
        public bool IsStarred { get; set; }
        public string Tags { get; set; } // Comma-separated string of tags
        public DateTime? BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<ContactGroup> ContactGroups { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}

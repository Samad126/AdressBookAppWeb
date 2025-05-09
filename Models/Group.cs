namespace AdressBookAppWeb.Models
{
    using System;
    using System.Collections.Generic;

    namespace AdressBookAppWeb.Models
    {
        public class Group
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string GroupName { get; set; }
            public string GroupDescription { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }

            // Navigation properties
            public User User { get; set; }
            public ICollection<ContactGroup> ContactGroups { get; set; }
        }
    }
}

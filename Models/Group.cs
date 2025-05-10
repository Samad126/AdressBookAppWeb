namespace AdressBookAppWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class Group
        {
            public int Id { get; set; }

            [Required]
            public int UserId { get; set; }

            [Required]
            public string GroupName { get; set; }

            public string GroupDescription { get; set; }

            [Required]
            public DateTime CreatedDate { get; set; }

            public DateTime? UpdatedDate { get; set; }

            public User User { get; set; }
            public ICollection<ContactGroup> ContactGroups { get; set; }
        }
    }
}

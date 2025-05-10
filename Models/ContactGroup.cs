namespace AdressBookAppWeb.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace AdressBookAppWeb.Models
    {
        public class ContactGroup
        {
            public int Id { get; set; }

            [Required]
            public int ContactId { get; set; }

            [Required]
            public int GroupId { get; set; }

            public Contact Contact { get; set; }
            public Group Group { get; set; }
        }
    }
}

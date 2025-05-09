namespace AdressBookAppWeb.Models
{
    namespace AdressBookAppWeb.Models
    {
        public class ContactGroup
        {
            public int Id { get; set; }
            public int ContactId { get; set; }
            public int GroupId { get; set; }

            // Navigation properties
            public Contact Contact { get; set; }
            public Group Group { get; set; }
        }
    }
}

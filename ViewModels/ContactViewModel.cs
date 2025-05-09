using System;

namespace AdressBookAppWeb.ViewModels
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string ContactImage { get; set; }
        public bool IsStarred { get; set; }
        public string Tags { get; set; }
        public DateTime? BirthDate { get; set; }
        public string GroupName { get; set; }
    }
}
namespace AdressBookAppWeb.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserKey { get; set; }
        public string ProfileImage { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}

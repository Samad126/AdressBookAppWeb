using System;

namespace AdressBookAppWeb.ViewModels
{
    public class SharedAccessViewModel
    {
        public int Id { get; set; }
        public UserViewModel Owner { get; set; }
        public UserViewModel Viewer { get; set; }
        public string AccessStatus { get; set; }
        public DateTime GrantedDate { get; set; }
    }
}
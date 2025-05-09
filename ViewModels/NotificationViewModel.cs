using System;

namespace AdressBookAppWeb.ViewModels
{
    public class NotificationViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
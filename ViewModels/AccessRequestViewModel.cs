using System;

namespace AdressBookAppWeb.ViewModels
{
    public class AccessRequestViewModel
    {
        public int Id { get; set; }
        public UserViewModel User { get; set; }
        public string RequestType { get; set; }
        public string Direction { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? AcceptDate { get; set; }
        public DateTime? RejectDate { get; set; }
    }
}
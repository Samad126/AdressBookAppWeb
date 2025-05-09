using System;

namespace AdressBookAppWeb.ViewModels
{
    public class ContactReportViewModel
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
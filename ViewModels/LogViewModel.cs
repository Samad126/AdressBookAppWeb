using System;

namespace AdressBookAppWeb.ViewModels
{
    public class LogViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string LogType { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
        public DateTime LogDate { get; set; }
        public string IPAddress { get; set; }
    }
}
using System;
namespace ThreadAsyncDirectoryHM.Models
{
    public class Status
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime SharedDate { get; set; }

        public Status (DateTime sharedtime)
        {
            SharedDate = sharedtime;
        }

        public Status(string title , string concent)
        {
            Title = title;
            concent = concent;
        }
    }

    public void GetStatusInfo()
    {

    }
}

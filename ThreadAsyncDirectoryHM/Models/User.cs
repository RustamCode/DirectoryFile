using System;
using System.Collections.Generic;

namespace ThreadAsyncDirectoryHM.Models
{
    public class User
    {
        private static int _id;

        public int ID { get; set; }

        List<Status> Statuses = new List<Status>();

        public string UserName { get; set; }

        public User(string username)
        {
            UserName = username;
            Statuses = new List<Status>();
            _id++;
            ID = _id;
        }
        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
            DateTime sharedtime = DateTime.Now;
            
        }
        
    }
    
}

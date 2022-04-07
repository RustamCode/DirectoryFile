using System;
namespace ThreadAsyncDirectoryHM.Models.Exceptions
{
    public class NFExceprion
    {
        public void NotFoundException(int? notfound)
        {
            if (notfound == null)
            {
                throw new Exception("Not found");
            }
        }
    }
}

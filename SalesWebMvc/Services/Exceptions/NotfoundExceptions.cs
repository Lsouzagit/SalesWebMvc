using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotfoundExceptions : ApplicationException
    {
        public NotfoundExceptions(string message) : base(message)
        {

        }
    }
}

using System;

namespace Utilities.Exceptions
{
    public class ApplicationValidationExceptions : Exception
    {
        public ApplicationValidationExceptions(string message): base(message)
        {
                
        }
    }
}
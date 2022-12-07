using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    //creating my own custom exception
    internal class UserAlreadyLoginException : Exception
    {
        //default user defined constructor pointing to base class constructor
        public UserAlreadyLoginException() : base()
        {

        }

        //constructor with single parameter pointing to base class constructor
        public UserAlreadyLoginException(string message) : base(message)
        {

        }

        //constructor with 2 parameters inner exception and a message
        public UserAlreadyLoginException(string message, Exception InnerException) : base(message)
        {

        }

        //constructor for serializing
        public UserAlreadyLoginException(SerializationInfo info, StreamingContext context)
        {

        }
    }
}
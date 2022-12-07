using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    //exception is the one which effects the execution flow
    //avoids the execution flow crash when exception handlor is called 
    //exception can be handeled by using system.Exception class.
    //system.Application Exception and system.systemException.
    //system exceptions come from the system.exception class.
    //we can also custom our exceptions while coding.
    //aware of 4 keywords try, catch, finally, throw 
    //try -> holdes the code which may throw an exception
    //catch -> code which will handle exception thrown by try block
    //finally -> default code (no matter if the exception is there or not it will execute)
    //throw -> throws an exception manually

    internal class Exceptions
    {
        string[] names = new string[] { "avi", "akshatha", null , "Nayana" };

        public void ThrowException()
        {
            try
            {
                Console.WriteLine(names[2]);
            }
            //catch (IndexOutOfRangeException) {
            //    Console.WriteLine("there was an exception index out of bound occered");
            //}
            catch (NullReferenceException e)
            { Console.WriteLine("there was an exception Null Reference Exception occered {0}",e.Message); }
            finally
            {
                Console.WriteLine(names[2]);
                Console.WriteLine("an exception occered");
            }
        }

        //exception handelor for exception system.io 
        public void ioException()
        {
            //use of verbatim string litral

            int[] @string = new int[] { 2, 4, 6, 8 };

            foreach (int @for in @string)
            {
                Console.WriteLine(@for);
            }


            //making use of verbatim string litral
            //always general exception must be at the last


            try
            {
                StreamReader file = new StreamReader(@"C:\Users\User\OneDrive\Desktop\C#ALL\c# and OOPS\exception_handeling.txt");
            }
            catch (MemberAccessException e)
            {
                Console.WriteLine("file not found- exception occered {0}", e.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("finally block");
            }

        }






    }






}

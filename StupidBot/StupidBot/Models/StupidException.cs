using System;

namespace StupidBot.Models
{
    /// <author>
    ///     The Amazing Stupid Company, Inc.
    /// </author>
    public class StupidException : Exception
    {
        DateTime errorTime;
        //static  ushort errorNumber;

        public StupidException() : base("Ca marche pas !")
        {
            errorTime = DateTime.Now;
        }

        public StupidException(string message) : base(message)
        {
            errorTime = DateTime.Now;
        }

        public StupidException(string message, Exception inner) : base(message, inner)
        {
            errorTime = DateTime.Now;
        }

        public void displayError(StupidException ex)
        {
            Log.StupidLogger.Error(ex.GetType() + " " + ex.Message + " " + ex.StackTrace);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBot.Models
{
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

        public void displayError(StupidException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
}
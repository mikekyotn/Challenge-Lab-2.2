﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Lab_2._2
{
    public class ClientRecord
    {
        private string password; 
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsBlocked { get; set; }

        public string Password
        {
            //no get method since this is a password 
            set { password = value; }
        }
        public bool VerifyPassword(string passwordAttempt)
        {
            return (String.Compare(passwordAttempt, password) == 0);
        }

        public void BlockAccount ()
        {
            IsBlocked = true;
            Console.WriteLine("Your account is locked. Please contact us to unlock your account.");
        }

        public bool VerifyUser(string userNameSbumitted)
        {
            return (String.Compare(userNameSbumitted, UserName) == 0);
        }

    }
}

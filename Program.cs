namespace Challenge_Lab_2._2
{
    //This lab takes a userID and PW to check for validity, if wrong 3 times user is rejected.
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientRecord client1 = new();
            client1.FirstName = "Alfred";
            client1.LastName = "Butler";
            client1.UserName = "BatmansButler";
            client1.Password = "Alfred123";
            client1.IsBlocked = false;

            int attemptsRemaining = 3;
            bool loginVerified = false;
            string userNameAttempt = "";
            string passwordAttempt = "";
            
            while ((!loginVerified) && (attemptsRemaining > 0))
            {
                Console.Write("Please Enter UserName: ");
                userNameAttempt = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                passwordAttempt = Console.ReadLine();
            
                loginVerified = CheckCredentials(client1, userNameAttempt, passwordAttempt);
                if (loginVerified)
                {
                    Console.WriteLine("You have successfully logged in.");                    
                }
                else
                {
                    attemptsRemaining--;
                    Console.WriteLine($"You have {attemptsRemaining} attempts remaining before you account will be locked.");
                }
                
            }

            if ((attemptsRemaining == 0) && (!loginVerified))
            {
                
                client1.BlockAccount();
            }

        }

        static bool CheckCredentials(ClientRecord clientRecord, string userNameInput, string userPasswordInput)
        {
            if (clientRecord.UserName == userNameInput)
            {
                return clientRecord.VerifyPassword(userPasswordInput);
            }
            else
            {
                return false;
            }
        }
    }
}

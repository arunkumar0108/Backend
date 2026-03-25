using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    #region Custom Exception : InsufficientBalanceException
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string msg)
            : base(msg) { }
    }

    class CustomException
    {
        private double balance = 1000;

        public void Withdarw(double amount)
        {
            if (balance < amount)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance thrown amount withdraw."
                );
            }

            balance -= amount;
            Console.WriteLine($"Withdraw successful. Remaining balance: {balance}");
        }
    }
    #endregion

    #region Custom Exception : InvalidRvsUserException

    class InvalidRvsUserException : Exception
    {
        public InvalidRvsUserException(string msg)
            : base(msg) { }
    }

    class RvsUserIdValidation
    {
        public void UserNameValidation(string userId)
        {
            if (!userId.Contains("RVS-"))
            {
                throw new InvalidRvsUserException(
                    "UserId is invalid. The Id only must start with RVS-"
                );
            }

            Console.WriteLine("User Validation Successfull");
        }
    }

    #endregion

    #region Custom Exception : InvalidRvsUserNameException
    class InvalidRvsUserNameException : Exception
    {
        public InvalidRvsUserNameException(string msg)
            : base(msg) { }
    }

    public class RvsUserNameLists
    {
        public List<string> GetUserNames()
        {
            return new List<string> { "Marlin", "John", "Marcus", "Khaln", "Victory" };
        }
    }

    public class RvsUserNameValidation
    {
        private readonly RvsUserNameLists _rvsUserNameLists = new RvsUserNameLists();

        public void UserNameValidation(string userName)
        {
            List<string> userNames = _rvsUserNameLists.GetUserNames();

            if (!userNames.Contains(userName))
            {
                throw new InvalidRvsUserNameException(
                    "Entered Invalid Username. Please Enter valid user name."
                );
            }

            Console.WriteLine($"Welcome: {userName}. Username validation successfull.");
        }
    }
    #endregion

    #region Custom Exception : DuplicateUserNameException
    class DuplicateUserNameException : Exception
    {
        public DuplicateUserNameException(string msg)
            : base(msg) { }
    }

    class RvsUserNameDuplicateValidation
    {
        private readonly RvsUserNameLists _rvsUserNameLists = new RvsUserNameLists();

        public void UserNameDuplicateValidation(string userName)
        {
            List<string> userNames = _rvsUserNameLists.GetUserNames();

            if (userNames.Contains(userName))
            {
                throw new DuplicateUserNameException("This user name is already exists.");
            }

            Console.WriteLine($"This is new user name of RVS: {userName}");
        }
    }
    #endregion
}

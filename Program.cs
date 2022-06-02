using System;

namespace _220602_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker(new User());

        }   
        static void Checker(IAccount account)
        {
            account.ShowInfo();
        }
    }
    interface IAccount
    {
        public abstract void ShowInfo();
    }
    class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string _password; 
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public User (string Email, string Password)
        {
            Email = Email;
            _password = Password;
        }
        public static bool PasswordChecker(string password)
        {
            int LowerCount = 0;
            int UpperCount = 0;
            int DigitCount = 0;
            for (int i=0; i<password.Length; i++)
            {
                if (password.Length > 7)
                {
                    if (Char.IsLower(password[i]))
                    {
                        LowerCount++;
                    }
                    else if (Char.IsUpper(password[i]))
                    {
                        UpperCount++;
                    }
                    else if (Char.IsDigit(password[i]))
                    {
                        DigitCount++;
                    }
                    if (LowerCount > 0 && UpperCount > 0 && DigitCount > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Email}{FullName}");
        }
    }   
}

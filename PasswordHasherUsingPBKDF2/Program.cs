using System;

namespace PasswordHasherUsingPBKDF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter your password: "); 
            var value = Console.ReadLine();
            var salt = Salt.Create();
            var saltCreated = salt;
            
            var hash=PasswordHasher.Create(value, salt);
            var hashCreated = hash;
          

           
            var isValid = true;
            
            while (isValid == true)
            {
                Console.Write("Enter your password for validation: ");
                var password = Console.ReadLine();
                
                if (PasswordHasher.Validate(password, saltCreated, hashCreated) == true)
                {
                    Console.WriteLine("Password has been verified!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong password! Try again");
                }
               
            }

            Console.ReadLine();
        }
    }
}

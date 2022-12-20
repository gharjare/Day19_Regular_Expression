namespace RegularExpression
{
    class program
    {
        public static void Main(string[] args)
        {
            //FirstName firstName = new FirstName();
            //Console.WriteLine("please enter the pattern");
            //string name = Console.ReadLine();

            //bool value = firstName.ValidateName(name);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //LastName lastName = new LastName();
            //Console.WriteLine("please enter the pattern");
            //string name = Console.ReadLine();

            //bool value = lastName.ValidateName(name);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Email email = new Email();
            //Console.WriteLine("please enter the pattern");
            //string Email = Console.ReadLine();

            //bool value = email.ValidateEmail(Email);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Mobile mobile = new Mobile();
            //Console.WriteLine("please enter the pattern");
            //string Number = Console.ReadLine();

            //bool value = mobile.ValidateNumber(Number);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Password password = new Password();
            // Console.WriteLine("please enter the pattern");
            // string Password = Console.ReadLine();

            // bool value = password.ValidatePassword(Password);

            // if (value)
            // {
            //     Console.WriteLine("pattern is match");
            // }
            // else
            // {
            //     Console.WriteLine("pattern is not match");
            // }
            //UpperCase upperCase = new UpperCase();
            //Console.WriteLine("please enter the pattern");
            //string Upper = Console.ReadLine();

            //bool value = upperCase.ValidateUpper(Upper);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}
            //NumberInPassword password = new NumberInPassword();
            //Console.WriteLine("please enter the pattern");
            //string Numeric = Console.ReadLine();

            //bool value = password.ValidateNumeric(Numeric);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            SpecialCharacter specialCharacter = new SpecialCharacter();
            Console.WriteLine("please enter the pattern");
            string Character = Console.ReadLine();

            bool value = specialCharacter.ValidateCharacter(Character);

            if (value)
            {
                Console.WriteLine("pattern is match");
            }
            else
            {
                Console.WriteLine("pattern is not match");
            }


        }
    }
}

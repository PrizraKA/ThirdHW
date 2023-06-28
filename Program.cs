using System.Threading.Channels;
using System.Xml.XPath;

namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIRST EXERCISE //
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = firstNumber / secondNumber;
                Console.WriteLine($"The result is: {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // -------------- //

            // SECOND EXERCISE //
            Console.WriteLine("Enter the string to convert in int: ");
            string a = Console.ReadLine();
            Console.WriteLine($"String to Int is: {ConvertToInt(a)}");

            // -------------- //

            // THIRD EXERCISE //

            Console.WriteLine("Enter the string: ");
            string b = Console.ReadLine();

            try
            {
                StringIsEmpty(b);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


            // -------------- //

            // FOURTH EXERCISE //

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastname = Console.ReadLine();

            try
            {
                NameAndLastName(name, lastname);
                Console.WriteLine($"Your name and lastname is: {name + lastname}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


            // -------------- //

            // FIFTH EXERCISE //

            Console.WriteLine("Enter the string: ");
            string firstLetter = Console.ReadLine();

            try
            {

                Console.WriteLine($"The first letter of the \"{firstLetter}\" in the upper case is: {FirstLetter(firstLetter)}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


            // -------------- //

            // SIXTH EXERCISE //

            try
            {
                int first = 400000;
                int second = 500000;

                int result = OverFlowMethod(first,second);
                Console.WriteLine($"Result of {first} * {second} is: {result}");

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Error! : " + ex.Message);
            }



            // -------------- //

        }

        private static int OverFlowMethod(int first, int second)
        {
            
            long result = (long)first * second;

            if(result > int.MaxValue)
            {
                throw new OverflowException();
            }

            return (int)result;

        }

        private static object FirstLetter(string firstLetter)
        {
            if (firstLetter == "")
            {
                throw new ArgumentNullException();
            }
            else
            {
                char firstLetterToUpper = char.ToUpper(firstLetter[0]);
                return firstLetterToUpper;
            }
        }

        private static void NameAndLastName(string name, string lastname)
        {
            if (name == "" || lastname == "")
            {
                throw new ArgumentNullException();
            }
        }

        private static void StringIsEmpty(string b)
        {
            if (b == "")
            {
                throw new ArgumentNullException();
            }
            Console.WriteLine($"Length of the string: {b.Length}");
        }

        private static int ConvertToInt(string str)
        {
            try
            {
                int result = int.Parse(str);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
           
        }
    }
}
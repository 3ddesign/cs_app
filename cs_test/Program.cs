using System;

namespace cs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            static void StringModification()
            {
                string nameConcat = string.Concat("My ", "name ", "is ", "John");
                Console.WriteLine(nameConcat);

                nameConcat = string.Join(" ", "My", "name", "is", "John");
                Console.WriteLine(nameConcat);

                nameConcat = "My " + "name " + "is " + "John";

                //string newName = 
                nameConcat = nameConcat.Insert(0, "By the way, ");
                Console.WriteLine(nameConcat);

                nameConcat = nameConcat.Remove(0, 1);
                Console.WriteLine(nameConcat);

                string replaced = nameConcat.Replace('n', 'z');
                Console.WriteLine(replaced);

                string data = "12;28;34;25;64";
                string[] spliData = data.Split(';');
                string first = spliData[0];
                Console.WriteLine(first);

                char[] chars = nameConcat.ToCharArray();
                Console.WriteLine(chars[0]);
                Console.WriteLine(nameConcat[0]);

                string lower = nameConcat.ToLower();
                Console.WriteLine(lower);

                string upper = nameConcat.ToUpper();
                Console.WriteLine(upper);

                string john = " ";
                Console.WriteLine(john.Trim());
            }

            static void StringEmptiness()
            {
                string str = string.Empty; //same as ""

                string empty = "";
                string whiteSpaced = " ";
                string notEmpty = " b";
                string nullString = null;

                Console.WriteLine("IsNullOrEmpty");
                bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(empty);
                Console.WriteLine(isNullOrEmpty);

                Console.WriteLine();
                Console.WriteLine("IsNullOrWhiteSpace");

                bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
                Console.WriteLine(isNullOrWhiteSpace);
            }

            StringEmptiness();
            StringModification();
        }
    }
}

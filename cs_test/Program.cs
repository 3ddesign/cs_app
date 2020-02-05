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

            static void QueryingStrings()
            {
                string name = "abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains('E');

                Console.WriteLine(containsA);
                Console.WriteLine(containsE);

                bool endsWithAbra = name.EndsWith("abra");
                Console.WriteLine(endsWithAbra);

                bool startsWithAbra = name.StartsWith("abra");
                Console.WriteLine(startsWithAbra);

                int indexOfA = name.IndexOf('a', 1);
                Console.WriteLine(indexOfA);

                int lastIndexOfR = name.LastIndexOf('r');
                Console.WriteLine(lastIndexOfR);

                Console.WriteLine(name.Length);

                string substrFrom5 = name.Substring(5);
                string substrFromTo = name.Substring(0, 3);

                Console.WriteLine(substrFrom5);
                Console.WriteLine(substrFromTo);
            }

            static void StaticAndInstanceMembers()
            {
                string name = "abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains('E');

                Console.WriteLine(containsA);
                Console.WriteLine(containsE);

                string abc = string.Concat("a", "b", "c");
                Console.WriteLine(abc);

                Console.WriteLine(int.MinValue);

                int x = 1;
                string xStr = x.ToString();
                Console.WriteLine(xStr);
                Console.WriteLine(x);
            }

            static void ComparisonOperators()
            {
                int x = 1;
                int y = 2;

                bool areEqual = x == y;
                Console.WriteLine(areEqual);

                bool result = x > y;
                Console.WriteLine(result);

                result = x >= y;
                Console.WriteLine(result);

                result = x < y;
                Console.WriteLine(result);

                result = x <= y;
                Console.WriteLine(result);

                result = x != y;

                Console.WriteLine(result);
            }

            static void MathOperations()
            {
                int x = 1;
                int y = 2;

                int z = x + y;
                int k = x - y;
                int a = z + k - y;

                Console.WriteLine(z);
                Console.WriteLine(k);
                Console.WriteLine(a);

                int b = z * 2;
                int c = k / 2;

                Console.WriteLine(b);
                Console.WriteLine(c);

                a = 4 % 2;
                b = 5 % 2;

                Console.WriteLine(a);
                Console.WriteLine(b);

                a = 3;
                a = a * a;
                //a = a * a * a;
                Console.WriteLine(a);

                a = (2 + 2) * 2;
                Console.WriteLine(a);
                a *= 2;
                //a = a * 2
                Console.WriteLine(a);
                a /= 2;
                //a = a / 2
                Console.WriteLine(a);
            }

            static void IncrementDecrementDemo()
            {
                int x = 1;
                x = x + 1;
                Console.WriteLine(x);

                x++;
                Console.WriteLine(x);

                ++x;
                Console.WriteLine(x);

                x = x - 1;
                x--;
                --x;

                Console.WriteLine(x);

                Console.WriteLine("Learn about increments");
                Console.WriteLine($"Last x state is {x}");

                int j = x++;
                Console.WriteLine(j);
                Console.WriteLine(x);

                j = ++x;
                Console.WriteLine(j);
                Console.WriteLine(x);

                x += 2;
                // x = x + 2
                Console.WriteLine(x);

                j -= 2;
                //j = j - 2
                Console.WriteLine(j);
            }

            static void MathDemo()
            {
                Console.WriteLine(Math.Pow(2, 3));
                Console.WriteLine(Math.Sqrt(9));
                Console.WriteLine(Math.Sqrt(8));

                Console.WriteLine(Math.Round(1.7));
                Console.WriteLine(Math.Round(1.4));

                Console.WriteLine();

                Console.WriteLine(Math.Round(2.5));
                Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
                Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
            }

            static void Overflow()
            {
                checked
                {
                    uint x = uint.MaxValue;

                    Console.WriteLine(x);

                    x = x + 1;

                    Console.WriteLine(x);

                    x = x - 1;

                    Console.WriteLine(x);
                }
            }

            static void VariablesScope()
            {
                var a = 1;
                {
                    var b = 2;
                    {
                        var c = 3;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    //Console.WriteLine(c);
                }
                Console.WriteLine(a);
                //Console.WriteLine(b);
                //Console.WriteLine(c);
            }

        }
    }
}

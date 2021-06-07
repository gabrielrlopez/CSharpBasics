using System;
using System.Collections.Generic;


namespace CSharpBasics
{
    class Program
    {

        static void StatusLikes()
        {
            var friendLikes = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();

                if (name == "") break;

                var count = friendLikes.Count;

                friendLikes.Add(name);

                if (friendLikes.Count == 1)
                {
                    System.Console.WriteLine("{0} likes your post.", friendLikes[0]);
                }
                else if (friendLikes.Count == 2)
                {
                    System.Console.WriteLine("{0} and {1} likes your post.", friendLikes[0], friendLikes[1]);
                }
                else if (friendLikes.Count > 2)
                {
                    System.Console.WriteLine("{0}, {1}, and {2} others like your post.", friendLikes[0], friendLikes[1], count);
                }
            }
        }

        static void ReversedName()
        {
            Console.Write("Enter a name: ");
            var name = Console.ReadLine();

            var nameArr = new List<char>();

            for (var i = 0; i < name.Length; i++)
            {
                nameArr.Add(name[i]);
            }

            nameArr.Reverse();
            var reversedName = new string(nameArr.ToArray());
            System.Console.WriteLine(reversedName);
        }

        static void FiveNumbers()
        {
            var numList = new List<int>();
            while (true)
            {
                Console.Write("Enter a number: ");
                var num = Convert.ToInt32(Console.ReadLine());

                if (numList.Contains(num))
                {
                    Console.Write("You already entered that number. Enter a new number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }


                numList.Add(num);

                if (numList.Count == 5)
                {
                    numList.Sort();

                    foreach (var number in numList)
                    {
                        System.Console.WriteLine(number);
                    }
                    break;
                }
            }
        }

        static void UniqueNumbers()
        {
            var uniqueNums = new List<int>();
            var allNums = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or enter 'Quit' to exit:  ");

                var input = Console.ReadLine();
                if (input == "Quit") break;

                var num = Convert.ToInt32(input);

                if (!allNums.Contains(num))
                {
                    uniqueNums.Add(num);
                    foreach (var number in uniqueNums)
                    {
                        System.Console.WriteLine(number);
                    }
                }
                else
                {
                    uniqueNums.Remove(num);
                    foreach (var number in uniqueNums)
                    {
                        System.Console.WriteLine(number);
                    }
                }

                allNums.Add(num);
            }
        }

        static void ThreeSmallestNumbers()
        {
            while (true)
            {
                Console.Write("Enter a minimum of 5 numbers seperated by commas: ");
                var input = Console.ReadLine();

                var numArr = input.Split(',');

                if (numArr.Length < 5)
                {
                    Console.Write("Invalid list please try again: ");
                    input = Console.ReadLine();
                    numArr = input.Split(',');
                }

                Array.Sort(numArr);

                for (var i = 0; i < 3; i++)
                {
                    System.Console.WriteLine(numArr[i]);
                }

                break;
            }
        }


        static void Main(string[] args)
        {
            ThreeSmallestNumbers();
        }
    }
}

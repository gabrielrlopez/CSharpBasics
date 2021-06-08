using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class StringUtility
    {
        public static string SummarisingText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;


            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }

        public static string ConsecutiveOrNot(string numbers)
        {
            var numArr = numbers.Split('-');

            Array.Sort(numArr);

            for (var i = 0; i < numArr.Length - 1; i++)
            {
                if (Convert.ToInt32(numArr[i]) + 1 != Convert.ToInt32(numArr[i + 1])) return "Not consecutive";
            }

            return "Consecutive";
        }


        public static string CheckForDupes(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers)) return "Goodbye";

            var numArr = numbers.Split('-');

            for (var i = 0; i < numArr.Length; i++)
            {
                var firstOccurence = Array.IndexOf(numArr, numArr[i]);
                var duplicate = Array.LastIndexOf(numArr, numArr[i]);
                if (firstOccurence != duplicate) return "Duplicate";
            }

            return "No duplicates";
        }

        public static string ValidTime(string time)
        {
            var validTime = "23:59";

            var validTimeArr = validTime.Split(":");

            var givenTime = time.Split(":");

            for (var i = 0; i < validTime.Length; i++)
            {
                if (Convert.ToInt32(givenTime[0]) > Convert.ToInt32(validTimeArr[0]) || Convert.ToInt32(givenTime[0]) < 0)
                    return "Invalid time";

                if (Convert.ToInt32(givenTime[1]) > Convert.ToInt32(validTimeArr[1]) || Convert.ToInt32(givenTime[1]) < 0)
                    return "Invalid time";
            }

            return "Ok";
        }

        public static string PascalCaseVariableGenerator(string text)
        {
            var lowerCase = text.ToLower();
            var wordArr = lowerCase.Split(" ");
            var variable = new StringBuilder();

            for (var i = 0; i < wordArr.Length; i++)
            {
                var word = wordArr[i];
                var capitalizedLetter = word[0].ToString().ToUpper().ToCharArray();
                var upperCasedWord = variable.Append(word.Replace(word[0], capitalizedLetter[0]));
            }

            return variable.ToString();
        }

        public static int NumberOfVowels(string word)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;

            var wordLetterArr = word.ToCharArray();


            for (var i = 0; i < wordLetterArr.Length; i++)
            {
                if (vowels.Contains(wordLetterArr[i])) count++;
            }

            return count;
        }
    }
}
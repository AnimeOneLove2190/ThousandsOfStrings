using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TextService
    {
        //Што это??
        readonly TechnicalService techService = new TechnicalService();
        //Quest03
        public string[] CreateArrayOfWords(string text)
        {
            string clearText = techService.ClearText(text);
            string[] wordsArray = clearText.Split(" ");
            return wordsArray;
        }
        //Quest04
        public int GetCountOfSearchWords(string text, string searchWord)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfSearchWords");
                return 0;
            }
            string clearText = techService.ClearText(text);
            int countOfSearchWords = 0;
            string[] wordsArray = clearText.Split(" ");
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i] == searchWord)
                {
                    countOfSearchWords++;
                }
            }
            return countOfSearchWords;
        }
        //Quest11
        public string GetFirstLetterInWord(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            string firstLetter = clearText.Substring(0, 1);
            return firstLetter;
        }
        //Quest12
        public string UpFirstLetterInWord(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            charArray[0] = char.ToUpper(charArray[0]);
            clearText = new string(charArray);
            return clearText;
        }
        //Quest13
        public string GetSurnameAndInitials(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            string[] initials = new string[2];
            int savedCounter = 0;
            char[] charSurname = new char[text.Length];
            for (int i = 1; i <= charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charSurname = new char[i];
                    for (int j = 0; j < charSurname.Length; j++)
                    {
                        charSurname[j] = charArray[j];
                    }
                    savedCounter = i;
                    break;
                }
            }
            for (int i = savedCounter, j = 0; i < clearText.Length && j < initials.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    initials[j] = $"{charArray[i]}";
                    j++;
                }
            }
            string surname = new string(charSurname);
            string surnameAndInitials = $"{surname} {initials[0]}. {initials[1]}.";
            return surnameAndInitials;
        }
        //Quest14
        public string GetSubstring(string text, int firstLetter, int lastLetter)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            if (firstLetter < 0 || lastLetter >= clearText.Length)
            {
                return null;
            }
            string substring = clearText.Substring(firstLetter, lastLetter);
            return substring;
        }
        //Quest15
        public string GetRussianAlphabet()
        {
            const int startLetter = 1072;
            const int endLetter = 1103;
            const int ё = 1105;
            char[] charArray = new char[endLetter - startLetter + 2];
            for (int i = startLetter, j = startLetter, z = 0; z < charArray.Length; z++, i++)
            {
                if (i == 1078)
                {
                    charArray[z] = (char)ё;
                    continue;
                }
                charArray[z] = (char)j;
                j++;
            }
            string alphabetLower = new string(charArray);
            string alphabetUpper = alphabetLower.ToUpper();
            string alphabetFull = $"{alphabetLower}{alphabetUpper}";
            return alphabetFull;
        }
    }
}

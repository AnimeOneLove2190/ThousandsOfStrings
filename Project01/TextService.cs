using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TextService
    {
        //Зелёненькие квесты
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
                Console.WriteLine("Сработала защита в UpFirstLetterInWord");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
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
                Console.WriteLine("Сработала защита в GetSurnameAndInitials");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
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
                Console.WriteLine("Сработала защита в GetSubstring");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
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
        //Quest16
        public string GetEnglishAlphabet()
        {
            const int startLetter = 97;
            const int endLetter = 122;
            char[] charArray = new char[endLetter - startLetter + 1];
            for (int i = startLetter, j = 0; j < charArray.Length; i++, j++)
            {
                charArray[j] = (char)i;
            }
            string alphabetLower = new string(charArray);
            string alphabetUpper = alphabetLower.ToUpper();
            string alphabetFull = $"{alphabetLower}{alphabetUpper}";
            return alphabetFull;
        }
        //Quest17
        public int GetCountOfRussianLetters(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfRussianLetters");
                return 0;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            const int startLetter = 1040;
            const int endLetter = 1103;
            const int ё = 1105;
            const int Ё = 1025;
            int countOfRussianLetters = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] >= startLetter) && (charArray[i] <= endLetter) || charArray[i] == ё || charArray[i] == Ё)
                {
                    countOfRussianLetters++;
                }
            }
            return countOfRussianLetters;
        }
        //Quest18
        public int GetCountOfEnglishLetters(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfEnglishLetters");
                return 0;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            const int startLetterLow = 65;
            const int endLetterLow = 90;
            const int startLetterUp = 97;
            const int endLetterUp = 122;
            int countOfEnglishLetters = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] >= startLetterLow) && (charArray[i] <= endLetterLow) || (charArray[i] >= startLetterUp) && (charArray[i] <= endLetterUp))
                {
                    countOfEnglishLetters++;
                }
            }
            return countOfEnglishLetters;
        }
        //Quest20
        public string GetMostFrequentLetter(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetMostFrequentLetter");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < clearText.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            string mostFrequentLetter = string.Empty;
            int[] countsOfLetters = new int[clearText.Length];
            int maxValue = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                countsOfLetters[i] = 0;
            }
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        countsOfLetters[i]++;
                    }
                }
            }
            for (int i = 0; i < countsOfLetters.Length; i++)
            {
                if (maxValue < countsOfLetters[i])
                {
                    maxValue = countsOfLetters[i];
                }
            }
            for (int i = 0; i < countsOfLetters.Length; i++)
            {
                if (countsOfLetters[i] == maxValue)
                {
                    mostFrequentLetter = $"{charArray[i]}";
                    return mostFrequentLetter;
                }
            }
            return mostFrequentLetter;
        }
        //Quest21
        public string ReverseText(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в ReverseText");
                return null;
            }
            char[] reversedCharArray = new char[clearText.Length];
            for (int i = 0, j = clearText.Length - 1; i < clearText.Length && j >= 0; i++, j--)
            {
                reversedCharArray[i] = clearText[j];
            }
            string reversedText = new string(reversedCharArray);
            return reversedText;
        }
    }
}

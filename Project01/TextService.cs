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
        //Quest06
        public int GetCountOfSearchLetter(string text, char searchSymbol)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfSearchWords");
                return 0;
            }
            text = text.ToLower();
            int countOfSearchWords = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == searchSymbol)
                {
                    countOfSearchWords++;
                }
            }
            return countOfSearchWords;
        }
        //Quest11
        public char GetFirstLetterInWord(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return ' ';
            }
            char firstLetter = text[0];
            return firstLetter;
        }
        //Quest12
        public string UpFirstLetterInWord(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в UpFirstLetterInWord");
                return null;
            }
            char[] charArray = text.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            text = new string(charArray);
            return text;
        }
        //Quest13
        public string GetSurnameAndInitials(string surname, string name, string fatherName)
        {
            if (string.IsNullOrEmpty(surname) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(fatherName) || string.IsNullOrWhiteSpace(fatherName))
            {
                Console.WriteLine("Сработала защита в GetSurnameAndInitials");
                return null;
            }
            char[] surnameArray = surname.ToCharArray();
            surnameArray[0] = char.ToUpper(surnameArray[0]);
            surname = new string(surnameArray);
            return $"{surname} {char.ToUpper(name[0])}. {char.ToUpper(fatherName[0])}.";
        }
        //Quest14
        public string GetSubstring(string text, int firstIndex, int arrayLength)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetSubstring");
                return null;
            }
            if (firstIndex < 0 || arrayLength > text.Length)
            {
                Console.WriteLine("Указанная длина подстроки превышает длину исходной строки");
                return null;
            }
            var substring = string.Empty;
            for (int i = 0, j = firstIndex; i <= arrayLength - 1; i++, j++)
            {
                if (j <= text.Length - 1)
                {
                    substring = $"{substring}{text[j]}";
                }
                else
                {
                    Console.WriteLine("Искомый элемент для подстроки вышел за границу исходной строки");
                    break;
                }
            }
            return substring;
        }
        //Quest15
        public string GetRussianAlphabet()
        {
            const int startLetter = 1072;
            const int endLetter = 1103;
            const int YoLower = 1105;
            char[] charArray = new char[endLetter - startLetter + 2];
            for (int i = startLetter, j = startLetter, z = 0; z < charArray.Length; z++, i++)
            {
                if (i == 1078)
                {
                    charArray[z] = (char)YoLower;
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
            if (string.IsNullOrEmpty((string)text) || string.IsNullOrWhiteSpace((string)text))
            {
                Console.WriteLine("Сработала защита в GetCountOfRussianLetters");
                return 0;
            }
            const int startLetter = 1040;
            const int endLetter = 1103;
            const int YoLower = 1105;
            const int YoUpper = 1025;
            int countOfRussianLetters = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= startLetter) && (text[i] <= endLetter) || text[i] == YoLower || text[i] == YoUpper)
                {
                    countOfRussianLetters++;
                }
            }
            return countOfRussianLetters;
        }
        //Quest18
        public int GetCountOfEnglishLetters(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfEnglishLetters");
                return 0;
            }
            const int startLetterLow = 65;
            const int endLetterLow = 90;
            const int startLetterUp = 97;
            const int endLetterUp = 122;
            int countOfEnglishLetters = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= startLetterLow) && (text[i] <= endLetterLow) || (text[i] >= startLetterUp) && (text[i] <= endLetterUp))
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
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
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
            text = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в ReverseText");
                return null;
            }
            char[] reversedCharArray = new char[text.Length];
            for (int i = 0, j = text.Length - 1; i < text.Length && j >= 0; i++, j--)
            {
                reversedCharArray[i] = text[j];
            }
            string reversedText = new string(reversedCharArray);
            return reversedText;
        }
        //Жёлтенькие квесты
        //Quest01
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в IsPalindrome");
                return false;
            }
            text = text.ToLower();
            for (int i = 0, j = text.Length - 1; i < text.Length && j >= 0; i++, j--)
            {
                if (text[i] != text[j])
                {
                    return false;
                }
            }
            return true;
        }
        //Quest02
        public bool IsAnagram(string textOne, string textTwo)
        {
            if (string.IsNullOrEmpty(textOne) || string.IsNullOrWhiteSpace(textOne) || string.IsNullOrEmpty(textTwo) || string.IsNullOrWhiteSpace(textTwo))
            {
                Console.WriteLine("Сработала защита в IsAnagram");
                return false;
            }
            textOne = textOne.ToLower();
            textTwo = textTwo.ToLower();
            if (!(textOne.Length == textTwo.Length))
            {
                return false;
            }
            char[] charArrayOne = new char[textOne.Length];
            char[] charArrayTwo = new char[textTwo.Length];
            for (int i = 0; i < textOne.Length; i++)
            {
                charArrayOne[i] = textOne[i];
                charArrayTwo[i] = textTwo[i];
            }
            techService.BubbleSort(charArrayOne);
            techService.BubbleSort(charArrayTwo);
            textOne = new string(charArrayOne);
            textTwo = new string(charArrayTwo);
            if (textOne != textTwo)
            {
                return false;
            }
            return true;
        }
        //Quest09
        public string[] SplitTextByLetter(string text, char seletcedLetter)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
            {
                Console.WriteLine("Сработала защита в SplitTextByLetter");
                return null;
            }
            int savedCounter = 0;
            int savedCounterPlus = 0;
            int countOfSelectedLetter = GetCountOfSearchLetter(clearText, seletcedLetter);
            string[] curvaArray = new string[countOfSelectedLetter + 1];
            for (int i = 0, o = 0; i < clearText.Length; i++)
            {
                if (clearText[i] == seletcedLetter)
                {
                    char[] charArray = new char[i - savedCounter];
                    for (int j = 0, z = savedCounter; j < charArray.Length && z < clearText.Length; j++, z++)
                    {
                        charArray[j] = clearText[z];
                    }
                    curvaArray[o] = new string(charArray);
                    o++;
                    savedCounter = i + 1;
                    savedCounterPlus = o;
                }
            }
            for (int i = savedCounter; i < clearText.Length; i++)
            {
                char[] charArray = new char[clearText.Length - savedCounter];
                for (int j = 0, z = savedCounter; j < clearText.Length && z < clearText.Length; j++, z++)
                {
                    charArray[j] = clearText[z];
                }
                curvaArray[savedCounterPlus] = new string(charArray);
            }
            return curvaArray;
        }
        //Quest22
        public int GetCountOfWords(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
            {
                Console.WriteLine("Сработала защита в GetCountOfWords");
                return 0;
            }
            int countOfSpaces = 1;
            for (int i = 0; i < clearText.Length; i++)
            {
                if (char.IsWhiteSpace(clearText[i]))
                {
                    countOfSpaces++;
                }
            }
            return countOfSpaces;
        }
        //Quest24
        public string GetLongestWord(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
            {
                Console.WriteLine("Сработала защита в GetLongestWord");
                return null;
            }
            string[] wordsArray = clearText.Split(" ");
            int maxValue = 0;
            string longestWord = string.Empty;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (maxValue < wordsArray[i].Length)
                {
                    maxValue = wordsArray[i].Length;
                    longestWord = wordsArray[i];
                }
            }
            return longestWord;
        }
        //Quest25
        public int GetLongestSubstringLength(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetLongestSubstringLength");
                return 0;
            }
            char[] charArray = text.ToCharArray();
            int[] countsOfLetters = new int[text.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i; j < charArray.Length; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        countsOfLetters[i]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int maxValue = 0;
            for (int i = 0; i < countsOfLetters.Length; i++)
            {
                if (maxValue < countsOfLetters[i])
                {
                    maxValue = countsOfLetters[i];
                }
            }
            return maxValue;
        }
        //Quest27
        public int GetCountOfDigits(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfDigits");
                return 0;
            }
            int countOfDigits = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    countOfDigits++;
                }
            }
            return countOfDigits;
        }
    }
}

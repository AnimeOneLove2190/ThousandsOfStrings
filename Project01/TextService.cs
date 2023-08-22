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
    }
}

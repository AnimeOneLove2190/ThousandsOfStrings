using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            TextService textService = new TextService();
            string meaninglessTextOne = " Some  text,. for(( test!@#$%^&*()_+<>:{}!№;%:?*()_+,ЭЪ/лллююю/*-+";
            //Quest03
            string[] arrayOfWords = textService.CreateArrayOfWords(meaninglessTextOne);
            techService.Write1DArray(arrayOfWords);
            //Quest04
            int countOfSearchWords = textService.GetCountOfSearchWords(meaninglessTextOne, "text");
            Console.WriteLine(countOfSearchWords);
            //Quest06
            int countOfSearchLetter = textService.GetCountOfSearchLetter(meaninglessTextOne, 't');
            Console.WriteLine(countOfSearchLetter);
            //Quest11
            string firstLetter = textService.GetFirstLetterInWord(meaninglessTextOne);
            Console.WriteLine(firstLetter);
            //Quest12
            string name = "mikasa Akkerman";
            string upperName = textService.UpFirstLetterInWord(name);
            Console.WriteLine(upperName);
            //Quest13
            string fio = "Зубенко Михаил Петрович";
            string surnameAndInitials = textService.GetSurnameAndInitials(fio);
            Console.WriteLine(surnameAndInitials);
            //Quest14
            string substring = textService.GetSubstring(fio, 1, 22);
            Console.WriteLine(substring);
            //Quest15
            string russianAlphabet = textService.GetRussianAlphabet();
            Console.WriteLine(russianAlphabet);
            //Quest16
            string englishAlphabet = textService.GetEnglishAlphabet();
            Console.WriteLine(englishAlphabet);
            //Quest17
            int countOfRussianLetters = textService.GetCountOfRussianLetters(meaninglessTextOne);
            Console.WriteLine(countOfRussianLetters);
            //Quest18
            int countOfEnglishLetters = textService.GetCountOfEnglishLetters(meaninglessTextOne);
            Console.WriteLine(countOfEnglishLetters);
            //Quest20
            string mostFrequentLetter = textService.GetMostFrequentLetter(fio);
            Console.WriteLine(mostFrequentLetter);
            //Quest21
            string reversedText = textService.ReverseText(fio);
            Console.WriteLine(reversedText);
            //Жёлтенькие квесты
            //Quest01
            string kek = "saippuakivikauppias";
            bool isPalindrome = textService.IsPalindrome(kek);
            Console.WriteLine(isPalindrome);
            //Quest02
            string moshkara = "Мошкара";
            string romashka = "Ромашка";
            bool isAnagram = textService.IsAnagram(moshkara, romashka);
            Console.WriteLine(isAnagram);
            //Quest09
            char curvaLetter = 'и';
            string[] curvaArray = textService.SplitTextByLetter(fio, curvaLetter);
            techService.Write1DArray(curvaArray);
            //Quest22
            int countOfWords = textService.GetCountOfWords(meaninglessTextOne);
            Console.WriteLine(countOfWords);
            //Quest24
            string longestWord = textService.GetLongestWord(meaninglessTextOne);
            Console.WriteLine(longestWord);
            //Quest25
            int longestSubstringLength = textService.GetLongestSubstringLength(meaninglessTextOne);
            Console.WriteLine(longestSubstringLength);
            //Quest27
            int countOfDigits = textService.GetCountOfDigits(meaninglessTextOne);
            Console.WriteLine(countOfDigits);
        }
    }
}

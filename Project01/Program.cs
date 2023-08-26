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
            string alphabet = textService.GetRussianAlphabet();
            Console.WriteLine(alphabet);
        }
    }
}

using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            TextService textService = new TextService();
            //Quest03
            string meaninglessTextOne = " Some  text,. for(( test!@#$%^&*()_+<>:{}!№;%:?*()_+,ЭЪ/лллююю/*-+";
            string[] arrayOfWords = textService.CreateArrayOfWords(meaninglessTextOne);
            techService.Write1DArray(arrayOfWords);
            //Quest04
            int countOfSearchWords = textService.GetCountOfSearchWords(meaninglessTextOne, "text");
            Console.WriteLine(countOfSearchWords);
            //Quest11
            string firstLetter = textService.GetFirstLetterInWord(meaninglessTextOne);
            Console.WriteLine(firstLetter);
        }
    }
}

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
            string name = "mikasa Akkerman";
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
            string upperName = textService.UpFirstLetterInWord(name);
            Console.WriteLine(upperName);
        }
    }
}

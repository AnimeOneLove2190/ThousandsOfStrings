using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TechnicalService
    {
        public void Write1DArray(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public string ClearText(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в начальном сегменте ClearText");
                return null;
            }
            char[] copy = text.ToCharArray();
            const char Space = ' ';
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) || char.IsSymbol(text[i]) || char.IsWhiteSpace(text[i]) || char.IsPunctuation(text[i]))
                {
                    copy[i] = Space;
                }
            }
            text = new string(copy);
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            if (char.IsWhiteSpace(text[0]))
            {
                text = text.Trim();
            }
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Сработала защита в последнем сегменте ClearText");
                return null;
            }
            return text;
        }
        public void BubbleSort(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length - i - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        int temporaryStorage = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = (char)temporaryStorage;
                    }
                }
            }
        }
    }
}

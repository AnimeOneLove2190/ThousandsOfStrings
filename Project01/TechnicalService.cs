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
            char[] copy = new char[text.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = text[i];
            }
            const char Space = (char)32;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) || char.IsSymbol(text[i]) || char.IsWhiteSpace(text[i]) || char.IsPunctuation(text[i]))
                {
                    copy[i] = Space;
                }
            }
            string textCopy = new string(copy);
            while (textCopy.Contains("  "))
            {
                textCopy = textCopy.Replace("  ", " ");
            }
            if (char.IsWhiteSpace(copy[0]))
            {
                textCopy = textCopy.Trim();
            }
            if (string.IsNullOrEmpty(textCopy))
            {
                Console.WriteLine("Сработала защита в последнем сегменте ClearText");
                return null;
            }
            return textCopy;
        }
    }
}

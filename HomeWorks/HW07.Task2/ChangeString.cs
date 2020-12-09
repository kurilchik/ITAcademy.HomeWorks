using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW07.Task2
{
    public class ChangeString
    {
        public static void RemoveLongestWord(string text)
        {
            string[] texts = text.Split(' ');

            int indexMaxWord = 0;
            int maxWord = texts[0].Length;

            for (int i = 1; i < texts.Length; i++)
            {
                if (maxWord < texts[i].Length)
                {
                    maxWord = texts[i].Length;
                    indexMaxWord = i;
                }
            }

            Console.WriteLine("New line without the longest word:");
            for (int i = 0; i < texts.Length; i++)
            {
                if (i != indexMaxWord)
                {
                    Console.Write($"{texts[i]} ");
                }
            }
            Console.WriteLine(string.Empty);
        }

        public static void ReplaceMaxMinWord(string text)
        {
            string[] texts = text.Split(' ');

            int indexMaxWord = 0;
            int maxWord = texts[0].Length;

            for (int i = 1; i < texts.Length; i++)
            {
                if (maxWord < texts[i].Length)
                {
                    maxWord = texts[i].Length;
                    indexMaxWord = i;
                }
            }

            int indexMinWord = 0;
            int minWord = texts[0].Length;

            for (int i = 1; i < texts.Length; i++)
            {
                if (minWord > texts[i].Length)
                {
                    minWord = texts[i].Length;
                    indexMinWord = i;
                }
            }

            string temp = texts[indexMaxWord];
            texts[indexMaxWord] = texts[indexMinWord];
            texts[indexMinWord] = temp;

            Console.WriteLine("A new line in which the longest word with the shortest word has been swapped:");
            foreach (var item in texts)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(string.Empty);
        }

        public static void CountLettersAndPunctuation(string text)
        {
            Console.WriteLine($"Your string contains {text.Count(char.IsLetter)} letters");
            Console.WriteLine($"Your string contains {text.Count(char.IsPunctuation)} punctuation marks");
        }

        public static void SortString(string text)
        {
            string[] texts = text.Split(' ');

            string temp = string.Empty;
            for (int i = 0; i < texts.Length - 1; i++)
            {
                for (int j = i + 1; j < texts.Length; j++)
                {
                    if (texts[i].Length < texts[j].Length)
                    {
                        temp = texts[i];
                        texts[i] = texts[j];
                        texts[j] = temp;
                    }
                }
            }

            Console.WriteLine("A new sorted line:");
            foreach (var item in texts)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

using System;
using System.IO;

namespace HW02.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true); //открытие потока для считывания текста из файла
            string textReaderResult = textReader.ReadToEnd(); //записываем все символы, начиная с текущей позиции до конца потока, в переменную textReaderResult
            textReader.Dispose(); //закрывает основной поток

            string[] arrayOfTextResult = textReaderResult.Split(' '); // создаем массив string[] arrayOfTextResult, из строки textReaderResult, разделяя её ' '

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1]; // создаем массив byte[] imageBytes
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++) // цикл для наполнения массива imageBytes, преобразуя массив arrayOfTextResult
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2); //создание временной переменной byte binary, в которую записывается преобразованный i-ый элемент массива arrayOfTextResult
                imageBytes[i] = binary; //наполнения массива imageBytes, от 0-ого до "arrayOfTextResult.Length - 1"-ого элемента
            }

            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes); //создает новый файл, записывает в него указанный массив байтов и затем закрывает файл 
        }
    }
}

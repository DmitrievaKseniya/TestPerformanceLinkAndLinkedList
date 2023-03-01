using System.Diagnostics;

namespace Task_13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите пусть к файлу для тестирования производительности:");
            string file = Console.ReadLine();

            //Прочитаем файл в  List
            var stopWatchList = Stopwatch.StartNew();

            var linesList = new List<string>();
            foreach (string line in File.ReadLines(file))
            {
                linesList.Add(line);
            }
            stopWatchList.Stop();
            Console.WriteLine($"Запись данных из файла в List: {stopWatchList.Elapsed.TotalMilliseconds} мс");

            //Прочитаем файл в LinkedList
            var stopWatchLinkedList = Stopwatch.StartNew();

            var linesLinkedList = new LinkedList<string>();
            foreach (string line in File.ReadLines(file))
            {
                linesLinkedList.AddFirst(line);
            }
            stopWatchLinkedList.Stop();
            Console.WriteLine($"Запись данных из файла в LinkedList: {stopWatchLinkedList.Elapsed.TotalMilliseconds} мс");

            if (stopWatchList.Elapsed.TotalMilliseconds > stopWatchLinkedList.Elapsed.TotalMilliseconds)
            {
                Console.WriteLine("Вывод: добавление в LinkedList работает быстрее");
            }
            else if (stopWatchList.Elapsed.TotalMilliseconds < stopWatchLinkedList.Elapsed.TotalMilliseconds)
            {
                Console.WriteLine("Вывод: добавление в List работает быстрее");
            }
            else
            {
                Console.WriteLine("Вывод: время добавления данных равно");
            }
        }
    }
}
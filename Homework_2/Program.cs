namespace Homework_2;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        //Создать коллекции List, ArrayList и LinkedList
        List<int> myList = new List<int>();
        ArrayList myArrayList = new ArrayList();
        LinkedList<int> myLinkedList = new LinkedList<int>();

        //С помощью цикла for добавить в каждую 1 000 000 элементов(1, 2, 3, ...).
        //С помощью Stopwatch.Start() и Stopwatch.Stop() замерить длительность заполнения каждой коллекции и вывести значения на экран.
        var stopWatch = new Stopwatch(); // создала объект для измерения времени
        int count = 1000000;
        stopWatch.Start();
        for (int i = 1; i <= count; i++)
        {
            myList.Add(i);
        }
        stopWatch.Stop();
        Console.WriteLine("Время заполнения myList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        for (int i = 1; i <= count; i++)
        {
            myArrayList.Add(i);
        }
        stopWatch.Stop();
        Console.WriteLine("Время заполнения myArrayList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        for (int i = 1; i <= count; i++)
        {
            myLinkedList.AddLast(i);
        }
        stopWatch.Stop();
        Console.WriteLine("Время заполнения myLinkedList " + stopWatch.Elapsed.TotalMilliseconds);

        //Найти 496753-ий элемент, замерить длительность этого поиска и вывести на экран.
        const int index = 496753;
        stopWatch.Restart();
        int value = myList[index];
        stopWatch.Stop();
        Console.WriteLine("Поиск 496753-го элемента занял для myList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        var value2 = myArrayList[index];
        stopWatch.Stop();
        Console.WriteLine("Поиск 496753-го элемента занял для myArrayList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        int value3 = myLinkedList.ElementAt(index);
        stopWatch.Stop();
        Console.WriteLine("Поиск 496753-го элемента занял для myLinkedList " + stopWatch.Elapsed.TotalMilliseconds);

        //Вывести на экран каждый элемент коллекции, который без остатка делится на 777. Вывести длительность этой операции для каждой коллекции.
        stopWatch.Restart();
        for (int i = 0; i < count; i++)
        {
            if (myList[i] % 777 == 0)
                Console.WriteLine(i + 1);
        }
        stopWatch.Stop();
        Console.WriteLine("Поиск элемента, который делится на 777 занял для myList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        for (int i = 0; i < count; i++)
        {
            if ((int)myArrayList[i] % 777 == 0)
                Console.WriteLine(i + 1);
        }
        stopWatch.Stop();
        Console.WriteLine("Поиск элемента, который делится на 777 занял для myArrayList " + stopWatch.Elapsed.TotalMilliseconds);

        stopWatch.Restart();
        for (int i = 0; i < count; i++)
        {
            if (myLinkedList.ElementAt(i) % 777 == 0)
                Console.WriteLine(i + 1);
        }
        stopWatch.Stop();
        Console.WriteLine("Поиск элемента, который делится на 777 занял для myLinkedList " + stopWatch.Elapsed.TotalMilliseconds);

    }
}
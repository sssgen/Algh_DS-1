using System;
using FirstLevel;
using SecondLevel;
using ThirdLevel;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- Перший рівень ---");
        var firstQueue = new FirstLevel.VectorQueue(10);

        Console.WriteLine("Додавання елементів 5, 8, 2 до черги...");
        firstQueue.Enqueue(5);
        firstQueue.Enqueue(8);
        firstQueue.Enqueue(2);

        Console.WriteLine("Поточний вміст черги:");
        firstQueue.Print();

        firstQueue.Dequeue();
        Console.WriteLine("Черга після видалення першого елемента:");
        firstQueue.Print();

        Console.WriteLine("\n--- Другий рівень ---");
        var list = new DoublyLinkedList();
       
        Console.WriteLine("Створення двозв'язного списку та додавання елементів: \"1\", \"4\", \"3\", \"10\"...");
        list.AddLast("1");
        list.AddLast("4");
        list.AddLast("3");
        list.AddLast("10");

        Console.WriteLine("Поточний список:");
        list.Print();

        Console.WriteLine("\n--- Третій рівень ---");
        Console.WriteLine("Створення нової черги для парних чисел...");
        var thirdQueue = new ThirdLevel.VectorQueue(10);

        Console.WriteLine("Переміщення парних чисел із списку до черги...");
        list.MoveEvenToQueue(thirdQueue);

        Console.WriteLine("Список після переміщення парних чисел:");
        list.Print();

        Console.WriteLine("Черга з парними числами:");
        thirdQueue.Print();
    }
}
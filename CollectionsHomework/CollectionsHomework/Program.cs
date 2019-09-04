using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            CubicArray cub = new CubicArray();
            ListArray lst = new ListArray();
            DicitonaryCountry dic = new DicitonaryCountry();
            QueueCube que = new QueueCube();
            StackCount stk = new StackCount();

            string options;

            Console.WriteLine("Collection Program\n-----------------------\n");

            Console.WriteLine("Select a option: 1. Array, 2. List, 3. Dictionary, 4. Queue, 5. Stack");
            options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    cub.Cubics();
                    break;
                case "2":
                    lst.AddClass();
                    break;
                case "3":
                    dic.Countries();
                    break;
                case "4":
                    que.CubeCount();
                    break;
                case "5":
                    stk.CountStack();
                    break;
                default:
                    Console.WriteLine("unknown options");
                    break;
            }
            Console.ReadLine();
        }
    }
    class CubicArray
    {
        public void Cubics()
        {
            int[,,] cube3D = new int[10, 10, 10];

            for (int x = 1; x < cube3D.GetLength(0); x++)
            {
                for (int y = 1; y < cube3D.GetLength(1); y++)
                {
                    for (int z = 1; z < cube3D.GetLength(2); z++)
                    {
                        cube3D[x, y, z] = x * y * z;
                        Console.WriteLine("Finally output the value at: " + cube3D[x, y, z]);
                    }
                }
            }
        }
    }
    class ListArray
    {
        public void AddClass()
        {
            List<int> List01 = new List<int>();

            int[,,] cube3D = new int[10, 10, 10];

            for (int x = 1; x < cube3D.GetLength(0); x++)
            {
                for (int y = 1; y < cube3D.GetLength(1); y++)
                {
                    for (int z = 1; z < cube3D.GetLength(2); z++)
                    {
                        cube3D[x, y, z] = x * y * z;
                        List01.Add(cube3D[x, y, z]);
                        Console.WriteLine("Finally output the value at: " + cube3D[x, y, z]);
                    }
                }
            }

            int result = List01.Sum();
            Console.WriteLine("Sum of the list = {0}", result);
        }
    }
    class DicitonaryCountry
    {
        public void Countries()
        {
            Dictionary<string, string> My_Dictionary = new Dictionary<string, string>();
            My_Dictionary.Add("England", "London");
            My_Dictionary.Add("Japan", "Tokyo");
            My_Dictionary.Add("India", "Mumbai");
            My_Dictionary.Add("New Zealand", "Auckland");
            My_Dictionary.Add("Austria", "Vienna");
            My_Dictionary.Add("Portugal", "Lisbon");
            My_Dictionary.Add("Spain", "Mardid");
            My_Dictionary.Add("France", "Paris");
            My_Dictionary.Add("Canada", "Vancover");
            My_Dictionary.Add("Scotland", "Glasgow");

            foreach (var country in My_Dictionary)
            {
                Console.WriteLine("Country: {0} \nCity: {1}\n", country.Key, country.Value);
            }
        }

    }
    class QueueCube
    {
        public void CubeCount()
        {
            Queue<int> qd = new Queue<int>();

            for (int i = 1; i < 100; i++)
            {
                qd.Enqueue(i*i*i);
            }

            for (int i = 0; i < 10; i++)
            {
                qd.Dequeue();
            }

            int result = qd.Sum();
            Console.WriteLine("Sum of the list = {0}", result);
        }
    }
    class StackCount
    {
        public void CountStack()
        {
            Stack<int> stk = new Stack<int>();

            for (int i = 1; i < 100; i++)
            {
                stk.Push(i*i*i);
            }

            for (int i = 1; i < 10; i++)
            {
                stk.Pop();
            }

            int result = stk.Sum();
            Console.WriteLine("Sum of the list = {0}", result);
        }
    }
}

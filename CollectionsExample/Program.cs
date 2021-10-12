using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExample
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.AddRange(new List<int>() { 1, 2, 4 });
            //list.Remove(1);
            //Console.WriteLine(list.Count);
            //list.Append(34);
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //ExampleOfDictionary();
            //ExampleOfQueue();
            //ExampleOfStack();
            //ExampleOfList();

            Console.ReadLine();
        }

        private static void ExampleOfDictionary()
        {
            int[] arr = new int[] { 0, 0, 1, 2, 2, 5, 7, 8, 4, 4, 7, 8, 4, 8, 9, 2, 3, 4, 7, 8, 4, 3 };
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Dictionary<int, int[]> dictionaryArr = new Dictionary<int, int[]>();
            SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();
            //dictionary.Count();
            //dictionary.Clear();
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, i * 10);
            }
            if (dictionary.ContainsKey(4))
            {
                Console.WriteLine("key value pair present in dictionary");
            }

            Console.WriteLine("In normal dict");
            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                Console.WriteLine("Key is " + kvp.Key + " and value is " + kvp.Value);
            }

            Console.WriteLine("In sorted dict");
            foreach (KeyValuePair<int, int> kvp in sortedDictionary)
            {
                Console.WriteLine("Key is " + kvp.Key + " and value is " + kvp.Value);
            }

            var listkey = dictionary.Keys.ToList();
            foreach (int i in listkey)
            {
                Console.WriteLine("Keys are " + i);
            }

            var listvalue = dictionary.Values.ToList();
            foreach (int i in listvalue)
            {
                Console.WriteLine("Values are " + i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else
                {
                    dictionary.Add(arr[i], 1);
                }
            }
        }
        private static void ExampleOfQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine("Size of queue " + queue.Count);

            Console.WriteLine("Removing first element");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Size of queue " + queue.Count);

            Console.WriteLine("Peeing first element in queue");
            Console.WriteLine(queue.Peek());
            Console.WriteLine("Size of queue " + queue.Count);

            Console.WriteLine("Clearing the queue");
            queue.Clear();
            Console.WriteLine("Size of queue " + queue.Count);
        }
        private static void ExampleOfStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Size of stack " + stack.Count);

            Console.WriteLine("Popping last added element");
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Size of stack " + stack.Count);

            Console.WriteLine("Peeking last added element");
            Console.WriteLine(stack.Peek());

            Console.WriteLine("Clearing elements");
            stack.Clear();
            Console.WriteLine("Size of stack " + stack.Count);
        }
        private static void ExampleOfList()
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student(2, "John"));
            listStudents.Add(new Student(1, "Doe"));
            listStudents.Add(new Student(3, "Cynthia"));

            foreach (var student in listStudents)
            {
                Console.WriteLine("Student ID" + student.id + " and student name is " + student.name);
            }

            var sortedList = listStudents.OrderBy(x => x.id).ToList();
            Console.WriteLine("In sorted list");
            foreach (var student in sortedList)
            {
                Console.WriteLine("Student ID" + student.id + " and student name is " + student.name);
            }

            sortedList.Reverse();
            Console.WriteLine("In sorted list reverse");
            foreach (var student in sortedList)
            {
                Console.WriteLine("Student ID" + student.id + " and student name is " + student.name);
            }

            var sortedListDescending = listStudents.OrderByDescending(x => x.id).ToList();
            Console.WriteLine("In list descending");
            foreach (var student in sortedListDescending)
            {
                Console.WriteLine("Student ID" + student.id + " and student name is " + student.name);
            }
        }
    }  
}

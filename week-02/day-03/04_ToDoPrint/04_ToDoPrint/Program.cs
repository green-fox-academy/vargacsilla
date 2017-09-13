using System;
using System.Linq;
using System.Text;

namespace _04_ToDoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoList = "- Buy milk\n";
            int lastIndex = todoList.Length;
            todoList = todoList.Insert(0, "My todo:\n");
            todoList = todoList.Insert(todoList.Length, "- Download games\n");
            todoList = todoList.Insert(todoList.Length, "\t- Diablo");

            //string todoList = "- Buy milk\n";
            //todoList = todoList.Insert(0, "My todo:\n");
            //StringBuilder todoListBuild = new StringBuilder(todoList);
            //todoList.Insert(0, "My todo:\n");
            //todoListBuild.Append("- Download games\n").Append("\t").Append("- Diablo");
            //todoList = todoListBuild;

            Console.WriteLine(todoList);
            Console.ReadLine();
        }
    }
}

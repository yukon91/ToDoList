using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    /// <summary>
    /// Hantering för att lägga till, ta bort, samt visa listan
    /// </summary>
    internal class ToDoList
    {
        private List<string> tasks = new();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            int index = tasks.IndexOf(task);
            if (index != -1)
            {
                tasks.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Task was not found in the list!");
            }
        }
       
        public List<string> GetTasks()
        {
            return tasks;
        }
    }
}

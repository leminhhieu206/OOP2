using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class ToDoList
    {
        List<Task> tasks = new List<Task>();

        public void InsertTask(Task task)
        {
            tasks.Add(task);
        }

        public void DisplayTasks()
        {
            int i = 1;
            foreach (var task in tasks)
            {

                Console.Write(i + ": ");
                Console.WriteLine(task.GetDescription());
                i++;
            }
        }
        public Task getTask(int i)
        {
            return tasks[i];
        }
        public Task UpdateTask(int i, string updateDescription)
        {
            tasks[i].SetDescription(updateDescription);
            return tasks[i];
        }
        public void RemoveTask(int i)
        {
            tasks.RemoveAt(i);
        }
    }
}

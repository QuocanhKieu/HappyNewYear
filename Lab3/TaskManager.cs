using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        // Thêm công việc mới vào danh sách
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Hiển thị danh sách công việc cùng trạng thái
        public void DisplayTasks(bool showCompleted)
        {
            Console.WriteLine("Danh sách công việc:");

            foreach (var task in tasks)
            {
                if (task.IsCompleted == showCompleted)
                {
                    Console.WriteLine($"{task.Name} - {(task.IsCompleted ? "Đã hoàn thành" : "Chưa hoàn thành")}");
                }
            }
        }
    }
}

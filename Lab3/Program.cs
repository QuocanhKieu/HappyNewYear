using System;
using System.Collections.Generic;

namespace Lab3
{
class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        // Thêm vài công việc vào danh sách
        Task task1 = new Task { Name = "Task 1" };
        Task task2 = new Task { Name = "Task 2" };

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        // Đăng ký sự kiện cho công việc
        task1.StatusChanged += Task_StatusChanged;

        // Hiển thị danh sách chưa hoàn thành
        Console.WriteLine("Danh sách chưa hoàn thành:");
        taskManager.DisplayTasks(false);

        // Đánh dấu công việc 1 là đã hoàn thành và kiểm tra sự kiện
        task1.IsCompleted = true;

        // Hiển thị danh sách đã hoàn thành
        Console.WriteLine("\nDanh sách đã hoàn thành:");
        taskManager.DisplayTasks(true);

        Console.ReadLine();
    }

    // Xử lý sự kiện thay đổi trạng thái công việc
    private static void Task_StatusChanged(object sender, TaskStatusChangedEventArgs e)
    {
        Console.WriteLine($"Trạng thái công việc '{e.TaskName}' đã thay đổi thành {(e.IsCompleted ? "Đã hoàn thành" : "Chưa hoàn thành")}");
    }
}

}
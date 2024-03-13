using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3
{
    internal delegate void TaskStatusChangedEventHandler(object sender, TaskStatusChangedEventArgs e);
    internal class Task
    {
        public string Name { get; set; }
        private bool isCompleted;

        // Event để thông báo khi trạng thái của công việc thay đổi
        public event TaskStatusChangedEventHandler StatusChanged;

        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                    OnStatusChanged();
                }
            }
        }

        // Phương thức kích hoạt sự kiện StatusChanged
        protected virtual void OnStatusChanged()
        {
            StatusChanged?.Invoke(this, new TaskStatusChangedEventArgs(Name, IsCompleted));
        }
    }
}

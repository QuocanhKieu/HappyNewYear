using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class TaskStatusChangedEventArgs : EventArgs
    {
        public string TaskName { get; }
        public bool IsCompleted { get; }

        public TaskStatusChangedEventArgs(string taskName, bool isCompleted)
        {
            TaskName = taskName;
            IsCompleted = isCompleted;
            // dc quyền set 1 lần duy nhất trong constructor
        }
        
    }
}

using System;

namespace TaskManagementFinal
{
    public interface ITask
    {
        string TaskName { get; set; }
        DateTime DueDate { get; set; }
        string Assignee { get; set; }
        bool Completed { get; set; }
    }
}

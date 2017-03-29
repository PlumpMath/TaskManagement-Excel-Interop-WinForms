using System;
namespace TaskManagementFinal
{
    public class Task : ITask
    {
        /// <summary>
        /// Gets or sets the Task Name.
        /// </summary>
        public string TaskName { get; set; }
        
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the assignee.
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// Gets or sets the completed field.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Constructor for class Task. 
        /// Creates an empty object of the class Task.
        /// </summary>
        public Task()
        {
        }

        /// <summary>
        /// Parameterized constructor for class Task.
        /// Takes input from user and creates an object with Completed set to false always. 
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="dueDate"></param>
        /// <param name="assignee"></param>
        public Task(string taskName, DateTime dueDate, string assignee)
        {
            TaskName = taskName;
            DueDate = dueDate;
            Assignee = assignee;
            Completed = false;
        }

        /// <summary>
        /// This methods overrides ToString and returns Task Name with Assignee 
        /// details when a call to the same is made. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskName + SharedData.DELIMETER + Assignee;
        }
    }
}

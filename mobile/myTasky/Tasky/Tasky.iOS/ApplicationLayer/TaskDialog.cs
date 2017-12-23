using System;
using Tasky.PortableLibrary.BL;
namespace Tasky.iOS.ApplicationLayer
{
    public class TaskDialog
    {
        public TaskDialog(TaskyItem task)
        {
            Name = task.Name;
            Notes = task.Notes;
            Done = task.Completed;
        }

        [Entry]
    }
}

using System;
using System.Collections.Generic;
using Tasky.PortableLibrary.BL;

namespace Tasky.PortableLibrary.BL 
{
    public class TaskyManager
    {
        static TaskyManager()
        {
        }

        public static TaskyItem GetItem(int id)
        {
            return DAL.TaskyRepository.GetItem(id);
        }

        public static IList<TaskyItem> GetItems()
        {
            return new List<TaskyItem>(DAL.TaskyRepository.GetItems());
        }

        public static int DeleteItem(int id)
        {
            return DAL.TaskyRepository.DeleteItem(id);
        }

        public static int SaveItem(TaskyItem item)
        {
            return DAL.TaskyRepository.SaveItem(item);
        }
   




    }
}

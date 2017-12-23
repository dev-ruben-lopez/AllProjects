using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using Tasky.PortableLibrary.BL;

namespace Tasky.PortableLibrary.DAL
{
    public class TaskyRepository
    {
        DL.TaskyDatabase db = null;
        protected static string dbLocation;
        protected static TaskyRepository me;

        public static string DatabaseFilePath { get; set; } //Pass this string location from the iOS and Android prooject

        static TaskyRepository()
        {
            me = new TaskyRepository();
        }

        protected TaskyRepository()
        {
            //set Database Location in the device
            dbLocation = DatabaseFilePath;
			db = new Tasky.PortableLibrary.DL.TaskyDatabase(dbLocation);

		}
		/*
		protected TaskyRepository(string dbFileLocationPath)
		{
			//set Database Location in the device
			dbLocation = dbFileLocationPath;
            //instantiate database
            db = new Tasky.PortableLibrary.DL.TaskyDatabase(dbFileLocationPath);
		}
        
		public static string DatabaseFilePath
		{
			 get {
                    var sqliteFilename = "TaskDB.db3";
                    get
			        {
				        var sqliteFilename = "TaskDB.db3";

                        string path = "/Users/roobenlo/Documents/dev/" + sqliteFilename; 
                        return path;
			        }
		}*/

		public static TaskyItem GetItem(int id)
        {
            return me.db.GetItem<TaskyItem>(id);
        }

        public static IEnumerable<TaskyItem> GetItems()
        {
            return me.db.GetItems<TaskyItem>();
        }

        public static int SaveItem(TaskyItem item)
        {
            return me.db.SaveItem<TaskyItem>(item);
        }

        public static int DeleteItem(int id)
        {
            return me.db.DeleteItem<TaskyItem>(id);
        }

    }
}

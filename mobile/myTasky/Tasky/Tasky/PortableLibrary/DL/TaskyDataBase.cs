using System;
using System.Linq;
using System.Collections.Generic;
using SQLite;
using Tasky.PortableLibrary.BL;

namespace Tasky.PortableLibrary.DL
{
    public class TaskyDatabase : SQLiteConnection
    {
        static object locker = new object();
        public SQLiteConnection database;
        public string path;

        /// <summary>
        /// Initializes a new instance of the TaskyDatabase.
        /// If does not exist, then create all the tables
        /// </summary>
        public TaskyDatabase(string path) : base(path)
        {
            //database = conn;
            //create tables
            CreateTable<TaskyItem>();
        }

        /// <summary>
        /// Returns all the tasks 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetItems<T>() where T : BL.Contracts.IBusinessEntity, new()
        {
            lock (locker)
            {
                return (from i in Table<T>() select i).ToList();
            }
        }

        /// <summary>
        /// Return only one record where the ID is equal to the id provided
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetItem<T> (int id) where T : BL.Contracts.IBusinessEntity, new()
        {
            lock (locker)
            {
                return Table<T>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem<T>(T item) where T : BL.Contracts.IBusinessEntity
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    Update(item);
                    return item.ID;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeleteItem<T>(int ID) where T : BL.Contracts.IBusinessEntity, new()
        {
            lock (locker)
            {
                return Delete<T>(ID);
            }
        }



    }
}


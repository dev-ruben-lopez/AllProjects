using System;
using System.Linq;
using System.Collections.Generic;
using SQLite;
using Tasky.PortableLibrary.BL;
//using Tasky.PortableLibrary.DL;


namespace UnitTest
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {

            //string databasePath = "/Users/roobenlo/Documents/dev/databaseTest";
            //var dbConnection = new SQLiteConnection(databasePath);


            Console.WriteLine("*******BASIC LIBRARY TESTING**********");
            Console.Write("Enter name :");
            string name = Console.ReadLine();
			Console.Write("Enter notes :");
			string notes = Console.ReadLine();

            TaskyItem item = new TaskyItem();
            item.Name = name;
            item.Notes = notes;

            //TaskyDatabase tDB = new TaskyDatabase(databasePath);

            int id = TaskyManager.SaveItem(item);


            Console.WriteLine("The id is : " + id.ToString());

            Console.WriteLine("Press to retrieve item....");
            //Console.Clear();

            Console.WriteLine("Enter id to retrieve : ");
            id = Convert.ToInt32(Console.ReadLine());

            item = TaskyManager.GetItem(id);

            Console.WriteLine("Name : ");
            Console.WriteLine(item.Name);

			Console.WriteLine("Notes : ");
			Console.WriteLine(item.Notes);


		}
    }
}

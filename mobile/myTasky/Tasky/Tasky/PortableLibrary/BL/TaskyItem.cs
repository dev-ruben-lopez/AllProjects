using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Tasky.PortableLibrary.BL
{
    public class TaskyItem : BL.Contracts.IBusinessEntity
    {
        public TaskyItem()
        { }

        //Properties with attributes
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Completed { get; set; }

    }


}

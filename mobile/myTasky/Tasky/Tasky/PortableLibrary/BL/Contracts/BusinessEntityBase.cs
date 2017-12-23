using System;
using SQLite;

namespace Tasky.PortableLibrary.BL.Contracts
{
    public abstract class BusinessEntityBase : IBusinessEntity
    {
        public BusinessEntityBase(){}

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

    }
}

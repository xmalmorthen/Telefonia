using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class GenericDAL<DbEntity>
    {
        private DbEntity _db;

        /// <summary>
        /// Objeto de Base de datos Entity Framework
        /// </summary>
        public DbEntity dbEntity
        {
            get { return _db; }
            set { _db = value; }
        }
    }
}

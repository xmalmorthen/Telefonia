using Satelites.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satelites.Controllers
{
    public static class DALController<TEntityes> where TEntityes : DbContext 
    {
        private static TEntityes db;
        public static TEntityes Db
        {
            get { return db; }
            set { db = value; }
        }

        public static void discardChanges(TEntityes entity)
        {
            Db.Entry(entity).CurrentValues.SetValues(Db.Entry(entity).OriginalValues);
            Db.Entry(entity).State = EntityState.Unchanged;
        }

    }
}

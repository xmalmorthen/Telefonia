using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Controllers
{
    public static class DAL
    {
        private static dbgeolocEntities db;
        public static dbgeolocEntities Db
        {
            get { return DAL.db; }
            set { DAL.db = value; }
        }

        public static void discardChanges<TEntityes>(TEntityes entity) where TEntityes : class
        {
            DAL.Db.Entry(entity).CurrentValues.SetValues(DAL.Db.Entry(entity).OriginalValues);
            DAL.Db.Entry(entity).State = System.Data.Entity.EntityState.Unchanged;
        }

    }
}

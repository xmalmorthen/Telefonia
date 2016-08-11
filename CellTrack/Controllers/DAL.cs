using CellTrack.Models.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellTrack.Controllers
{
    public static class DALController
    {
        private static dbgeolocEntities db;
        public static dbgeolocEntities Db
        {
            get { return DALController.db; }
            set { DALController.db = value; }
        }

        public static void discardChanges<TEntityes>(TEntityes entity) where TEntityes : class
        {
            DALController.Db.Entry(entity).CurrentValues.SetValues(DALController.Db.Entry(entity).OriginalValues);
            DALController.Db.Entry(entity).State = System.Data.Entity.EntityState.Unchanged;
        }

    }
}

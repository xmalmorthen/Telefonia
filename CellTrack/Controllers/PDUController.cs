using CellTrack.Classes;
using CellTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Controllers
{
    public static class PDUController
    {
        public static markersModel PDUFind(PDUModel item, gMapController controller)
        {
            markersModel marker = null;
            try
            {
                marker = new markersModel(20.675159,-103.358840,item.descrip);
                controller.CreateCircle(new System.Drawing.PointF((float)marker.Lat,(float)marker.Lng), .005,50);
                controller.AddMarker(marker);
                controller.setPosition(marker);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }

    }
}

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
        public static markersModel PDUFind(localizationsModel item)
        {
            markersModel marker = null;
            try
            {
                marker = new markersModel();

                marker.Lat = 20.675159;
                marker.Lng = -103.358840;
                marker.Desc = "Position inserted";
                gMapController.AddMarker(marker);
                gMapController.setPosition(marker);
            }
            catch (Exception ex)
            {
                exceptionHandlerCatch.registerLogException(ex);
            }
            return marker;
        }

    }
}

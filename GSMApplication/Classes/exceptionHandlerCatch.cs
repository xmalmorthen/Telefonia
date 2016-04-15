using GSMApplication.Models.DataBase;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Classes
{
    public static class exceptionHandlerCatch
    {
        private static int nLogMinutesAfter = int.Parse(GSMApplication.Properties.Settings.Default.NLogMinutesAfter);
        private static int nlogCountErrorRecords = int.Parse(GSMApplication.Properties.Settings.Default.NlogCountErrorRecords);

        public static void registerLogException(Exception ex) {
            GSMPIDataContext bdNlogCnn = new GSMPIDataContext();
            SPNlogErrorsRegistredInIntervalResult response = bdNlogCnn.SPNlogErrorsRegistredInInterval(nLogMinutesAfter, ex.Message).SingleOrDefault();
            if (response.COUNT < nlogCountErrorRecords){
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
            }
        }
    }
}

﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satelites.Classes
{
    public static class exceptionHandlerCatch
    {
        public static void registerLogException(Exception ex)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error(ex, ex.Message);
        }
    }
}
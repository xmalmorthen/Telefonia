using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMApplication.Models
{
    class ResponseModel
    {
        private Boolean status;
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        private StringBuilder message = new StringBuilder();
        public StringBuilder Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}

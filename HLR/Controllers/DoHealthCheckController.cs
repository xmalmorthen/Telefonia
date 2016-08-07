using HLR.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLR.Controllers
{
    public static class DoHealthCheckController
    {
        public static HLRModel.doHealthCheck get
        {
            get
            {
                HLRModel.doHealthCheck response = null;
                try
                {
                    RestClient client = new RestClient(Properties.Settings.Default.HLRApiUrl);
                    RestRequest request = new RestRequest("api", Method.POST);
                    request.AddParameter("action", "doHealthCheck");
                    request.AddParameter("username", Properties.Settings.Default.HLRApiUser);
                    request.AddParameter("password", Properties.Settings.Default.HLRApiPass);

                    request.AddHeader("Accept", "application/json");

                    RestResponse<HLRModel.doHealthCheck> RESTResponse = client.Execute<HLRModel.doHealthCheck>(request) as RestResponse<HLRModel.doHealthCheck>;

                    response = RESTResponse.Data;
                }
                catch (Exception)
                {
                    //TODO: Nlog
                }

                return response;
            } 
        }
    }
}

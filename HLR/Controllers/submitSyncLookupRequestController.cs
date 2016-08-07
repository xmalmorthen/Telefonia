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
    public static class submitSyncLookupRequestController
    {
        public static HLRModel.submitSyncLookupRequest invoque(string msisdn)
        {
                HLRModel.submitSyncLookupRequest response = null;
                try
                {
                    RestClient client = new RestClient(Properties.Settings.Default.HLRApiUrl);
                    RestRequest request = new RestRequest("api", Method.POST);
                    request.AddParameter("action", "submitSyncLookupRequest");
                    request.AddParameter("username", Properties.Settings.Default.HLRApiUser);
                    request.AddParameter("password", Properties.Settings.Default.HLRApiPass);
                    request.AddParameter("msisdn", msisdn);
                    request.AddParameter("route", Properties.Settings.Default.HLRRoute);

                    request.AddHeader("Accept", "application/json");

                    RestResponse<HLRModel.submitSyncLookupRequest> RESTResponse = client.Execute<HLRModel.submitSyncLookupRequest>(request) as RestResponse<HLRModel.submitSyncLookupRequest>;

                    response = RESTResponse.Data;
                }
                catch (Exception ex)
                {
                    //TODO: Nlog
                    throw;
                }

                return response;
        }
    }
}

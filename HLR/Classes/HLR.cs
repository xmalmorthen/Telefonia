using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class HLRSystem {
        public string state { get; set; }
    }

    public class HLRroutesStates
    {
        public string IP1 { get; set; }
        public string ST2 { get; set; }
        public string SV3 { get; set; }
        public string IP4 { get; set; }
        public string XT5 { get; set; }
        public string XT6 { get; set; }
        public string NT7 { get; set; }
        public string LC1 { get; set; }
    }

    public class HLRroutes {
        public HLRroutesStates states { get; set; }
    }

    public class HLRAccount {
        public Boolean lookupsPermitted { get; set; }
        public string balance { get; set; }
    }

    public class resultsModel {
        public string balance { get; set; }
        public HLRSystem system { get; set; }
        public HLRroutes routes { get; set; }
        public HLRAccount account { get; set; }
        public string url { get; set; }
        public string id {get; set;}
        public string msisdncountrycode {get; set;}
        public string msisdn {get; set;}
        public string statuscode {get; set;}
        public int? hlrerrorcodeid {get; set;}
        public string subscriberstatus {get; set;}
        public string imsi {get; set;}
        public string mccmnc {get; set;}
        public string mcc {get; set;}
        public string mnc {get; set;}
        public string msin {get; set;}
        public string servingmsc {get; set;}        
        public string servinghlr {get; set;}
        public string originalnetworkname {get; set;}
        public string originalcountryname {get; set;}
        public string originalcountrycode {get; set;}
        public string originalcountryprefix {get; set;}
        public string originalnetworkprefix {get; set;}
        public string roamingnetworkname {get; set;}
        public string roamingcountryname {get; set;}
        public string roamingcountrycode {get; set;}
        public string roamingcountryprefix {get; set;}
        public string roamingnetworkprefix {get; set;}
        public string portednetworkname {get; set;}
        public string portedcountryname {get; set;}
        public string portedcountrycode {get; set;}
        public string portedcountryprefix {get; set;}
        public string portednetworkprefix {get; set;}
        public string isvalid {get; set;}
        public string isroaming {get; set;}
        public string isported {get; set;}
        public string usercharge {get; set;}
        public string inserttime {get; set;}
        public string storage {get; set;}
        public string route {get; set;}
        public string Interface {get; set;}
    }
    
    class errorsModel {
        public string[] fieldErrors { get; set; }
        public string[] globalErrors { get; set; }
    }

    public class getBalanceModel { 
        public Boolean success {get; set;}
        public string[] messages {get; set;}
        public resultsModel results {get; set;}
    }


    public class HLR
    {

    }




}

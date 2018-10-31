using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDomainAnalysis
{
    public class CGlobalConfig
    {
        public CGlobalConfig()
        {
            AccessKey = "LTAIVyzoH0XRJCCX";
            AccessKeySecret = "VPbcpWVqMocl8paHQCr5ozh3jkzRDp";
            DomainName = "chihtung.com";
        }
        public static string AccessKey { get; set; }

        public static string AccessKeySecret { get; set; }

        public static string DomainName { get; set; }


        //AccessKey = "LTAIVyzoH0XRJCCX",

    }
}

﻿using System.Configuration;

namespace AliyunDomainAnalysis
{
    public class DomainRecordOptions
    {
        public DomainRecordOptions()
        {
            RegionId = ConfigurationManager.AppSettings["RegionId"].ToString();
            AccessKeyId = ConfigurationManager.AppSettings["AccessKeyId"].ToString();
            AccessKeySecret = ConfigurationManager.AppSettings["AccessKeySecret"].ToString();
            DomainName = ConfigurationManager.AppSettings["DomainName"].ToString();
            DomainType = ConfigurationManager.AppSettings["DomainType"].ToString();
        }
        /// <summary>
        /// 必填固定值，必须为"cn-hangzhou"
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// your accessKey
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// your accessSecret
        /// </summary>
        public string AccessKeySecret { get; set; }
        public string DomainName { get; set; }
        public string DomainType { get; set; }
    }
}

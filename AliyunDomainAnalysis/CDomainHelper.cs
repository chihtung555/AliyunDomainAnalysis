using Aliyun.Acs.Alidns.Model.V20150109;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDomainAnalysis
{
    public class CDomainHelper
    {
        public static void AddDomainRecords(DescribeDomainRecordsResponse.Record record)
        {
            IClientProfile clientProfile = DefaultProfile.GetProfile("cn-hangzhou", CGlobalConfig.AccessKey, CGlobalConfig.AccessKeySecret);
            DefaultAcsClient client = new DefaultAcsClient(clientProfile);
            AddDomainRecordRequest request = new AddDomainRecordRequest();
            request.DomainName = record.DomainName;
            request.RR = record.RR;
            request.Type = record.Type;
            request.Value = record.Value;
            AddDomainRecordResponse response = client.GetAcsResponse(request);
        }

        public static void UpdateDomainRecords(DescribeDomainRecordsResponse.Record record)
        {
            IClientProfile clientProfile = DefaultProfile.GetProfile("cn-hangzhou", CGlobalConfig.AccessKey, CGlobalConfig.AccessKeySecret);
            DefaultAcsClient client = new DefaultAcsClient(clientProfile);
            UpdateDomainRecordRequest request = new UpdateDomainRecordRequest();
            request.RecordId = record.RecordId;
            request.RR = record.RR;
            request.Type = record.Type;
            request.Value = record.Value;
            UpdateDomainRecordResponse response = client.GetAcsResponse(request);
        }
    }
}

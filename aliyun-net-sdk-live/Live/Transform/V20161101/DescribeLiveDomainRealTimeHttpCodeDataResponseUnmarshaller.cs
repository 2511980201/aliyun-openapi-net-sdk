/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainRealTimeHttpCodeDataResponseUnmarshaller
    {
        public static DescribeLiveDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainRealTimeHttpCodeDataResponse describeLiveDomainRealTimeHttpCodeDataResponse = new DescribeLiveDomainRealTimeHttpCodeDataResponse();

			describeLiveDomainRealTimeHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainRealTimeHttpCodeDataResponse.RequestId = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.RequestId");
			describeLiveDomainRealTimeHttpCodeDataResponse.DomainName = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.DomainName");
			describeLiveDomainRealTimeHttpCodeDataResponse.StartTime = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.StartTime");
			describeLiveDomainRealTimeHttpCodeDataResponse.EndTime = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.EndTime");
			describeLiveDomainRealTimeHttpCodeDataResponse.DataInterval = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData> describeLiveDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < context.Length("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData usageData = new DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData.DescribeLiveDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData.DescribeLiveDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < context.Length("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData.DescribeLiveDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeLiveDomainRealTimeHttpCodeDataResponse.DescribeLiveDomainRealTimeHttpCodeData_UsageData.DescribeLiveDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = context.StringValue("DescribeLiveDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeLiveDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData.Add(usageData);
			}
			describeLiveDomainRealTimeHttpCodeDataResponse.RealTimeHttpCodeData = describeLiveDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData;
        
			return describeLiveDomainRealTimeHttpCodeDataResponse;
        }
    }
}
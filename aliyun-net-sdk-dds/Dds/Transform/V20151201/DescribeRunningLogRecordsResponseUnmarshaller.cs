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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRunningLogRecordsResponseUnmarshaller
    {
        public static DescribeRunningLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRunningLogRecordsResponse describeRunningLogRecordsResponse = new DescribeRunningLogRecordsResponse();

			describeRunningLogRecordsResponse.HttpResponse = context.HttpResponse;
			describeRunningLogRecordsResponse.RequestId = context.StringValue("DescribeRunningLogRecords.RequestId");
			describeRunningLogRecordsResponse.Engine = context.StringValue("DescribeRunningLogRecords.Engine");
			describeRunningLogRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeRunningLogRecords.TotalRecordCount");
			describeRunningLogRecordsResponse.PageNumber = context.IntegerValue("DescribeRunningLogRecords.PageNumber");
			describeRunningLogRecordsResponse.PageRecordCount = context.IntegerValue("DescribeRunningLogRecords.PageRecordCount");

			List<DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords> describeRunningLogRecordsResponse_items = new List<DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords>();
			for (int i = 0; i < context.Length("DescribeRunningLogRecords.Items.Length"); i++) {
				DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords logRecords = new DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords();
				logRecords.Id = context.IntegerValue("DescribeRunningLogRecords.Items["+ i +"].Id");
				logRecords.CreateTime = context.StringValue("DescribeRunningLogRecords.Items["+ i +"].CreateTime");
				logRecords.Category = context.StringValue("DescribeRunningLogRecords.Items["+ i +"].Category");
				logRecords.ConnInfo = context.StringValue("DescribeRunningLogRecords.Items["+ i +"].ConnInfo");
				logRecords.Content = context.LongValue("DescribeRunningLogRecords.Items["+ i +"].Content");

				describeRunningLogRecordsResponse_items.Add(logRecords);
			}
			describeRunningLogRecordsResponse.Items = describeRunningLogRecordsResponse_items;
        
			return describeRunningLogRecordsResponse;
        }
    }
}
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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Success = context.BooleanValue("DescribeRegions.Success");
			describeRegionsResponse.ErrorCode = context.IntegerValue("DescribeRegions.ErrorCode");

			List<DescribeRegionsResponse.DescribeRegions_ResultItem> describeRegionsResponse_result = new List<DescribeRegionsResponse.DescribeRegions_ResultItem>();
			for (int i = 0; i < context.Length("DescribeRegions.Result.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_ResultItem resultItem = new DescribeRegionsResponse.DescribeRegions_ResultItem();
				resultItem.Id = context.IntegerValue("DescribeRegions.Result["+ i +"].Id");
				resultItem.RegionId = context.StringValue("DescribeRegions.Result["+ i +"].RegionId");
				resultItem.Title = context.StringValue("DescribeRegions.Result["+ i +"].Title");
				resultItem.Online = context.BooleanValue("DescribeRegions.Result["+ i +"].Online");

				describeRegionsResponse_result.Add(resultItem);
			}
			describeRegionsResponse.Result = describeRegionsResponse_result;
        
			return describeRegionsResponse;
        }
    }
}
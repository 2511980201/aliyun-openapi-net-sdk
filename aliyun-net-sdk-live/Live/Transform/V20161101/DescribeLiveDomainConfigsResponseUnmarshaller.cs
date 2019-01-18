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
    public class DescribeLiveDomainConfigsResponseUnmarshaller
    {
        public static DescribeLiveDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainConfigsResponse describeLiveDomainConfigsResponse = new DescribeLiveDomainConfigsResponse();

			describeLiveDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainConfigsResponse.RequestId = context.StringValue("DescribeLiveDomainConfigs.RequestId");

			List<DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig> describeLiveDomainConfigsResponse_domainConfigs = new List<DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeLiveDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig domainConfig = new DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig.DescribeLiveDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig.DescribeLiveDomainConfigs_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig.DescribeLiveDomainConfigs_FunctionArg functionArg = new DescribeLiveDomainConfigsResponse.DescribeLiveDomainConfigs_DomainConfig.DescribeLiveDomainConfigs_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeLiveDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeLiveDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeLiveDomainConfigsResponse.DomainConfigs = describeLiveDomainConfigsResponse_domainConfigs;
        
			return describeLiveDomainConfigsResponse;
        }
    }
}
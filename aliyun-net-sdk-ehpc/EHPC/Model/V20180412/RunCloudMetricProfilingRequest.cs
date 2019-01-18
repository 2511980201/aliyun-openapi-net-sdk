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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class RunCloudMetricProfilingRequest : RpcAcsRequest<RunCloudMetricProfilingResponse>
    {
        public RunCloudMetricProfilingRequest()
            : base("EHPC", "2018-04-12", "RunCloudMetricProfiling", "ehs", "openAPI")
        {
        }

		private int? duration;

		private string hostName;

		private string regionId;

		private int? processId;

		private int? freq;

		private string action;

		private string clusterId;

		private string accessKeyId;

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public int? ProcessId
		{
			get
			{
				return processId;
			}
			set	
			{
				processId = value;
				DictionaryUtil.Add(QueryParameters, "ProcessId", value.ToString());
			}
		}

		public int? Freq
		{
			get
			{
				return freq;
			}
			set	
			{
				freq = value;
				DictionaryUtil.Add(QueryParameters, "Freq", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override RunCloudMetricProfilingResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RunCloudMetricProfilingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
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
    public class GetCloudMetricLogsRequest : RpcAcsRequest<GetCloudMetricLogsResponse>
    {
        public GetCloudMetricLogsRequest()
            : base("EHPC", "2018-04-12", "GetCloudMetricLogs", "ehs", "openAPI")
        {
        }

		private string aggregationType;

		private string filter;

		private string metricCategories;

		private string metricScope;

		private string action;

		private int? from;

		private string clusterId;

		private int? to;

		private int? aggregationInterval;

		private bool? reverse;

		private string accessKeyId;

		public string AggregationType
		{
			get
			{
				return aggregationType;
			}
			set	
			{
				aggregationType = value;
				DictionaryUtil.Add(QueryParameters, "AggregationType", value);
			}
		}

		public string Filter
		{
			get
			{
				return filter;
			}
			set	
			{
				filter = value;
				DictionaryUtil.Add(QueryParameters, "Filter", value);
			}
		}

		public string MetricCategories
		{
			get
			{
				return metricCategories;
			}
			set	
			{
				metricCategories = value;
				DictionaryUtil.Add(QueryParameters, "MetricCategories", value);
			}
		}

		public string MetricScope
		{
			get
			{
				return metricScope;
			}
			set	
			{
				metricScope = value;
				DictionaryUtil.Add(QueryParameters, "MetricScope", value);
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

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value.ToString());
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

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(QueryParameters, "To", value.ToString());
			}
		}

		public int? AggregationInterval
		{
			get
			{
				return aggregationInterval;
			}
			set	
			{
				aggregationInterval = value;
				DictionaryUtil.Add(QueryParameters, "AggregationInterval", value.ToString());
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
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

        public override GetCloudMetricLogsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetCloudMetricLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
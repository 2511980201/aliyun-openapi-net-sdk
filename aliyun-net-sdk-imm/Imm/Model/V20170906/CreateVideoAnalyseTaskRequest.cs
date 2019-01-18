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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class CreateVideoAnalyseTaskRequest : RpcAcsRequest<CreateVideoAnalyseTaskResponse>
    {
        public CreateVideoAnalyseTaskRequest()
            : base("imm", "2017-09-06", "CreateVideoAnalyseTask", "imm", "openAPI")
        {
        }

		private string notifyTopicName;

		private string grabType;

		private string project;

		private string endTime;

		private string startTime;

		private string accessKeyId;

		private string videoUri;

		private bool? saveType;

		private string notifyEndpoint;

		private string action;

		private string interval;

		private string tgtUri;

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTopicName", value);
			}
		}

		public string GrabType
		{
			get
			{
				return grabType;
			}
			set	
			{
				grabType = value;
				DictionaryUtil.Add(QueryParameters, "GrabType", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public string VideoUri
		{
			get
			{
				return videoUri;
			}
			set	
			{
				videoUri = value;
				DictionaryUtil.Add(QueryParameters, "VideoUri", value);
			}
		}

		public bool? SaveType
		{
			get
			{
				return saveType;
			}
			set	
			{
				saveType = value;
				DictionaryUtil.Add(QueryParameters, "SaveType", value.ToString());
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "NotifyEndpoint", value);
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

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
			}
		}

		public string TgtUri
		{
			get
			{
				return tgtUri;
			}
			set	
			{
				tgtUri = value;
				DictionaryUtil.Add(QueryParameters, "TgtUri", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVideoAnalyseTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateVideoAnalyseTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
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
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class ListOfficeConversionTaskResponse : AcsResponse
	{

		private string requestId;

		private string nextMarker;

		private List<ListOfficeConversionTask_TasksItem> tasks;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
			}
		}

		public List<ListOfficeConversionTask_TasksItem> Tasks
		{
			get
			{
				return tasks;
			}
			set	
			{
				tasks = value;
			}
		}

		public class ListOfficeConversionTask_TasksItem
		{

			private string taskId;

			private string status;

			private int? percent;

			private int? pageCount;

			private string srcUri;

			private string tgtType;

			private string tgtUri;

			private string imageSpec;

			private string notifyTopicName;

			private string notifyEndpoint;

			private string externalID;

			private string createTime;

			private string finishTime;

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public int? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public int? PageCount
			{
				get
				{
					return pageCount;
				}
				set	
				{
					pageCount = value;
				}
			}

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string TgtType
			{
				get
				{
					return tgtType;
				}
				set	
				{
					tgtType = value;
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
				}
			}

			public string ImageSpec
			{
				get
				{
					return imageSpec;
				}
				set	
				{
					imageSpec = value;
				}
			}

			public string NotifyTopicName
			{
				get
				{
					return notifyTopicName;
				}
				set	
				{
					notifyTopicName = value;
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
				}
			}

			public string ExternalID
			{
				get
				{
					return externalID;
				}
				set	
				{
					externalID = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}
		}
	}
}
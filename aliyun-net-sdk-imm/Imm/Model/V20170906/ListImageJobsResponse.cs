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
	public class ListImageJobsResponse : AcsResponse
	{

		private string requestId;

		private string nextMarker;

		private List<ListImageJobs_JobsItem> jobs;

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

		public List<ListImageJobs_JobsItem> Jobs
		{
			get
			{
				return jobs;
			}
			set	
			{
				jobs = value;
			}
		}

		public class ListImageJobs_JobsItem
		{

			private string status;

			private string jobId;

			private string jobType;

			private string parameters;

			private string result;

			private string startTime;

			private string endTime;

			private string errorMessage;

			private string notifyEndpoint;

			private string notifyTopicName;

			private int? progress;

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

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public string Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
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
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
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

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}
		}
	}
}
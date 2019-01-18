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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryQualificationDetailResponse : AcsResponse
	{

		private string trackId;

		private int? auditStatus;

		private string requestId;

		private List<QueryQualificationDetail_QualificationCredential> credentials;

		public string TrackId
		{
			get
			{
				return trackId;
			}
			set	
			{
				trackId = value;
			}
		}

		public int? AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
			}
		}

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

		public List<QueryQualificationDetail_QualificationCredential> Credentials
		{
			get
			{
				return credentials;
			}
			set	
			{
				credentials = value;
			}
		}

		public class QueryQualificationDetail_QualificationCredential
		{

			private string credentialNo;

			private string credentialType;

			private string credentialUrl;

			private string _params;

			public string CredentialNo
			{
				get
				{
					return credentialNo;
				}
				set	
				{
					credentialNo = value;
				}
			}

			public string CredentialType
			{
				get
				{
					return credentialType;
				}
				set	
				{
					credentialType = value;
				}
			}

			public string CredentialUrl
			{
				get
				{
					return credentialUrl;
				}
				set	
				{
					credentialUrl = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}
		}
	}
}
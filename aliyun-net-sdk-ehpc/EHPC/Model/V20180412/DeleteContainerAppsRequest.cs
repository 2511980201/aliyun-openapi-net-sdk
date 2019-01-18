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
    public class DeleteContainerAppsRequest : RpcAcsRequest<DeleteContainerAppsResponse>
    {
        public DeleteContainerAppsRequest()
            : base("EHPC", "2018-04-12", "DeleteContainerApps", "ehs", "openAPI")
        {
        }

		private List<ContainerApp> containerApps;

		private string action;

		private string accessKeyId;

		public List<ContainerApp> ContainerApps
		{
			get
			{
				return containerApps;
			}

			set
			{
				containerApps = value;
				for (int i = 0; i < containerApps.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ContainerApp." + (i + 1) + ".Id", containerApps[i].Id);
				}
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

		public class ContainerApp
		{

			private string id;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}

        public override DeleteContainerAppsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteContainerAppsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
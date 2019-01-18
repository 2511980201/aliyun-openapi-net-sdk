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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryPriceListRequest : RpcAcsRequest<QueryPriceListResponse>
    {
        public QueryPriceListRequest()
            : base("BssOpenApi", "2017-12-14", "QueryPriceList")
        {
        }

		private string moduleCode;

		private string productCode;

		private string subscriptionType;

		private long? ownerId;

		private string productType;

		public string ModuleCode
		{
			get
			{
				return moduleCode;
			}
			set	
			{
				moduleCode = value;
				DictionaryUtil.Add(QueryParameters, "ModuleCode", value);
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

        public override QueryPriceListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryPriceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
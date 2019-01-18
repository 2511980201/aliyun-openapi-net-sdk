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
    public class GetPayAsYouGoPriceRequest : RpcAcsRequest<GetPayAsYouGoPriceResponse>
    {
        public GetPayAsYouGoPriceRequest()
            : base("BssOpenApi", "2017-12-14", "GetPayAsYouGoPrice")
        {
        }

		private string productCode;

		private string subscriptionType;

		private List<ModuleList> moduleLists;

		private long? ownerId;

		private string region;

		private string productType;

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

		public List<ModuleList> ModuleLists
		{
			get
			{
				return moduleLists;
			}

			set
			{
				moduleLists = value;
				for (int i = 0; i < moduleLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ModuleList." + (i + 1) + ".ModuleCode", moduleLists[i].ModuleCode);
					DictionaryUtil.Add(QueryParameters,"ModuleList." + (i + 1) + ".PriceType", moduleLists[i].PriceType);
					DictionaryUtil.Add(QueryParameters,"ModuleList." + (i + 1) + ".Config", moduleLists[i].Config);
				}
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

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
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

		public class ModuleList
		{

			private string moduleCode;

			private string priceType;

			private string config;

			public string ModuleCode
			{
				get
				{
					return moduleCode;
				}
				set	
				{
					moduleCode = value;
				}
			}

			public string PriceType
			{
				get
				{
					return priceType;
				}
				set	
				{
					priceType = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}
		}

        public override GetPayAsYouGoPriceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetPayAsYouGoPriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
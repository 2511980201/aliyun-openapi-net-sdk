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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveSingleTaskForCreatingOrderRenewRequest : RpcAcsRequest<SaveSingleTaskForCreatingOrderRenewResponse>
    {
        public SaveSingleTaskForCreatingOrderRenewRequest()
            : base("Domain", "2018-01-29", "SaveSingleTaskForCreatingOrderRenew")
        {
        }

		private int? subscriptionDuration;

		private string promotionNo;

		private long? currentExpirationDate;

		private string userClientIp;

		private string domainName;

		private string couponNo;

		private bool? useCoupon;

		private string lang;

		private bool? usePromotion;

		public int? SubscriptionDuration
		{
			get
			{
				return subscriptionDuration;
			}
			set	
			{
				subscriptionDuration = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDuration", value.ToString());
			}
		}

		public string PromotionNo
		{
			get
			{
				return promotionNo;
			}
			set	
			{
				promotionNo = value;
				DictionaryUtil.Add(QueryParameters, "PromotionNo", value);
			}
		}

		public long? CurrentExpirationDate
		{
			get
			{
				return currentExpirationDate;
			}
			set	
			{
				currentExpirationDate = value;
				DictionaryUtil.Add(QueryParameters, "CurrentExpirationDate", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string CouponNo
		{
			get
			{
				return couponNo;
			}
			set	
			{
				couponNo = value;
				DictionaryUtil.Add(QueryParameters, "CouponNo", value);
			}
		}

		public bool? UseCoupon
		{
			get
			{
				return useCoupon;
			}
			set	
			{
				useCoupon = value;
				DictionaryUtil.Add(QueryParameters, "UseCoupon", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public bool? UsePromotion
		{
			get
			{
				return usePromotion;
			}
			set	
			{
				usePromotion = value;
				DictionaryUtil.Add(QueryParameters, "UsePromotion", value.ToString());
			}
		}

        public override SaveSingleTaskForCreatingOrderRenewResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForCreatingOrderRenewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
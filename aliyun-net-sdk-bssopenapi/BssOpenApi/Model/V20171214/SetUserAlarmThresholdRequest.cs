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
    public class SetUserAlarmThresholdRequest : RpcAcsRequest<SetUserAlarmThresholdResponse>
    {
        public SetUserAlarmThresholdRequest()
            : base("BssOpenApi", "2017-12-14", "SetUserAlarmThreshold")
        {
        }

		private long? uid;

		private string alarmType;

		private string alarmThresholds;

		private string bid;

		public long? Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value.ToString());
			}
		}

		public string AlarmType
		{
			get
			{
				return alarmType;
			}
			set	
			{
				alarmType = value;
				DictionaryUtil.Add(QueryParameters, "AlarmType", value);
			}
		}

		public string AlarmThresholds
		{
			get
			{
				return alarmThresholds;
			}
			set	
			{
				alarmThresholds = value;
				DictionaryUtil.Add(QueryParameters, "AlarmThresholds", value);
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value);
			}
		}

        public override SetUserAlarmThresholdResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetUserAlarmThresholdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
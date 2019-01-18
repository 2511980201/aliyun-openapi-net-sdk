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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.BssOpenApi.Model.V20171214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class SetUserAlarmThresholdResponseUnmarshaller
    {
        public static SetUserAlarmThresholdResponse Unmarshall(UnmarshallerContext context)
        {
			SetUserAlarmThresholdResponse setUserAlarmThresholdResponse = new SetUserAlarmThresholdResponse();

			setUserAlarmThresholdResponse.HttpResponse = context.HttpResponse;
			setUserAlarmThresholdResponse.RequestId = context.StringValue("SetUserAlarmThreshold.RequestId");
			setUserAlarmThresholdResponse.Code = context.StringValue("SetUserAlarmThreshold.Code");
			setUserAlarmThresholdResponse.Message = context.StringValue("SetUserAlarmThreshold.Message");
			setUserAlarmThresholdResponse.Success = context.BooleanValue("SetUserAlarmThreshold.Success");
			setUserAlarmThresholdResponse.Data = context.BooleanValue("SetUserAlarmThreshold.Data");
        
			return setUserAlarmThresholdResponse;
        }
    }
}
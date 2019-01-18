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
using Aliyun.Acs.dms_enterprise.Model.V20181101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class EnableUserResponseUnmarshaller
    {
        public static EnableUserResponse Unmarshall(UnmarshallerContext context)
        {
			EnableUserResponse enableUserResponse = new EnableUserResponse();

			enableUserResponse.HttpResponse = context.HttpResponse;
			enableUserResponse.RequestId = context.StringValue("EnableUser.RequestId");
			enableUserResponse.Success = context.BooleanValue("EnableUser.Success");
			enableUserResponse.ErrorMessage = context.StringValue("EnableUser.ErrorMessage");
			enableUserResponse.ErrorCode = context.StringValue("EnableUser.ErrorCode");
        
			return enableUserResponse;
        }
    }
}
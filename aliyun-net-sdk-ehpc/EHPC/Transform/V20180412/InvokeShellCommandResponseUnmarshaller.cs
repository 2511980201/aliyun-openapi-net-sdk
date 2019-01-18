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
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class InvokeShellCommandResponseUnmarshaller
    {
        public static InvokeShellCommandResponse Unmarshall(UnmarshallerContext context)
        {
			InvokeShellCommandResponse invokeShellCommandResponse = new InvokeShellCommandResponse();

			invokeShellCommandResponse.HttpResponse = context.HttpResponse;
			invokeShellCommandResponse.RequestId = context.StringValue("InvokeShellCommand.RequestId");
			invokeShellCommandResponse.CommandId = context.StringValue("InvokeShellCommand.CommandId");

			List<string> invokeShellCommandResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("InvokeShellCommand.InstanceIds.Length"); i++) {
				invokeShellCommandResponse_instanceIds.Add(context.StringValue("InvokeShellCommand.InstanceIds["+ i +"]"));
			}
			invokeShellCommandResponse.InstanceIds = invokeShellCommandResponse_instanceIds;
        
			return invokeShellCommandResponse;
        }
    }
}
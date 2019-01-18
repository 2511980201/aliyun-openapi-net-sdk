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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class UpdateImageResponseUnmarshaller
    {
        public static UpdateImageResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateImageResponse updateImageResponse = new UpdateImageResponse();

			updateImageResponse.HttpResponse = context.HttpResponse;
			updateImageResponse.RequestId = context.StringValue("UpdateImage.RequestId");
			updateImageResponse.SetId = context.StringValue("UpdateImage.SetId");
			updateImageResponse.ImageUri = context.StringValue("UpdateImage.ImageUri");
			updateImageResponse.RemarksA = context.StringValue("UpdateImage.RemarksA");
			updateImageResponse.RemarksB = context.StringValue("UpdateImage.RemarksB");
			updateImageResponse.CreateTime = context.StringValue("UpdateImage.CreateTime");
			updateImageResponse.ModifyTime = context.StringValue("UpdateImage.ModifyTime");
        
			return updateImageResponse;
        }
    }
}
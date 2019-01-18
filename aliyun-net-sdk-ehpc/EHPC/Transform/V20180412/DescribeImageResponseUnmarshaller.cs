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
    public class DescribeImageResponseUnmarshaller
    {
        public static DescribeImageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageResponse describeImageResponse = new DescribeImageResponse();

			describeImageResponse.HttpResponse = context.HttpResponse;
			describeImageResponse.RequestId = context.StringValue("DescribeImage.RequestId");

			DescribeImageResponse.DescribeImage_ImageInfo imageInfo = new DescribeImageResponse.DescribeImage_ImageInfo();
			imageInfo.System = context.StringValue("DescribeImage.ImageInfo.System");
			imageInfo.Type = context.StringValue("DescribeImage.ImageInfo.Type");
			imageInfo.Status = context.StringValue("DescribeImage.ImageInfo.Status");
			imageInfo.ImageId = context.StringValue("DescribeImage.ImageInfo.ImageId");
			imageInfo.UpdateDateTime = context.StringValue("DescribeImage.ImageInfo.UpdateDateTime");
			imageInfo.Repository = context.StringValue("DescribeImage.ImageInfo.Repository");
			imageInfo.Tag = context.StringValue("DescribeImage.ImageInfo.Tag");
			describeImageResponse.ImageInfo = imageInfo;
        
			return describeImageResponse;
        }
    }
}
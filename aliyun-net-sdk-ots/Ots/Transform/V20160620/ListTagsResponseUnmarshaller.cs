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
using Aliyun.Acs.Ots.Model.V20160620;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ots.Transform.V20160620
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = context.HttpResponse;
			listTagsResponse.TotalCount = context.LongValue("ListTags.TotalCount");
			listTagsResponse.PageNum = context.LongValue("ListTags.PageNum");
			listTagsResponse.PageSize = context.LongValue("ListTags.PageSize");
			listTagsResponse.RequestId = context.StringValue("ListTags.RequestId");

			List<ListTagsResponse.ListTags_TagInfo> listTagsResponse_tagInfos = new List<ListTagsResponse.ListTags_TagInfo>();
			for (int i = 0; i < context.Length("ListTags.TagInfos.Length"); i++) {
				ListTagsResponse.ListTags_TagInfo tagInfo = new ListTagsResponse.ListTags_TagInfo();
				tagInfo.TagKey = context.StringValue("ListTags.TagInfos["+ i +"].TagKey");
				tagInfo.TagValue = context.StringValue("ListTags.TagInfos["+ i +"].TagValue");

				listTagsResponse_tagInfos.Add(tagInfo);
			}
			listTagsResponse.TagInfos = listTagsResponse_tagInfos;
        
			return listTagsResponse;
        }
    }
}
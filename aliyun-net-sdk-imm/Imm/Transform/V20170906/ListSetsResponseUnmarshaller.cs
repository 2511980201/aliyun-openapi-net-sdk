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
    public class ListSetsResponseUnmarshaller
    {
        public static ListSetsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSetsResponse listSetsResponse = new ListSetsResponse();

			listSetsResponse.HttpResponse = context.HttpResponse;
			listSetsResponse.RequestId = context.StringValue("ListSets.RequestId");
			listSetsResponse.NextMarker = context.StringValue("ListSets.NextMarker");

			List<ListSetsResponse.ListSets_SetsItem> listSetsResponse_sets = new List<ListSetsResponse.ListSets_SetsItem>();
			for (int i = 0; i < context.Length("ListSets.Sets.Length"); i++) {
				ListSetsResponse.ListSets_SetsItem setsItem = new ListSetsResponse.ListSets_SetsItem();
				setsItem.SetId = context.StringValue("ListSets.Sets["+ i +"].SetId");
				setsItem.SetName = context.StringValue("ListSets.Sets["+ i +"].SetName");
				setsItem.CreateTime = context.StringValue("ListSets.Sets["+ i +"].CreateTime");
				setsItem.ModifyTime = context.StringValue("ListSets.Sets["+ i +"].ModifyTime");
				setsItem.FaceCount = context.IntegerValue("ListSets.Sets["+ i +"].FaceCount");
				setsItem.ImageCount = context.IntegerValue("ListSets.Sets["+ i +"].ImageCount");
				setsItem.VideoCount = context.IntegerValue("ListSets.Sets["+ i +"].VideoCount");
				setsItem.VideoLength = context.IntegerValue("ListSets.Sets["+ i +"].VideoLength");

				listSetsResponse_sets.Add(setsItem);
			}
			listSetsResponse.Sets = listSetsResponse_sets;
        
			return listSetsResponse;
        }
    }
}
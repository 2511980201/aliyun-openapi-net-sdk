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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeBoardSnapshotResponseUnmarshaller
    {
        public static DescribeBoardSnapshotResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBoardSnapshotResponse describeBoardSnapshotResponse = new DescribeBoardSnapshotResponse();

			describeBoardSnapshotResponse.HttpResponse = context.HttpResponse;
			describeBoardSnapshotResponse.RequestId = context.StringValue("DescribeBoardSnapshot.RequestId");

			DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot snapshot = new DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot();

			DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board board = new DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board();
			board.BoardId = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.BoardId");
			board.AppUid = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.AppUid");
			board.EventTimestamp = context.LongValue("DescribeBoardSnapshot.Snapshot.Board.EventTimestamp");
			board.CreateTimestamp = context.LongValue("DescribeBoardSnapshot.Snapshot.Board.CreateTimestamp");
			board.UpdateTimestamp = context.LongValue("DescribeBoardSnapshot.Snapshot.Board.UpdateTimestamp");

			List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page> board_pages = new List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page>();
			for (int i = 0; i < context.Length("DescribeBoardSnapshot.Snapshot.Board.Pages.Length"); i++) {
				DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page page = new DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page();
				page.PageIndex = context.IntegerValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].PageIndex");

				List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page.DescribeBoardSnapshot_Element> page_elements = new List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page.DescribeBoardSnapshot_Element>();
				for (int j = 0; j < context.Length("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements.Length"); j++) {
					DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page.DescribeBoardSnapshot_Element element = new DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Page.DescribeBoardSnapshot_Element();
					element.ElementIndex = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements["+ j +"].ElementIndex");
					element.OwnerId = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements["+ j +"].OwnerId");
					element.ElementType = context.IntegerValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements["+ j +"].ElementType");
					element.UpdateTimestamp = context.LongValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements["+ j +"].UpdateTimestamp");
					element.Data = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.Pages["+ i +"].Elements["+ j +"].Data");

					page_elements.Add(element);
				}
				page.Elements = page_elements;

				board_pages.Add(page);
			}
			board.Pages = board_pages;

			List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Config> board_configs = new List<DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Config>();
			for (int i = 0; i < context.Length("DescribeBoardSnapshot.Snapshot.Board.Configs.Length"); i++) {
				DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Config config = new DescribeBoardSnapshotResponse.DescribeBoardSnapshot_Snapshot.DescribeBoardSnapshot_Board.DescribeBoardSnapshot_Config();
				config.AppUid = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.Configs["+ i +"].AppUid");
				config.Data = context.StringValue("DescribeBoardSnapshot.Snapshot.Board.Configs["+ i +"].Data");

				board_configs.Add(config);
			}
			board.Configs = board_configs;
			snapshot.Board = board;
			describeBoardSnapshotResponse.Snapshot = snapshot;
        
			return describeBoardSnapshotResponse;
        }
    }
}
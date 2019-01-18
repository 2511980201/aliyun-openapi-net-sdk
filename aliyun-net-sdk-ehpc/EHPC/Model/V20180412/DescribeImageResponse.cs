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
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class DescribeImageResponse : AcsResponse
	{

		private string requestId;

		private DescribeImage_ImageInfo imageInfo;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeImage_ImageInfo ImageInfo
		{
			get
			{
				return imageInfo;
			}
			set	
			{
				imageInfo = value;
			}
		}

		public class DescribeImage_ImageInfo
		{

			private string system;

			private string type;

			private string status;

			private string imageId;

			private string updateDateTime;

			private string repository;

			private string tag;

			public string System
			{
				get
				{
					return system;
				}
				set	
				{
					system = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string UpdateDateTime
			{
				get
				{
					return updateDateTime;
				}
				set	
				{
					updateDateTime = value;
				}
			}

			public string Repository
			{
				get
				{
					return repository;
				}
				set	
				{
					repository = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}
		}
	}
}
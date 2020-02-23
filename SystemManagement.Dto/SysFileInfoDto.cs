﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemManagement.Dto
{
	public class SysFileInfoDto
	{
		/// <summary>
		/// 创建人
		/// </summary>
		public long? CreateBy { get; set; }

		/// <summary>
		/// 创建时间/注册时间
		/// </summary>
		public DateTime? CreateTime { get; set; }

		public long ID { get; set; }

		/// <summary>
		/// 最后更新人
		/// </summary>
		public long? ModifyBy { get; set; }

		/// <summary>
		/// 最后更新时间
		/// </summary>
		public DateTime? ModifyTime { get; set; }

		public string OriginalFileName { get; set; }

		public string RealFileName { get; set; }
	}
}

﻿using Service.Core.Client.Constants;

namespace Service.Education.Contracts.State
{
	public interface IFinishStateResponse
	{
		public int Test { get; set; }

		public int TrueFalse { get; set; }

		public int Case { get; set; }

		public int Game { get; set; }

		public int Video { get; set; }

		public int Text { get; set; }

		public UserAchievement[] Achievements { get; set; }
	}
}
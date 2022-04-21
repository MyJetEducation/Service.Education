using Service.Core.Client.Constants;

namespace Service.Education.Contracts.State
{
	public interface IFinishStateResponse
	{
		int Test { get; set; }

		int TrueFalse { get; set; }

		int Case { get; set; }

		int Game { get; set; }

		int Video { get; set; }

		int Text { get; set; }

		UserAchievement[] Achievements { get; set; }
	}
}
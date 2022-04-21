namespace Service.Education.Contracts.State
{
	public interface IFinishStateRequest
	{
		string UserId { get; set; }

		int? Unit { get; set; }
	}
}
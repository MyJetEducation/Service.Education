namespace Service.Education.Contracts.State
{
	public interface IFinishStateRequest
	{
		public string UserId { get; set; }

		public int? Unit { get; set; }
	}
}
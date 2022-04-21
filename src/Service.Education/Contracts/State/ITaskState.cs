namespace Service.Education.Contracts.State
{
	public interface ITaskState
	{
		int Task { get; set; }

		int TestScore { get; set; }

		ITaskRetryInfo RetryInfo { get; set; }
	}
}
namespace Service.Education.Contracts.State
{
	public interface ITaskRetryInfo
	{
		bool InRetry { get; set; }

		bool CanRetryByTime { get; set; }

		bool CanRetryByCount { get; set; }
	}
}
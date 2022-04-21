namespace Service.Education.Contracts.State
{
	public interface ITaskState
	{
		public int Task { get; set; }

		public int TestScore { get; set; }

		public ITaskRetryInfo RetryInfo { get; set; }
	}
}
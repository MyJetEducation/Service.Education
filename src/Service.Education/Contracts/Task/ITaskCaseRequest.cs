using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskCaseRequest
	{
		public string UserId { get; set; }

		public int Value { get; set; }

		public bool IsRetry { get; set; }

		public TimeSpan Duration { get; set; }
	}
}
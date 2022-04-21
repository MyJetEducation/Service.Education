using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskGameRequest
	{
		public string UserId { get; set; }

		public bool IsRetry { get; set; }

		public TimeSpan Duration { get; set; }

		public bool Passed { get; set; }
	}
}
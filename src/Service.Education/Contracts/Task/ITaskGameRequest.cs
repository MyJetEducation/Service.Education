using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskGameRequest
	{
		string UserId { get; set; }

		bool IsRetry { get; set; }

		TimeSpan Duration { get; set; }

		bool Passed { get; set; }
	}
}
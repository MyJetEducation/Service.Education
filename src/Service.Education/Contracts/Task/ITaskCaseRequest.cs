using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskCaseRequest
	{
		string UserId { get; set; }

		int Value { get; set; }

		bool IsRetry { get; set; }

		TimeSpan Duration { get; set; }
	}
}
using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskTestRequest
	{
		string UserId { get; set; }

		ITaskTestAnswer[] Answers { get; set; }

		bool IsRetry { get; set; }

		TimeSpan Duration { get; set; }
	}
}
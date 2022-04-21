using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskTrueFalseRequest
	{
		string UserId { get; set; }

		ITaskTrueFalseAnswer[] Answers { get; set; }

		bool IsRetry { get; set; }

		TimeSpan Duration { get; set; }
	}
}
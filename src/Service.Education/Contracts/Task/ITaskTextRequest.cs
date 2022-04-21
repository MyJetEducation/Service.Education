using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskTextRequest
	{
		string UserId { get; set; }

		bool IsRetry { get; set; }

		TimeSpan Duration { get; set; }
	}
}
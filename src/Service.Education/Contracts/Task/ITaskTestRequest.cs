using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskTestRequest
	{
		public string UserId { get; set; }

		public ITaskTestAnswer[] Answers { get; set; }

		public bool IsRetry { get; set; }

		public TimeSpan Duration { get; set; }
	}
}
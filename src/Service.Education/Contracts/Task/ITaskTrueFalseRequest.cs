using System;

namespace Service.Education.Contracts.Task
{
	public interface ITaskTrueFalseRequest
	{
		public string UserId { get; set; }

		public ITaskTrueFalseAnswer[] Answers { get; set; }

		public bool IsRetry { get; set; }

		public TimeSpan Duration { get; set; }
	}
}
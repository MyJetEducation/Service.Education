using System.Runtime.Serialization;

namespace Service.Education.Contracts.Task
{
	[DataContract]
	public class TaskTrueFalseAnswerGrpcModel : ITaskTrueFalseAnswer
	{
		[DataMember(Order = 1)]
		public int Number { get; set; }

		[DataMember(Order = 2)]
		public bool Value { get; set; }
	}
}
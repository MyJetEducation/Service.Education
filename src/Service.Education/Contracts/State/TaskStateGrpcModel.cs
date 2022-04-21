using System.Runtime.Serialization;

namespace Service.Education.Contracts.State
{
	[DataContract]
	public class TaskStateGrpcModel
	{
		[DataMember(Order = 1)]
		public int Task { get; set; }

		[DataMember(Order = 2)]
		public int TestScore { get; set; }

		[DataMember(Order = 3)]
		public TaskRetryInfoGrpcModel RetryInfo { get; set; }
	}
}
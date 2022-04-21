using System.Runtime.Serialization;

namespace Service.Education.Contracts.State
{
	[DataContract]
	public class StateGrpcModel
	{
		[DataMember(Order = 1)]
		public int Unit { get; set; }

		[DataMember(Order = 2)]
		public int TestScore { get; set; }

		[DataMember(Order = 3)]
		public TaskStateGrpcModel[] Tasks { get; set; }
	}
}
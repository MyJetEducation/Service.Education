namespace Service.Education.Contracts.State
{
	public interface IUnitState
	{
		int Unit { get; set; }

		int TestScore { get; set; }

		ITaskState[] Tasks { get; set; }
	}
}
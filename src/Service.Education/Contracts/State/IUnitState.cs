namespace Service.Education.Contracts.State
{
	public interface IUnitState
	{
		public int Unit { get; set; }

		public int TestScore { get; set; }

		public ITaskState[] Tasks { get; set; }
	}
}
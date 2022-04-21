namespace Service.Education.Contracts.State
{
	public interface ITestScore
	{
		public bool IsSuccess { get; set; }

		public IUnitState Unit { get; set; }
	}
}
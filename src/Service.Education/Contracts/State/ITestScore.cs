namespace Service.Education.Contracts.State
{
	public interface ITestScore
	{
		bool IsSuccess { get; set; }

		IUnitState Unit { get; set; }
	}
}
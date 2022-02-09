using Service.Education.Constants;

namespace Service.Education.Extensions
{
	public static class ProgressExtensions
	{
		public static bool IsMaxProgress(this int value) => value == Progress.MaxProgress;

		public static bool IsMinProgress(this int value) => value == Progress.MinProgress;

		public static bool IsOkProgress(this int value) => value >= Progress.OkProgress;
	}
}
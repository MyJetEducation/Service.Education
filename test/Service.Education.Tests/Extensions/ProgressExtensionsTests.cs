using NUnit.Framework;
using Service.Education.Extensions;

namespace Service.Education.Tests.Extensions
{
	public class ProgressExtensionsTests
	{
		[TestCase(0, false)]
		[TestCase(10, false)]
		[TestCase(50, false)]
		[TestCase(79, false)]
		[TestCase(80, true)]
		[TestCase(90, true)]
		[TestCase(100, true)]
		public void IsOkProgress_return_value(int progressValue, bool boolValue)
		{
			bool result = progressValue.IsOkProgress();

			Assert.AreEqual(boolValue, result);
		}

		[TestCase(0, false)]
		[TestCase(90, false)]
		[TestCase(100, true)]
		public void IsMaxProgress_return_value(int progressValue, bool boolValue)
		{
			bool result = progressValue.IsMaxProgress();

			Assert.AreEqual(boolValue, result);
		}

		[TestCase(0, true)]
		[TestCase(1, false)]
		[TestCase(100, false)]
		public void IsMinProgress_return_value(int progressValue, bool boolValue)
		{
			bool result = progressValue.IsMinProgress();

			Assert.AreEqual(boolValue, result);
		}
	}
}
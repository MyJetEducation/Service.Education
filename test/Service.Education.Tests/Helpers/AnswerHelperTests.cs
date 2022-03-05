using NUnit.Framework;
using Service.Education.Constants;
using Service.Education.Helpers;

namespace Service.Education.Tests.Helpers
{
	public class AnswerHelperTests
	{
		private static readonly (int, int, int[], int[], int)[] AnswerData =
		{
			(1, 20, new[] {1, 3}, new[] {1, 3}, 20),
			(1, 20, new[] {1, 3}, new[] {1, 2, 3}, 0),
			(1, 20, new[] {1, 3}, new[] {1}, 10),
			(2, 20, new[] {1, 3}, new[] {3}, 10),
			(2, 20, new[] {1, 3}, new[] {2}, 0),
			(2, 20, new[] {1, 3}, new[] {4, 5}, 0),
			(2, 60, new[] {1, 2, 3}, new[] {1, 2, 3}, 60),
			(3, 60, new[] {1, 2, 3}, new[] {1, 2}, 40),
			(3, 60, new[] {1, 2, 3}, new[] {2}, 20),
			(3, 60, new[] {1, 2, 3}, new[] {2, 4}, 0),
			(3, 100, new[] {1, 2, 3}, new[] {1}, 33),
			(4, 100, new[] {1, 2, 3}, new[] {1, 2}, 67),
			(4, 100, new[] {1, 2, 3}, new[] {1, 2, 3}, 100)
		};

		[TestCaseSource(nameof(AnswerData))]
		public void TestAnswers((int questionNumber, int answerProgress, int[] correctAnswers, int[] userAnswers, int expectedValue) tuple)
		{
			(int questionNumber, int answerProgress, int[] correctAnswers, int[] userAnswers, int expectedValue) = tuple;

			int value = AnswerHelper.CheckAnswer(
				answerProgress,
				new ITaskTestAnswer[] {new UserAnswer(questionNumber, userAnswers)},
				questionNumber,
				correctAnswers
				);

			Assert.AreEqual(expectedValue, value);
		}

		[Test]
		public void TestFullProgress()
		{
			ITaskTestAnswer[] answers =
			{
				new UserAnswer(1, 1, 3),
				new UserAnswer(2, 1, 3),
				new UserAnswer(3, 3),
				new UserAnswer(4, 1, 2, 3),
				new UserAnswer(5, 1, 3)
			};

			int progress = AnswerHelper.CheckAnswer(20, answers, 1, 1, 3)
				+ AnswerHelper.CheckAnswer(20, answers, 2, 1, 3)
				+ AnswerHelper.CheckAnswer(20, answers, 3, 3)
				+ AnswerHelper.CheckAnswer(20, answers, 4, 1, 2, 3)
				+ AnswerHelper.CheckAnswer(20, answers, 5, 1, 3);

			Assert.AreEqual(Progress.MaxProgress, progress);
		}

		private class UserAnswer : ITaskTestAnswer
		{
			public UserAnswer(int number, params int[] value)
			{
				Number = number;
				Value = value;
			}

			public int Number { get; set; }
			public int[] Value { get; set; }
		}
	}
}
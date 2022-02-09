using System.Linq;
using Service.Education.Constants;
using Service.Education.Structure;

namespace Service.Education.Helpers
{
	public static class AnswerHelper
	{
		public static readonly EducationStructureTutorial Tutorial = EducationStructure.Tutorials[EducationTutorial.PersonalFinance];

		public static int CheckAnswer(int progressPrc, ITaskTestAnswer[] answers, int questionNumber, params int[] answerNumbers)
		{
			ITaskTestAnswer answer = answers.FirstOrDefault(model => model.Number == questionNumber);

			return CountProgress(answer != null && answerNumbers.Intersect(answer.Value).Count() == answerNumbers.Length, progressPrc);
		}

		public static int CheckAnswer(int progressPrc, ITaskTrueFalseAnswer[] answers, int questionNumber, bool answerValue)
		{
			ITaskTrueFalseAnswer answer = answers.FirstOrDefault(model => model.Number == questionNumber);

			return CountProgress(answer != null && answer.Value == answerValue, progressPrc);
		}

		public static int CountProgress(bool taskPassed, int progress = Progress.MaxProgress) => taskPassed ? progress : Progress.MinProgress;
	}
}
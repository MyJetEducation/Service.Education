using System.Collections.Generic;

namespace Service.Education.Structure
{
	public class EducationStructure
	{
		public const int TutorialCount = 9;
		public const int UnitsCount = 5;
		public const int TasksCount = 6;

		public static IDictionary<EducationTutorial, EducationStructureTutorial> Tutorials = new Dictionary<EducationTutorial, EducationStructureTutorial>
		{
			{EducationTutorial.PersonalFinance, new EducationStructureTutorial {Tutorial = EducationTutorial.PersonalFinance, Units = DefaultUnit}},
			{EducationTutorial.BehavioralFinance, new EducationStructureTutorial {Tutorial = EducationTutorial.BehavioralFinance, Units = DefaultUnit}},
			{EducationTutorial.FinancialServices, new EducationStructureTutorial {Tutorial = EducationTutorial.FinancialServices, Units = DefaultUnit}},
			{EducationTutorial.FinanceMarkets, new EducationStructureTutorial {Tutorial = EducationTutorial.FinanceMarkets, Units = DefaultUnit}},
			{EducationTutorial.HealthAndFinance, new EducationStructureTutorial {Tutorial = EducationTutorial.HealthAndFinance, Units = DefaultUnit}},
			{EducationTutorial.PsychologyAndFinance, new EducationStructureTutorial {Tutorial = EducationTutorial.PsychologyAndFinance, Units = DefaultUnit}},
			{EducationTutorial.FinanceSecurity, new EducationStructureTutorial {Tutorial = EducationTutorial.FinanceSecurity, Units = DefaultUnit}},
			{EducationTutorial.TimeManagement, new EducationStructureTutorial {Tutorial = EducationTutorial.TimeManagement, Units = DefaultUnit}},
			{EducationTutorial.Economics, new EducationStructureTutorial {Tutorial = EducationTutorial.Economics, Units = DefaultUnit}}
		};

		private static Dictionary<int, EducationStructureUnit> DefaultUnit => new()
		{
			{1, new EducationStructureUnit {Unit = 1, Tasks = DefaultTasks}},
			{2, new EducationStructureUnit {Unit = 2, Tasks = DefaultTasks}},
			{3, new EducationStructureUnit {Unit = 3, Tasks = DefaultTasks}},
			{4, new EducationStructureUnit {Unit = 4, Tasks = DefaultTasks}},
			{5, new EducationStructureUnit {Unit = 5, Tasks = DefaultTasks}},
		};

		private static Dictionary<int, EducationStructureTask> DefaultTasks => new()
		{
			{1, new EducationStructureTask(1, EducationTaskType.Text)},
			{2, new EducationStructureTask(2, EducationTaskType.Test)},
			{3, new EducationStructureTask(3, EducationTaskType.Video)},
			{4, new EducationStructureTask(4, EducationTaskType.Case)},
			{5, new EducationStructureTask(5, EducationTaskType.TrueFalse)},
			{6, new EducationStructureTask(6, EducationTaskType.Game)}
		};
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Service.Education.Helpers;
using Service.Education.Structure;

namespace Service.Education.Tests.Helpers
{
	public class EducationHelperTests
	{
		private static EducationTutorial[] _testTutorials = Enum.GetValues<EducationTutorial>()
			.Where(tutorial => tutorial != EducationTutorial.None)
			.ToArray();

		[Test]
		public void Test_tutorials_count()
		{
			Assert.AreEqual(EducationStructure.TutorialCount, _testTutorials.Length);
		}

		[Test]
		public void GetProjections_returns_structure_projections()
		{
			(EducationTutorial Tutorial, int Unit, int Task)[] projections = EducationHelper.GetProjections();

			const int totalUnitTasksCount = EducationStructure.UnitsCount * EducationStructure.TasksCount;
			const int totalTasksCount = EducationStructure.TutorialCount * totalUnitTasksCount;

			Assert.AreEqual(totalTasksCount, projections.Length);

			foreach (EducationTutorial tutorial in _testTutorials)
			{
				(EducationTutorial Tutorial, int Unit, int Task)[] tutorialProjections = projections.Where(tuple => tuple.Tutorial == tutorial).ToArray();

				Assert.AreEqual(totalUnitTasksCount, tutorialProjections.Length);

				for (var i = 1; i <= EducationStructure.UnitsCount; i++)
				{
					int tasksCount = tutorialProjections.Count(tuple => tuple.Unit == i);

					Assert.AreEqual(EducationStructure.TasksCount, tasksCount);
				}
			}
		}

		[TestCaseSource(nameof(_testTutorials))]
		public void GetTutorial_return_structure_tutorial(EducationTutorial tutorial)
		{
			EducationStructureTutorial structureTutorial = EducationHelper.GetTutorial(tutorial);

			Assert.AreEqual(tutorial, structureTutorial.Tutorial);

			IDictionary<int, EducationStructureUnit> units = structureTutorial.Units;
			Assert.AreEqual(EducationStructure.UnitsCount, units.Count);

			for (var i = 1; i <= EducationStructure.UnitsCount; i++)
			{
				EducationStructureUnit unit = units[i];

				AssertUnit(i, unit);
			}
		}

		[TestCaseSource(nameof(_testTutorials))]
		public void GetUnit_return_structure_unit(EducationTutorial tutorial)
		{
			for (var i = 1; i <= EducationStructure.UnitsCount; i++)
			{
				EducationStructureUnit unit = EducationHelper.GetUnit(tutorial, i);

				AssertUnit(i, unit);
			}
		}

		[TestCaseSource(nameof(_testTutorials))]
		public void GetTask_return_structure_task(EducationTutorial tutorial)
		{
			for (var i = 1; i <= EducationStructure.UnitsCount; i++)
			{
				for (var j = 1; j <= EducationStructure.TasksCount; j++)
				{
					EducationStructureTask task = EducationHelper.GetTask(tutorial, i, j);

					AssertTask(j, task);
				}
			}
		}

		[TestCaseSource(nameof(_testTutorials))]
		public void GetUnitTask_return_structure_task_and_unit(EducationTutorial tutorial)
		{
			for (var i = 1; i <= EducationStructure.UnitsCount; i++)
			{
				for (var j = 1; j <= EducationStructure.TasksCount; j++)
				{
					(EducationStructureUnit unit, EducationStructureTask task)? tuple = EducationHelper.GetUnitTask(tutorial, i, j);

					Assert.IsNotNull(tuple);
					AssertUnit(i, tuple.Value.unit);
					AssertTask(j, tuple.Value.task);
				}
			}
		}

		private static void AssertUnit(int i, EducationStructureUnit unit)
		{
			Assert.AreEqual(i, unit.Unit);

			IDictionary<int, EducationStructureTask> tasks = unit.Tasks;
			Assert.AreEqual(EducationStructure.TasksCount, tasks.Count);

			for (var j = 1; j <= EducationStructure.TasksCount; j++)
			{
				EducationStructureTask task = tasks[j];

				AssertTask(j, task);
			}
		}

		private static void AssertTask(int index, EducationStructureTask task)
		{
			Assert.AreEqual(index, task.Task);

			switch (index)
			{
				case 1:
					Assert.AreEqual(EducationTaskType.Text, task.TaskType);
					break;
				case 2:
					Assert.AreEqual(EducationTaskType.Test, task.TaskType);
					break;
				case 3:
					Assert.AreEqual(EducationTaskType.Video, task.TaskType);
					break;
				case 4:
					Assert.AreEqual(EducationTaskType.Case, task.TaskType);
					break;
				case 5:
					Assert.AreEqual(EducationTaskType.TrueFalse, task.TaskType);
					break;
				case 6:
					Assert.AreEqual(EducationTaskType.Game, task.TaskType);
					break;
			}
		}
	}
}
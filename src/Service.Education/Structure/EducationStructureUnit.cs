using System.Collections.Generic;

namespace Service.Education.Structure
{
	public class EducationStructureUnit
	{
		public int Unit { get; set; }

		public IDictionary<int, EducationStructureTask> Tasks { get; set; }
	}
}
using System.Collections.Generic;

namespace Service.Education.Structure
{
	public class EducationStructureTutorial
	{
		public EducationTutorial Tutorial { get; set; }

		public IDictionary<int, EducationStructureUnit> Units { get; set; }
	}
}
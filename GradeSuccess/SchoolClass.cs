using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GradeSuccess.Enums;

namespace GradeSuccess
{

    class SchoolClass
    {
        public string Name { get; set; }
        public bool HasPartialGrades { get; set; }
        public LetterGrade grade { get; private set; }
        public int NumberOfCategories { get; private set; }
        private List<GradeCategory> gradeCategories = new List<GradeCategory>();
        
        public void AddCategory(GradeCategory category)
        {
            gradeCategories.Add(category);
        }

        public GradeCategory RemoveCategory(int index)
        {
            try
            {
                gradeCategories.RemoveAt(index);
            }
            catch (IndexOutOfRangeException)
            {

            }

            return gradeCategories.ElementAtOrDefault(index);
        }
    }
}

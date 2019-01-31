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
        
        public SchoolClass()
        {
            NumberOfCategories = 0;
        }

        public void AddCategory(GradeCategory category)
        {
            gradeCategories.Add(category);
            NumberOfCategories++;

        }

        public GradeCategory RemoveCategory(int index)
        {
            try
            {
                gradeCategories.RemoveAt(index);
                NumberOfCategories--;
                if(NumberOfCategories < 0)
                {
                    throw new InvalidOperationException();
                }
            }
            catch (IndexOutOfRangeException)
            {

            }

            return gradeCategories.ElementAtOrDefault(index);
        }

        public void AddAssignment(string name, GradeCategory category, int current, int max)
        {
            Assignment assignment = new Assignment(name, category, current, max);
            if (gradeCategories.Contains(category))
            {
                category.AddAssignment(assignment);
            }
        }


    }
}

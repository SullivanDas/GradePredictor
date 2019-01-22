using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GradeSuccess.Enums;

namespace GradeSuccess
{
    class Assignment
    {
        public string Name { get; set; }
        public GradeCategory Category { get; set; }
        public LetterGrade Grade { get; private set; }
        public bool HasPartialGrades { get; set; }
        public double CurrentPoints { get; private set; }
        public double MaxPoints { get; private set; }

        public Assignment(string name, GradeCategory category, int current, int max)
        {
            Name = name;
            Category = category;
            CurrentPoints = current;
            MaxPoints = max;
            UpdateLetterGrade();
        }

        public void SetPoints(double current, double max)
        {
            CurrentPoints = current;
            MaxPoints = max;
            UpdateLetterGrade();
        }

        private void UpdateLetterGrade()
        {
            double classPercent = (double)(CurrentPoints / MaxPoints);
            Grade = PercentToLetter(classPercent);
        }

        private LetterGrade PercentToLetter(double percent)
        {

            if (HasPartialGrades)
            {
                if (percent >= 0.94)
                {
                    return LetterGrade.A;
                }
                else if (percent >= 0.90)
                {
                    return LetterGrade.AMinus;
                }
                else if (percent >= 0.87)
                {
                    return LetterGrade.BPlus;
                }
                else if (percent >= 0.84)
                {
                    return LetterGrade.B;
                }
                else if (percent >= 0.80)
                {
                    return LetterGrade.BMinus;
                }
                else if (percent >= 0.77)
                {
                    return LetterGrade.CPlus;
                }
                else if (percent >= 0.74)
                {
                    return LetterGrade.C;
                }
                else if (percent >= 0.70)
                {
                    return LetterGrade.CMinus;
                }
                else if (percent >= 0.67)
                {
                    return LetterGrade.DPlus;
                }
                else if (percent >= 0.64)
                {
                    return LetterGrade.D;
                }
                else if (percent >= 0.60)
                {
                    return LetterGrade.DMinus;
                }
                else
                {
                    return LetterGrade.F;
                }


            }
            else
            {
                if (percent >= 0.90)
                {
                    return LetterGrade.A;
                }
                else if (percent >= 0.80)
                {
                    return LetterGrade.B;
                }
                else if (percent >= 0.70)
                {
                    return LetterGrade.C;
                }
                else if (percent >= 0.60)
                {
                    return LetterGrade.D;
                }
                else
                {
                    return LetterGrade.F;
                }
            }

        }

        public string GetCategoryType()
        {
            return Category.Name;
        }

        public override string ToString()
        {
            return GetType().Name + " Name: " + Name + " Category " + Category.Name + " CurrentPoints: " + CurrentPoints + " MaxPoints: " + MaxPoints + " Grade: " + Grade + " HasPartialGrades: " + HasPartialGrades;
        }
    }
}

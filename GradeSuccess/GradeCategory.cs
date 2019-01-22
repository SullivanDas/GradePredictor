using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GradeSuccess.Enums;

namespace GradeSuccess
{
    
    class GradeCategory
    {
        public float PercentOfGrade { get; set; }
        public string Name { get; set; }
        public bool HasPartialGrades { get; set; }
        public LetterGrade Grade { get; private set; }
        public double MaxPoints { get; private set; }
        public double CurrentPoints { get; private set; }
        public int NumberOfAssignments { get; private set; }
        private List<Assignment> assignments = new List<Assignment>();

        public GradeCategory(float percentOfGrade, string name)
        {
            PercentOfGrade = percentOfGrade;
            Name = name;
            NumberOfAssignments = 0;
        }

        public void AddAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
            NumberOfAssignments++;
            UpdatePoints();
        }

        private void UpdatePoints()
        {
            MaxPoints = 0;
            CurrentPoints = 0;
            foreach(Assignment a in assignments)
            {
                MaxPoints += a.MaxPoints;
                CurrentPoints += a.CurrentPoints;
            }

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

        public override string ToString()
        {
            return GetType().Name + " PercentOfGrade: " + PercentOfGrade + " Name " + Name + " MaxPoints " + MaxPoints + " CurrentPoints " + CurrentPoints + " Grade " + Grade + " HasPartialGrades " + HasPartialGrades + " NumberOfAssignments " + NumberOfAssignments;
        }
    }
}

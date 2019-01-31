using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSuccess
{
    class ClassManager
    {
        public int NumberOfClasses { get; private set; }
        private List<SchoolClass> classes = new List<SchoolClass>();

        public ClassManager()
        {
            NumberOfClasses = 0;
        }
        public void AddClass(SchoolClass schoolClass)
        {
            classes.Add(schoolClass);
            NumberOfClasses++;
        }

        public void RemoveClass(int index)
        {
            try
            {
                classes.RemoveAt(index);
                NumberOfClasses--;
                if(NumberOfClasses < 0)
                {
                    throw new InvalidOperationException();
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        public SchoolClass GetClass(int index)
        {
            try
            {
                return classes.ElementAt(index);
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}

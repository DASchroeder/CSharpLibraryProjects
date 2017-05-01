using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        //Test comment due to git trouble
        List<float> grades = new List<float>();
    }
}

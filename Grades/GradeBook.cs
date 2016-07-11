using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _grades = new List<float>();
        }

        private List<float> _grades;

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics statistics = new GradeStatistics();

            float sum = 0;
            foreach (var grade in _grades)
            {
                statistics.HighestGrade = Math.Max(grade, statistics.HighestGrade);
                statistics.LowestGrade = Math.Min(grade, statistics.LowestGrade);
                sum += grade;
            }
            statistics.AvgGrade = sum/_grades.Count;
            return statistics;
        }
    }
}

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AvgGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
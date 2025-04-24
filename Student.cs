// Represents a Student
public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    // Adds a single grade
    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    // Adds multiple grades using params
    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    // Calculates average grade
    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
            return 0;

        return Grades.Average();
    }
}
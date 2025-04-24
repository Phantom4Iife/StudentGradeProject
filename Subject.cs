public class Subject
{
    public string Title { get; set; }
    public string Code { get; set; }
    public List<Student> Participants { get; set; }

    public Subject()
    {
        Participants = new List<Student>();
    }

    // Registers a student into the course 
    public void RegisterStudent(Student student)
    {
        if (!Participants.Exists(s => s.ID == student.ID))
        {
            Participants.Add(student);
            Console.WriteLine($"Student {student.Name} has been added to {Title}.");
        }
        else
        {
            Console.WriteLine($"Student {student.Name} is already enrolled in {Title}.");
        }
    }
}
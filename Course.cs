using System.Collections.Generic;

public class Course
{
    private static int nextId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public List<Student> Students { get; private set; }

    public Course()
    {
        Id = nextId++;
        Name = "";
        Students = new List<Student>();
    }

    public Course(string name)
    {
        Id = nextId++;
        Name = name;
        Students = new List<Student>();
    }

    public override string ToString()
    {
        return $"Course Id: {Id}, Name: {Name}, Students: {Students.Count}";
    }
}
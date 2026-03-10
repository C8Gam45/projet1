using System.Collections.Generic;

public class Course
{
    private static int nextId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public int Credits { get; set; }
    public bool IsMandatory { get; set; }
    public List<Student> Students { get; private set; }

    public Course()
    {
        Id = nextId++;
        Name = "";
        Credits = 0;
        IsMandatory = false;
        Students = new List<Student>();
    }

    public Course(string name, int credits, bool isMandatory)
    {
        Id = nextId++;
        Name = name;
        Credits = credits;
        IsMandatory = isMandatory;
        Students = new List<Student>();
    }

    public Course(string name)
    {
        Id = nextId++;
        Name = name;
        Credits = 0;
        IsMandatory = false;
        Students = new List<Student>();
    }

    public override string ToString()
    {
        return $"Course Id: {Id}, Name: {Name}, Credits: {Credits}, Mandatory: {IsMandatory}, Students: {Students.Count}";
    }
}
public class Student
{
    private static int nextId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public double Average { get; set; }
    public bool IsScholarshipHolder { get; set; }

    // Constructeur sans paramètres
    public Student()
    {
        Id = nextId++;
        Name = "";
        Average = 0.0;
        IsScholarshipHolder = false;
    }

    // Constructeur complet
    public Student(string name, double average, bool isScholarshipHolder)
    {
        Id = nextId++;
        Name = name;
        Average = average;
        IsScholarshipHolder = isScholarshipHolder;
    }

    // Constructeur partiel
    public Student(string name, double average)
    {
        Id = nextId++;
        Name = name;
        Average = average;
        // IsScholarshipHolder devra être complété avec l'accesseur
    }
}
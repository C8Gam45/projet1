namespace projet1;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student("Alice", 15.5, true);
        Console.WriteLine(alice);

        Student bernard = new Student("Bernard", 12.0);
        bernard.IsScholarshipHolder = false;
        Console.WriteLine(bernard);

        Student emma = new Student();
        emma.Name = "Emma";
        emma.Average = 14.2;
        emma.IsScholarshipHolder = true;
        Console.WriteLine(emma);

        Student lucas = new Student("Lucas", 16.0, false);
        Console.WriteLine(lucas);

        Student sarah = new Student("Sarah", 13.5);
        sarah.IsScholarshipHolder = true;
        Console.WriteLine(sarah);

        // Créer les cours
        Course math = new Course("Mathématiques", 5, true);
        Console.WriteLine(math);

        Course info = new Course("Informatique");
        info.Credits = 4;
        info.IsMandatory = false;
        Console.WriteLine(info);

        Course anglais = new Course("Anglais", 3, false);
        Console.WriteLine(anglais);

        Course histoire = new Course();
        histoire.Name = "Histoire";
        histoire.Credits = 2;
        histoire.IsMandatory = true;
        Console.WriteLine(histoire);

        // Inscrire les étudiants dans les cours
        math.Students.Add(alice);
        math.Students.Add(bernard);
        math.Students.Add(emma);

        info.Students.Add(bernard);
        info.Students.Add(lucas);

        anglais.Students.Add(alice);
        anglais.Students.Add(sarah);

        histoire.Students.Add(lucas);

        // Afficher les cours avec leurs étudiants
        Console.WriteLine("\nCours et étudiants inscrits :");
        Console.WriteLine($"{math.Name}: {string.Join(", ", math.Students.Select(s => s.Name))}");
        Console.WriteLine($"{info.Name}: {string.Join(", ", info.Students.Select(s => s.Name))}");
        Console.WriteLine($"{anglais.Name}: {string.Join(", ", anglais.Students.Select(s => s.Name))}");
        Console.WriteLine($"{histoire.Name}: {string.Join(", ", histoire.Students.Select(s => s.Name))}");
    }
}

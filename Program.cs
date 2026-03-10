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

        math.Students.Add(alice);
        math.Students.Add(bernard);
        math.Students.Add(emma);

        info.Students.Add(bernard);
        info.Students.Add(lucas);

        anglais.Students.Add(alice);
        anglais.Students.Add(sarah);

        histoire.Students.Add(lucas);

        Console.WriteLine("\nCours et étudiants inscrits :");
        Console.WriteLine($"{math.Name}: {string.Join(", ", math.Students.Select(s => s.Name))}");
        Console.WriteLine($"{info.Name}: {string.Join(", ", info.Students.Select(s => s.Name))}");
        Console.WriteLine($"{anglais.Name}: {string.Join(", ", anglais.Students.Select(s => s.Name))}");
        Console.WriteLine($"{histoire.Name}: {string.Join(", ", histoire.Students.Select(s => s.Name))}");

        List<Student> students = new List<Student> { alice, bernard, emma, lucas, sarah };
        List<Course> courses = new List<Course> { math, info, anglais, histoire };

        Console.WriteLine("\nExercice 7 - Supprimer un étudiant d'un cours");
        math.Students.Remove(emma);
        Console.WriteLine("Emma supprimée de Mathématiques.");
        foreach (var course in courses)
        {
            Console.WriteLine($"Nom: {course.Name}, Crédits: {course.Credits}, Obligatoire: {course.IsMandatory}, Étudiants inscrits: {course.Students.Count}");
        }

        Console.WriteLine("\nExercice 8 - Afficher les étudiants de chaque cours");
        foreach (var course in courses)
        {
            Console.WriteLine($"Cours: {course.Name} (Crédits: {course.Credits}, Obligatoire: {course.IsMandatory})");
            Console.WriteLine($"Étudiants: {string.Join(", ", course.Students.Select(s => s.Name))}");
        }

        Console.WriteLine("\nExercice 9 - Cours obligatoires");
        var mandatoryCourses = courses.Where(c => c.IsMandatory);
        foreach (var course in mandatoryCourses)
        {
            Console.WriteLine(course.Name);
        }

        Console.WriteLine("\nExercice 10 - Étudiants boursiers");
        var scholarshipStudents = students.Where(s => s.IsScholarshipHolder);
        foreach (var student in scholarshipStudents)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine("\nExercice 11 - Étudiants avec moyenne > 15");
        var highAverageStudents = students.Where(s => s.Average > 15);
        foreach (var student in highAverageStudents)
        {
            Console.WriteLine($"{student.Name}: {student.Average}");
        }
    }
}

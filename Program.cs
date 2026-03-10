namespace projet1;

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
    }
}

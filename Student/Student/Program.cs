using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, and I am in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();

        Student student = new Student(name, age, grade);

        student.Greet();
        student.Introduce();
    }
}

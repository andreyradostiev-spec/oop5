using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Завдання 1
        Console.WriteLine("===== Рейтинг студента =====");
        Student st = new Student();
        st.SemesterRating();

        // Завдання 2
        Console.WriteLine("\n===== Факультет =====");

        Faculty f = new Faculty("Інформаційних технологій");

        Console.WriteLine("Факультет: " + f.FacultyName);

        f.dep1.SetDepartment("Програмних систем і технологій", 10);
        f.dep2.SetDepartment("Комп'ютерних наук", 8);

        f.dep1.PrintInfo();
        f.dep1.ShowSubjects();

        Console.WriteLine();

        f.dep2.PrintInfo();

        // Завдання 3
        Console.WriteLine("\n===== Partial class =====");

        Department d = new Department();

        d.SetName("Кафедра програмування");
        d.SetTeachers(12);

        d.ShowName();
        d.ShowTeachers();

        // Завдання 4
        Console.WriteLine("\n===== Static class =====");

        MyMath.PrimeNumbers();
        MyMath.RandomArray();
        MyMath.BinarySearchDemo();
    }
}
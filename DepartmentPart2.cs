using System;

partial class Department
{
    private int teachers;

    public void SetTeachers(int t)
    {
        teachers = t;
    }

    public void ShowTeachers()
    {
        Console.WriteLine("Викладачів: " + teachers);
    }
}
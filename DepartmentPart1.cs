using System;

partial class Department
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public void ShowName()
    {
        Console.WriteLine("Назва кафедри: " + name);
    }
}
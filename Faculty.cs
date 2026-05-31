using System;

class Faculty
{
    public string FacultyName;

    public Faculty(string name)
    {
        FacultyName = name;
    }

    public Department dep1 = new Department();
    public Department dep2 = new Department();

    public class Department
    {
        private string depName;
        private int teacherCount;

        private string[] subjects =
        {
            "Програмування",
            "ООП",
            "Бази даних",
            "Алгоритми",
            "Комп'ютерні мережі",
            "WEB",
            "Операційні системи",
            "Математика",
            "Фізика",
            "Інформатика",
            "Комп'ютерна графіка",
            "Інженерія ПЗ"
        };

        public void SetDepartment(string name, int teachers)
        {
            depName = name;
            teacherCount = teachers;
        }

        public void ShowSubjects()
        {
            Console.WriteLine("Дисципліни:");

            foreach (string s in subjects)
                Console.WriteLine(s);
        }

        public void ShowTeachersCount()
        {
            Console.WriteLine($"Кількість викладачів: {teacherCount}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Кафедра: {depName}");
            Console.WriteLine($"Нормативних дисциплін: {subjects.Length}");
            Console.WriteLine($"Викладачів: {teacherCount}");
        }
    }
}
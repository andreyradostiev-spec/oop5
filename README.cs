using System;

class Student
{
    // Вкладений клас
    public class St_Assesment
    {
        private int[] marks = new int[10];

        // Генерація оцінок від 56 до 100
        public void StRating()
        {
            Random rnd = new Random();

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = rnd.Next(56, 101);
            }
        }

        // Рейтинг за кредит
        public double MyRating()
        {
            int sum = 0;

            foreach (int x in marks)
                sum += x;

            return (double)sum / marks.Length;
        }

        public void Print()
        {
            foreach (int x in marks)
                Console.Write(x + " ");

            Console.WriteLine();
        }
    }

    // Два кредити
    St_Assesment strating1 = new St_Assesment();
    St_Assesment strating2 = new St_Assesment();

    public void SemesterRating()
    {
        strating1.StRating();
        strating2.StRating();

        Console.WriteLine("Кредит 1:");
        strating1.Print();
        double r1 = strating1.MyRating();

        Console.WriteLine("Кредит 2:");
        strating2.Print();
        double r2 = strating2.MyRating();

        Console.WriteLine($"Рейтинг за 1 кредит = {r1:F2}");
        Console.WriteLine($"Рейтинг за 2 кредит = {r2:F2}");

        double semester = (r1 + r2) / 2;

        Console.WriteLine($"Середній рейтинг за семестр = {semester:F2}");
    }
}
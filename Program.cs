int lessonNumber = 1;
int totalLessons = 5;
while (lessonNumber <= totalLessons)
{
    Console.WriteLine($"Пара {totalLessons}");
    totalLessons -=1;
}
Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной,для завершение введите -1:");
int grade = int.Parse(Console.ReadLine());
int score = 0;
while (grade != -1)
{
    Console.WriteLine($"Оценка принята:{grade}");
    score += 1;
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершен");
Console.WriteLine($"Количество введеных оценок: {score}");


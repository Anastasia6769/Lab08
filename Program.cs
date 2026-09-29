// int lessonNumber = 1;
// int totalLessons = 5;
// while (lessonNumber <= totalLessons)
// {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons -=1;
// }
// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной,для завершение введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int score = 0;
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята:{grade}");
//     score += 1;
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Ввод завершен");
// Console.WriteLine($"Количество введеных оценок: {score}");

int sum = 0;
int count = 0;

Console.WriteLine("Вводите оценки,для завершение введите -1:");
int grade = int.Parse(Console.ReadLine());
int max = 0;
while (grade != -1)
{
    sum += grade;
    count++;
    if (grade > max)
    {
        max = grade;
    }
    grade = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}
Console.WriteLine($"Максимальная оценка:{max}");


string correctPassword = "qwerty123";
int faileadAttepments = 0;
while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        Console.WriteLine($"Количество неудачных попыток :{faileadAttepments}");
        break;
    }
    Console.WriteLine("Неверный пароль,попробуйте снова");
    faileadAttepments++;
}

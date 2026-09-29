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

// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки,для завершение введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int max = 0;
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     if (grade > max)
//     {
//         max = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }
// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine($"Максимальная оценка:{max}");


// string correctPassword = "qwerty123";
// int faileadAttepments = 0;
// while (true)
// {
//     Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешен");
//         Console.WriteLine($"Количество неудачных попыток :{faileadAttepments}");
//         break;
//     }
//     Console.WriteLine("Неверный пароль,попробуйте снова");
//     faileadAttepments++;
// }

// string answer;

// do
// {
//     Console.Write("Введите дату посещения(например,01.09):");
//     string data = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {data}");

//     Console.Write("Добавить еще одну запись?(да/нет):");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");

//Самостоятельные задания
//Задача А
// int N = 7;

// Console.WriteLine($"Таблица умножение на {N}:");
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{N} * {i} = {N * i}");
// }
//Задача Б 
int count = 0;
Console.WriteLine("Вводите имена учеников (для завершение введите конец):");

while (true)
{
    string name = Console.ReadLine();

    if (name == "конец")
        break;

    count++;
}
Console.WriteLine($"Всего введено имен:{count}");

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 

// if (string.IsNullOrEmpty(surname)) { 
//     Console.WriteLine("Фамилия не введена. Завершение работы."); 
//     return; 
// } 

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 

// var assigned = Enumerable.Range(1, 10) 
//     .OrderBy(_ => rnd.Next()) 
//     .Take(2) 
//     .OrderBy(x => x) 
//     .ToList(); 

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 
//Индивидуальный вариант
//Вариант 2
// int sum = 0;
// Console.WriteLine("Введите целые числа (для завершение введите 0):");

// while (true)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number == 0)
//         break;

//     if (number > 0)
//         sum += number;
// }
// Console.WriteLine($"Сумма положительных чисел {sum}:");
//Вариант 3
int N = 10;
Console.WriteLine($"Таблица квадратов от 1 до {N}:");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} → {i * i}");
}
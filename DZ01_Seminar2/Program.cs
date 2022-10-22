Console.WriteLine("Введите номер дня недели от 1 до 7");
int DenNedeli = int.Parse(Console.ReadLine() ?? "0");
if (DenNedeli <= 7)
    switch (DenNedeli)
    {
        case 1:
            Console.WriteLine("Понедельник, снова на работу");
            break;
        case 2:
            Console.WriteLine("Вторник, всё еще работаем");
            break;
        case 3:
            Console.WriteLine("Среда, пол пути пройдено");
            break;
        case 4:
            Console.WriteLine("Четверг, подготовка к пятнице");
            break;
        case 5:
            Console.WriteLine("Пятница, ждем окончания дня и отдыхать");
            break;
        case 6:
            Console.WriteLine("Суббота, начинай отдыхать");
            break;
        case 7:
            Console.WriteLine("Воскресенье,отдохни и соберись с мыслями");
            break;
    }
else
{
    Console.WriteLine("Введен неправильный номер дня недели, напоминаю их 7");
}
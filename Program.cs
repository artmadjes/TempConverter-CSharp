Console.WriteLine("=== Конвертер температур ===");
Console.Write("Введите температуру в °C: ");
if (double.TryParse(Console.ReadLine(), out double celsius))
{
    double fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
}
else
{
    Console.WriteLine("Ошибка: введите корректное число.");
}
if (double.TryParse(Console.ReadLine(), out double celsius1))
{
    double kelvin = celsius1 * 9 / 5 + 32;
    Console.WriteLine($"{celsius}°C = {kelvin:F2}°K");
}
else
{
    Console.WriteLine("Ошибка: введите корректное число.");
}

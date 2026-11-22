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
double kelvin = celsius + 273.15;
Console.WriteLine($"{kelvin}°K = {celsius:F2}°C");
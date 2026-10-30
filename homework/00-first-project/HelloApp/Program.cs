// Русские буквы в терминале Windows.
Console.OutputEncoding = System.Text.Encoding.UTF8;

string name = "Егор Пивкин";
string group = "РПО-1";

Console.WriteLine($"Привет! Меня зовут {name}, группа {group}.");
Console.WriteLine($"Версия .NET: {Environment.Version}");
Console.WriteLine($"Система: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");

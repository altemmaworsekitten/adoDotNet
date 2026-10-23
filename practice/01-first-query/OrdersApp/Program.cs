// Использование ИИ: попросил Claude решить задание 4 (новые заказы с именем клиента).
// Из ответа взяты: запрос с JOIN orders и customers, счётчик строк и установка культуры ru-RU.

using System.Globalization;
using Npgsql;

// Русские буквы в терминале Windows.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Десятичная запятая в суммах (3290,00) на любой системной локали.
CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

// Куда подключаться: компьютер, порт, база, пользователь и пароль.
const string connectionString =
    "Host=localhost;Port=5433;Database=orders;Username=student;Password=student";

// 1. Источник данных: хранит настройки подключения и выдаёт соединения.
await using var dataSource = NpgsqlDataSource.Create(connectionString);

// 2. Соединение: открытый канал между программой и PostgreSQL.
await using var connection = await dataSource.OpenConnectionAsync();

// 3. Команда: новые заказы с именем клиента из таблицы customers.
await using var command = new NpgsqlCommand(
    """
    SELECT o.id, c.full_name, o.total
    FROM orders o
    JOIN customers c ON c.id = o.customer_id
    WHERE o.status = 'new'
    ORDER BY o.id
    """, connection);

// 4. Читатель: получает ответ базы по одной строке.
await using var reader = await command.ExecuteReaderAsync();

int count = 0;
while (await reader.ReadAsync())
{
    int id = reader.GetInt32(0);
    string customer = reader.GetString(1);
    decimal total = reader.GetDecimal(2);

    Console.WriteLine($"Заказ {id}: {customer}, {total} руб.");
    count++;
}

Console.WriteLine($"Новых заказов: {count}");

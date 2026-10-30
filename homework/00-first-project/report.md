# Отчёт по ДЗ 0. Первый проект на .NET

| | |
|---|---|
| Фамилия и имя | Пивкин Егор |
| Группа | РПО-1 |
| Система на компьютере | Linux (Arch Linux) |

## 1. Установка

Вывод `dotnet --list-sdks`:

```text
10.0.113 [/usr/share/dotnet/sdk]
```

Строка `Hello from Docker!` из вывода `docker run hello-world`:

```text
Hello from Docker!
```

## 2. HelloApp

Вывод первого запуска, до изменения `Program.cs`:

```text
Hello, World!
```

Вывод после замены программы:

```text
Привет! Меня зовут Егор Пивкин, группа РПО-1.
Версия .NET: 10.0.13
Система: Arch Linux
```

## 3. База заказов и OrdersApp

Вывод `docker compose ps`:

```text
NAME        IMAGE         COMMAND                  SERVICE   CREATED      STATUS      PORTS
orders-db   postgres:17   "docker-entrypoint.s…"   db        6 days ago   Up 6 days   0.0.0.0:5433->5432/tcp, [::]:5433->5432/tcp
```

Первые три строки вывода OrdersApp (заготовка до изменений практической работы 1):

```text
Заказ 1: shipped, 3380.00 руб.
Заказ 2: paid, 13990.00 руб.
Заказ 3: new, 3290.00 руб.
```

Сколько заказов напечатала программа: 12

## 4. Ошибки

Не было. Разделитель в суммах — точка, потому что в системе английская локаль.

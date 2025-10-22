using System;
using System.Collections.Generic;

namespace HW_Patterns_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n=== МЕНЮ: ПРОДВИНУТЫЕ ПАТТЕРНЫ ПОВЕДЕНИЯ ===");
                Console.WriteLine("1. Демо: 'Команда' (Продвинутый Умный дом)");
                Console.WriteLine("2. Демо: 'Шаблонный метод' (Генератор Отчетов)");
                Console.WriteLine("3. Демо: 'Посредник' (Чат с каналами)");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        RunCommandDemo();
                        break;
                    case "2":
                        RunTemplateDemo();
                        break;
                    case "3":
                        RunMediatorDemo();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }

                Console.WriteLine("\n... Нажмите Enter, чтобы вернуться в меню ...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void RunCommandDemo()
        {
            Console.WriteLine("--- Демо: 'Команда' (Продвинутый Умный дом) ---");

            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Гостиная");
            Television livingRoomTV = new Television();
            AirConditioner ac = new AirConditioner();

            // Назначаем команды на слоты
            remote.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remote.SetCommand(1, new TVOnCommand(livingRoomTV), new NoCommand()); 
            remote.SetCommand(2, new ACOnCommand(ac), new NoCommand()); 

            Console.WriteLine("--- Тест отдельных команд ---");
            remote.PressOnButton(0); 
            remote.PressOnButton(1);  
            remote.PressOffButton(0); 

            Console.WriteLine("\n--- Тест отмены ---");
            remote.PressUndoButton(); 
            remote.PressUndoButton();

            // --- Тест макрокоманды ---
            Console.WriteLine("\n--- Тест макрокоманды 'Вечеринка' ---");
            List<ICommand> partyCommands = new List<ICommand>
            {
                new LightOnCommand(livingRoomLight),
                new TVOnCommand(livingRoomTV),
                new ACOnCommand(ac)
            };
            MacroCommand partyOn = new MacroCommand(partyCommands);

            remote.SetCommand(6, partyOn, new NoCommand());
            remote.PressOnButton(6);

            Console.WriteLine("\n--- Отмена макрокоманды ---");
            remote.PressUndoButton();
        }

        static void RunTemplateDemo()
        {
            Console.WriteLine("--- Демо: 'Шаблонный метод' (Генератор Отчетов) ---");

            ReportGenerator pdf = new PdfReport();
            pdf.GenerateReport();

            ReportGenerator excel = new ExcelReport();
            excel.GenerateReport();

            ReportGenerator html = new HtmlReport();
            html.GenerateReport();
        }

        static void RunMediatorDemo()
        {
            Console.WriteLine("--- Демо: 'Посредник' (Чат с каналами) ---");

            IMediator mediator = new ChannelMediator();

            IUser user1 = new User("Алиса", mediator);
            IUser user2 = new User("Боб", mediator);
            IUser user3 = new User("Чарли", mediator);

            Console.WriteLine("\n--- Пользователи присоединяются к каналам ---");
            ((User)user1).JoinChannel("Общий");
            ((User)user2).JoinChannel("Общий");
            ((User)user3).JoinChannel("Разработка");
            ((User)user1).JoinChannel("Разработка");

            Console.WriteLine("\n--- Общение в канале 'Общий' ---");
            ((User)user1).Send("Общий", "Привет всем в общем чате!");

            Console.WriteLine("\n--- Общение в канале 'Разработка' ---");
            ((User)user3).Send("Разработка", "Кто-нибудь видел мой коммит?");
            ((User)user1).Send("Разработка", "Да, я видела, все отлично!");

            Console.WriteLine("\n--- Тест отправки в канал, где не состоишь ---");
            ((User)user2).Send("Разработка", "А я тут ничего не вижу...");
        }
    }
}
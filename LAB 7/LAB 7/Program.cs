using System;

namespace HW_Patterns_Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n=== ГЛАВНОЕ МЕНЮ (ДЗ по паттернам) ===");
                Console.WriteLine("1. Демо: Паттерн 'Команда' (Умный дом)");
                Console.WriteLine("2. Демо: Паттерн 'Шаблонный метод' (Напитки)");
                Console.WriteLine("3. Демо: Паттерн 'Посредник' (Чат)");
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
                        Console.WriteLine("Выход...");
                        return; 
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("\n... Нажмите Enter, чтобы вернуться в меню ...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // --- 'Команда' (по заданию) ---
        static void RunCommandDemo()
        {
            Console.WriteLine("--- Демо: 'Команда' (Умный дом) ---");

            Light livingRoomLight = new Light("Гостиания");
            Television tv = new Television();

            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            ICommand tvOn = new TelevisionOnCommand(tv);
            ICommand tvOff = new TelevisionOffCommand(tv);

            RemoteControl remote = new RemoteControl();

            remote.SetCommands(lightOn, lightOff);
            Console.WriteLine("\nУправление светом:");
            remote.PressOnButton();
            remote.PressOffButton();
            remote.PressUndoButton(); 

            remote.SetCommands(tvOn, tvOff);
            Console.WriteLine("\nУправление телевизором:");
            remote.PressOnButton();
            remote.PressOffButton();
        }

        // ---'Шаблонный метод' ---
        static void RunTemplateDemo()
        {
            Console.WriteLine("--- Демо: 'Шаблонный метод' (Напитки) ---");

            Beverage tea = new Tea();
            Console.WriteLine("\nПриготовление чая:");
            tea.PrepareRecipe();

            Console.WriteLine();

            Beverage coffee = new Coffee();
            Console.WriteLine("Приготовление кофе:");
            coffee.PrepareRecipe();
        }

        static void RunMediatorDemo()
        {
            Console.WriteLine("--- Демо: 'Посредник' (Чат) ---");

            ChatMediator chatMediator = new ChatMediator();

            User user1 = new User(chatMediator, "Алиса");
            User user2 = new User(chatMediator, "Боб");
            User user3 = new User(chatMediator, "Чарли");

            chatMediator.RegisterColleague(user1);
            chatMediator.RegisterColleague(user2);
            chatMediator.RegisterColleague(user3);

            user1.Send("Привет всем!");
            user2.Send("Привет, Алиса!");
            user3.Send("Всем привет!");
        }
    }
}
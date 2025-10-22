using System;
using System.Collections.Generic; // <-- Убедись, что все 'using' на месте
using System.Linq;
using System.Threading.Tasks;

namespace HW7_BehavioralPatterns
{
    class Program
    {
        // Теперь Main может быть обычным, а не async, т.к. мы не ждем
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n=== ДЗ 7: Паттерны Поведения ===");
                Console.WriteLine("1. Command (Умный дом)");
                Console.WriteLine("2. Template Method (Напитки)");
                Console.WriteLine("3. Mediator (Чат)");
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

                Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // Демо-метод для Команды
        static void RunCommandDemo()
        {
            Console.WriteLine("--- Демонстрация Command ---");
            Light livingRoomLight = new Light("Living Room");
            Door mainDoor = new Door();
            Thermostat thermostat = new Thermostat();
            TV mainTV = new TV();

            RemoteControl remote = new RemoteControl();

            remote.Submit(new LightOnCommand(livingRoomLight));
            remote.Submit(new DoorOpenCommand(mainDoor));
            remote.Submit(new ThermostatIncreaseCommand(thermostat));
            remote.Submit(new TVOnCommand(mainTV));

            Console.WriteLine("\n--- Отмена команд ---");
            remote.UndoLastCommand();
            remote.UndoLastCommand();
            remote.UndoLastCommand();
            remote.UndoLastCommand();
            remote.UndoLastCommand();
        }

        // Демо-метод для Шаблонного Метода
        static void RunTemplateDemo()
        {
            Console.WriteLine("--- Демонстрация Template Method ---");

            Console.WriteLine("\nPreparing Tea:");
            Beverage tea = new Tea();
            tea.PrepareBeverage();

            Console.WriteLine("\nPreparing Coffee:");
            Beverage coffee = new Coffee();
            coffee.PrepareBeverage();

            Console.WriteLine("\nPreparing Hot Chocolate (Доп. задание):");
            Beverage choco = new HotChocolate();
            choco.PrepareBeverage();
        }

        // Демо-метод для Посредника
        static void RunMediatorDemo()
        {
            Console.WriteLine("--- Демонстрация Mediator ---");

            IMediator chatRoom = new ChatRoom();

            User user1 = new User("Alice", chatRoom);
            User user2 = new User("Bob", chatRoom);
            User user3 = new User("Charlie", chatRoom);

            Console.WriteLine("\n--- Общий чат ---");
            user1.Send("Hello everyone!");
            user2.Send("Hi Alice!");

            Console.WriteLine("\n--- Личные сообщения (Доп. задание) ---");
            user3.SendPrivate("Alice", "Hey Alice, private message!");
            user1.SendPrivate("David", "Trying to text non-existent user");

            Console.WriteLine("\n--- Выход из чата (Доп. задание) ---");
            chatRoom.UnregisterUser(user2);
            user1.Send("Where did Bob go?");
        }
    }
}
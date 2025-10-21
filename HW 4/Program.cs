using System;
using System.Collections.Generic;

namespace TransportFactory
{
    public interface IVehicle
    {
        void Drive();
        void Refuel();
    }

    public class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }

        public Car(string brand, string model, string fuelType)
        {
            Brand = brand;
            Model = model;
            FuelType = fuelType;
            Console.WriteLine($"\n[СОЗДАН] Автомобиль: {Brand} {Model} (Топливо: {FuelType})");
        }

        public void Drive()
        {
            Console.WriteLine($"   -> Автомобиль {Brand} {Model} едет по дороге.");
        }

        public void Refuel()
        {
            Console.WriteLine($"   -> Заправляем автомобиль ({FuelType})... ");
        }
    }

    public class Motorcycle : IVehicle
    {
        public string MotorcycleType { get; set; }
        public int EngineVolume { get; set; }

        public Motorcycle(string type, int volume)
        {
            MotorcycleType = type;
            EngineVolume = volume;
            Console.WriteLine($"\n[СОЗДАН] Мотоцикл: {MotorcycleType}, {EngineVolume}cc");
        }

        public void Drive()
        {
            Console.WriteLine($"   -> Мотоцикл {MotorcycleType} мчится...");
        }

        public void Refuel()
        {
            Console.WriteLine("   -> Заправляем бак мотоцикла...");
        }
    }

    public class Truck : IVehicle
    {
        public double LoadCapacity { get; set; }
        public int Axles { get; set; }

        public Truck(double capacity, int axles)
        {
            LoadCapacity = capacity;
            Axles = axles;
            Console.WriteLine($"\n[СОЗДАН] Грузовик: {LoadCapacity}т, осей: {Axles}");
        }

        public void Drive()
        {
            Console.WriteLine($"   -> Грузовик ({Axles} оси) перевозит груз.");
        }

        public void Refuel()
        {
            Console.WriteLine("   -> Заправляем грузовик дизелем...");
        }
    }

    public class Bus : IVehicle
    {
        public int PassengerCapacity { get; set; }

        public Bus(int capacity)
        {
            PassengerCapacity = capacity;
            Console.WriteLine($"\n[СОЗДАН] Автобус: {PassengerCapacity} мест");
        }

        public void Drive()
        {
            Console.WriteLine($"   -> Автобус везет {PassengerCapacity} пассажиров по маршруту.");
        }

        public void Refuel()
        {
            Console.WriteLine("   -> Автобус заправляется на станции...");
        }
    }

    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }

    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("--- Создание автомобиля ---");
            Console.Write("  Введите марку: ");
            string brand = Console.ReadLine();

            Console.Write("  Введите модель: ");
            string model = Console.ReadLine();

            Console.Write("  Введите тип топлива: ");
            string fuel = Console.ReadLine();

            return new Car(brand, model, fuel);
        }
    }

    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("--- Создание мотоцикла ---");
            Console.Write("  Введите тип (Спортивный, Туристический): ");
            string type = Console.ReadLine();

            Console.Write("  Введите объем двигателя (cc): ");
            int volume = Convert.ToInt32(Console.ReadLine());

            return new Motorcycle(type, volume);
        }
    }

    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("--- Создание грузовика ---");
            Console.Write("  Введите грузоподъемность (в тоннах): ");
            double capacity = Convert.ToDouble(Console.ReadLine());

            Console.Write("  Введите количество осей: ");
            int axles = Convert.ToInt32(Console.ReadLine());

            return new Truck(capacity, axles);
        }
    }

    public class BusFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.WriteLine("--- Создание автобуса ---");
            Console.Write("  Введите вместимость пассажиров: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            return new Bus(capacity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система управления транспортом (Паттерн 'Фабричный Метод') ===");

            var factories = new Dictionary<string, VehicleFactory>
            {
                { "1", new CarFactory() },
                { "2", new MotorcycleFactory() },
                { "3", new TruckFactory() },
                { "4", new BusFactory() }
            };

            while (true)
            {
                Console.WriteLine("\n========================================================");
                Console.WriteLine("Какой транспорт вы хотите создать?");
                Console.WriteLine("  1: Автомобиль");
                Console.WriteLine("  2: Мотоцикл");
                Console.WriteLine("  3: Грузовик");
                Console.WriteLine("  4: Автобус (Расширение)");
                Console.WriteLine("  0: Выйти из программы");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }

                if (factories.TryGetValue(choice, out VehicleFactory factory))
                {
                    IVehicle vehicle = factory.CreateVehicle();
                    vehicle.Drive();
                    vehicle.Refuel();
                }
                else
                {
                    Console.WriteLine("\n[Ошибка] Неверный выбор. Пожалуйста, попробуйте снова.");
                }
            }

            Console.WriteLine("\n=== Программа завершена. Нажмите Enter для выхода. ===");
            Console.ReadLine();
        }
    }
}
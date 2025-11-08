using System;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {

            TV moyEkran = new TV();
            AudioSystem moyZvuk = new AudioSystem();
            DVDPlayer moyPleer = new DVDPlayer();
            GameConsole moyaKonsol = new GameConsole();

            HomeTheaterFacade domashniyKino = new HomeTheaterFacade(moyEkran, moyZvuk, moyPleer, moyaKonsol);

            domashniyKino.SmotretFilm("Дюна");
            domashniyKino.IgratVIdru("Starfield");
            domashniyKino.SlushatMuzyku();
            domashniyKino.NastroikaGromkosti(9);
            domashniyKino.VykluchitVse();

            Console.WriteLine("\n\n======= ДЕМОНСТРАЦИЯ ПАТТЕРНА КОМПОНОВЩИК =======");

            Papka koren = new Papka("Диск C:");
            Papka docs = new Papka("Документы");
            Papka photos = new Papka("Фотографии");
            Papka temp = new Papka("Временные файлы");

            Fail doc1 = new Fail("Отчет.docx", 150);
            Fail doc2 = new Fail("Резюме.pdf", 80);
            Fail photo1 = new Fail("Отпуск_01.jpg", 1200);
            Fail photo2 = new Fail("Схема.png", 300);
            Fail tempFile = new Fail("log.tmp", 10);

            docs.Dobavit(doc1);
            docs.Dobavit(doc2);

            photos.Dobavit(photo1);
            photos.Dobavit(photo2);

            temp.Dobavit(tempFile);

            koren.Dobavit(docs);
            koren.Dobavit(photos);
            koren.Dobavit(temp);
            koren.Dobavit(new Fail("system.dll", 500));

            Console.WriteLine("--- Структура файловой системы ---");
            koren.Display(0);

            Console.WriteLine("\n--- Расчет размеров ---");
            Console.WriteLine($"Размер папки 'Документы': {docs.GetSize()} KB");
            Console.WriteLine($"Общий размер 'Диск C:': {koren.GetSize()} KB");
        }
    }
}
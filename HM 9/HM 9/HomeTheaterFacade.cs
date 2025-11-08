using System;

namespace DesignPatterns
{
    public class HomeTheaterFacade
    {
        private readonly TV _ekran;
        private readonly AudioSystem _zvuk;
        private readonly DVDPlayer _pleer;
        private readonly GameConsole _konsol;

        public HomeTheaterFacade(TV ekran, AudioSystem zvuk, DVDPlayer pleer, GameConsole konsol)
        {
            _ekran = ekran;
            _zvuk = zvuk;
            _pleer = pleer;
            _konsol = konsol;
        }

        public void SmotretFilm(string film)
        {
            Console.WriteLine("\n--- Подготовка к просмотру фильма ---");
            _ekran.Vkluchit();
            _ekran.UstanovitVhod("DVD");
            _zvuk.Vkluchit();
            _zvuk.UstanovitGromkost(7);
            _pleer.Vkluchit();
            _pleer.Vosproizvesti(film);
        }

        public void IgratVIdru(string igra)
        {
            Console.WriteLine("\n--- Подготовка к запуску игры ---");
            _ekran.Vkluchit();
            _ekran.UstanovitVhod("HDMI 1");
            _zvuk.Vkluchit();
            _zvuk.UstanovitGromkost(5);
            _konsol.Vkluchit();
            _konsol.ZapustitIgru(igra);
        }

        public void SlushatMuzyku()
        {
            Console.WriteLine("\n--- Включение режима музыки ---");
            _ekran.Vkluchit();
            _ekran.UstanovitVhod("Audio");
            _zvuk.Vkluchit();
            _zvuk.UstanovitGromkost(6);
        }

        public void NastroikaGromkosti(int uroven)
        {
            Console.WriteLine($"\n--- Регулировка громкости ---");
            _zvuk.UstanovitGromkost(uroven);
        }

        public void VykluchitVse()
        {
            Console.WriteLine("\n--- Выключение всей системы ---");
            _pleer.Ostanovit();
            _pleer.Vykluchit();
            _konsol.Vykluchit();
            _zvuk.Vykluchit();
            _ekran.Vykluchit();
        }
    }
}
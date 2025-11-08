using System;

namespace DesignPatterns
{
    public class Fail : FileSystemComponent
    {
        private int razmer;

        public Fail(string nazvanie, int razmer) : base(nazvanie)
        {
            this.razmer = razmer;
        }

        public override void Display(int otstup)
        {
            Console.WriteLine($"{new string(' ', otstup)}Файл: {nazvanie} (Размер: {razmer} KB)");
        }

        public override int GetSize()
        {
            return razmer;
        }
    }
}
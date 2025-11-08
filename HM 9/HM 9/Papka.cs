using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Papka : FileSystemComponent
    {
        private List<FileSystemComponent> soderzhimoe = new List<FileSystemComponent>();

        public Papka(string nazvanie) : base(nazvanie) { }

        public void Dobavit(FileSystemComponent komponent)
        {
            if (!soderzhimoe.Contains(komponent))
            {
                soderzhimoe.Add(komponent);
            }
        }

        public void Udalit(FileSystemComponent komponent)
        {
            soderzhimoe.Remove(komponent);
        }

        public override void Display(int otstup)
        {
            Console.WriteLine($"{new string(' ', otstup)}Папка: {nazvanie}");
            foreach (var komponent in soderzhimoe)
            {
                komponent.Display(otstup + 2);
            }
        }

        public override int GetSize()
        {
            int totalSize = 0;
            foreach (var komponent in soderzhimoe)
            {
                totalSize += komponent.GetSize();
            }
            return totalSize;
        }
    }
}
using System;

namespace DesignPatterns
{
    public abstract class FileSystemComponent
    {
        protected string nazvanie;

        public FileSystemComponent(string nazvanie)
        {
            this.nazvanie = nazvanie;
        }

        public abstract void Display(int otstup);
        public abstract int GetSize();
    }
}
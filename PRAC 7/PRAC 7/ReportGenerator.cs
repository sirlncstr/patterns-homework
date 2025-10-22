using System;

namespace HW_Patterns_Advanced
{
    public abstract class ReportGenerator
    {
        // Это "Шаблонный метод"
        public void GenerateReport()
        {
            Console.WriteLine($"\n--- Генерация {GetReportType()} отчета ---");
            CollectData();
            FormatData();
            GenerateHeader();
            GenerateBody();
            GenerateFooter();

            if (CustomerWantsSave())
            {
                SaveReport();
            }
            Console.WriteLine("--- Генерация завершена ---");
        }

        // Общий шаг
        private void CollectData()
        {
            Console.WriteLine("1. Сбор данных из базы...");
        }

        protected abstract string GetReportType();
        protected abstract void FormatData();
        protected abstract void GenerateHeader();
        protected abstract void GenerateBody();
        protected abstract void GenerateFooter();
        protected abstract void SaveReport();

        protected virtual bool CustomerWantsSave()
        {
            return false; 
        }
    }
}

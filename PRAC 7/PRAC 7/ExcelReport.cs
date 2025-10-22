using System;

namespace HW_Patterns_Advanced
{
    public class ExcelReport : ReportGenerator
    {
        protected override string GetReportType() => "Excel";
        protected override void FormatData() => Console.WriteLine("2. Форматирование данных для Excel.");
        protected override void GenerateHeader() => Console.WriteLine("3. Генерация заголовков столбцов в Excel.");
        protected override void GenerateBody() => Console.WriteLine("4. Заполнение ячеек данными.");
        protected override void GenerateFooter() => Console.WriteLine("5. Подсчет итогов в Excel.");
        protected override void SaveReport() => Console.WriteLine("6. Сохранение отчета в report.xlsx...");

        protected override bool CustomerWantsSave()
        {
            Console.Write("Сохранить Excel-отчет в файл? (y/n): ");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith("y");
        }
    }
}
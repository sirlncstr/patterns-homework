using System;

namespace HW_Patterns_Advanced
{
    public class HtmlReport : ReportGenerator
    {
        protected override string GetReportType() => "HTML";
        protected override void FormatData() => Console.WriteLine("2. Форматирование данных для HTML.");
        protected override void GenerateHeader() => Console.WriteLine("3. Генерация тега <header>.");
        protected override void GenerateBody() => Console.WriteLine("4. Генерация таблицы <table> с данными.");
        protected override void GenerateFooter() => Console.WriteLine("5. Генерация тега <footer>.");
        protected override void SaveReport() { /* HTML-отчеты не сохраняются */ }
    }
}
using System;

namespace HW_Patterns_Advanced
{
    public class PdfReport : ReportGenerator
    {
        protected override string GetReportType() => "PDF";
        protected override void FormatData() => Console.WriteLine("2. Форматирование данных для PDF.");
        protected override void GenerateHeader() => Console.WriteLine("3. Генерация PDF-заголовка.");
        protected override void GenerateBody() => Console.WriteLine("4. Генерация тела отчета в PDF-формате.");
        protected override void GenerateFooter() => Console.WriteLine("5. Генерация PDF-подвала.");
        protected override void SaveReport() => Console.WriteLine("6. Сохранение отчета в report.pdf...");

        // PDF всегда сохраняется
        protected override bool CustomerWantsSave() => true;
    }
}
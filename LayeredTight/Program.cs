namespace LayeredTight
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            var reportController = new ReportController();

            Console.WriteLine("Введите идентификатор");
            var id = Console.ReadLine();
            reportController.Delete(int.Parse(id));
            Console.WriteLine($"Отчет номер {id} удален");
        }
    }
}
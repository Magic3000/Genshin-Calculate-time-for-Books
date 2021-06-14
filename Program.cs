using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genshin_Calculate_time_for_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книжек (фиолетовые): ");
            var books = int.Parse(Console.ReadLine());
            int oneTake = 320;
            var bestMinutes = books / 10 * oneTake;
            var worstMinutes = books / 8 * oneTake;
            TimeSpan bestTS = new TimeSpan(0, bestMinutes, 0);
            TimeSpan worstTS = new TimeSpan(0, worstMinutes, 0);
            var best = $"{bestMinutes} минут(-ы) / {string.Format("{0:0.#}", bestTS.TotalHours)} час(-ов) / {string.Format("{0:0}", bestTS.TotalDays)} дня(-ей) {string.Format("{0:0.#}", (double.Parse($"0.{bestTS.TotalDays.ToString().Split('.')[1]}")) * 24)} час(-ов)";
            var worst = $"{worstMinutes} минут(-ы) / {string.Format("{0:0.#}", worstTS.TotalHours)} час(-ов) / {string.Format("{0:0}", worstTS.TotalDays)} дня(-ей) {string.Format("{0:0.#}", (double.Parse($"0.{worstTS.TotalDays.ToString().Split('.')[1]}")) * 24)} час(-ов)";
            Console.WriteLine($"Интервал:\nЛучший (5 книжек за 20 смолы/10 за 1 густую): {best}\nХудший (4 книжки за 20 смолы/8 за 1 густую): {worst}");
            Console.WriteLine("Hit Enter to exit..");
            Console.ReadKey();
        }
    }
}

using System.Text;

namespace Module17_Patterns_P1;

internal class Program
{
    static void Main(string[] args)
    {
        RegularAccount user = new RegularAccount(900); // создаём и тестируем несколько аккаунтов с разными параметрами
        RegularAccount user2 = new RegularAccount(1200);
        SalaryAccount user3 = new SalaryAccount(1300);

        user.CalculateInterest(); // у каждого аккаутна теперь есть метод для подсчёта процента по вкладам
        user2.CalculateInterest();
        user3.CalculateInterest();

        Console.WriteLine($"{user.Type} - {user.Balance} - {user.Interest}");
        Console.WriteLine($"{user2.Type} - {user2.Balance} - {user2.Interest}");
        Console.WriteLine($"{user3.Type} - {user3.Balance} - {user3.Interest}");
    }
}

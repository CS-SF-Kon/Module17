using System.Text;

namespace Module17_Patterns_P1;

internal class Program
{
    static void Main(string[] args)
    {
        Account user = new Account()
        {
            Type = "Обычный",
            Balance = 900
        };

        Account user2 = new Account()
        {
            Type = "Зарплатный",
            Balance = 1500
        };

        Account user3 = new Account()
        {
            Type = "Обычный",
            Balance = 1200
        };

        Calculator.CalculateInterest(user);
        Calculator.CalculateInterest(user2);
        Calculator.CalculateInterest(user3);
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"{user.Interest} - {user2.Interest} - {user3.Interest}");
    }
}

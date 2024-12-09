using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Patterns_P1;

public class RegularAccount : IAccount
{
    // тип учетной записи
    public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }

    public RegularAccount(double balance)
    {
        Type = "Обычный";
        this.Balance = balance;
        Interest = 0;
    }

    public void CalculateInterest()
    {
        if (Balance < 1000)
            Interest = Balance * 0.2;

        if (Balance >= 1000)
            Interest = 0;
    }
}

public class SalaryAccount : IAccount
{
    public string Type { get; set; }

    public double Balance { get; set; }

    public double Interest { get; set; }

    public SalaryAccount(double balance)
    {
        Type = "Зарплатный";
        this.Balance = balance;
        Interest = 0;
    }

    public void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}

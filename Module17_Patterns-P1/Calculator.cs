using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Patterns_P1;

public class Calculator // Благодаря интерфейсу в аккаунтах нужда в классе Calculator в принципе пропала, получается?
{
    // Метод для расчета процентной ставки
    //public static void CalculateInterest(IAccount account)
    //{
    //    if (account.Type == "Обычный")
    //    {
    //        // расчет процентной ставки обычного аккаунта по правилам банка
    //        account.Interest = account.Balance * 0.4;

    //        if (account.Balance < 1000)
    //            account.Interest -= account.Balance * 0.2;

    //        if (account.Balance >= 1000)
    //            account.Interest -= account.Balance * 0.4;
    //    }
    //    else if (account.Type == "Зарплатный")
    //    {
    //        // расчет процентной ставки зарплатного аккаунта по правилам банка
    //        account.Interest = account.Balance * 0.5;
    //    }
    //}
}

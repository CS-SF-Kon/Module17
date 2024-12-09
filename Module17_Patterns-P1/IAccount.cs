using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Patterns_P1;

/// <summary>
/// Интерфейс, наследуемый классами аккаунтов и обязующий реализовывать подсчёт процента по вкладу
/// </summary>
public interface IAccount
{
    void CalculateInterest();
}

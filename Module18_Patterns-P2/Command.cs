using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_Patterns_P2;

/// <summary>
/// Абстрактрый класс для команд
/// </summary>
internal abstract class Command
{
    public abstract Task ARun(string URL);
}

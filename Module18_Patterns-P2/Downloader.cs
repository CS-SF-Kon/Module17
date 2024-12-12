using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_Patterns_P2;

/// <summary>
/// Класс загрузчика
/// </summary>
internal class Downloader
{
    Command _command;

    public void SetCommand(Command command)
    {
        _command = command;
    }

    public async Task RunAsync(string URL)
    {
        await _command.ARun(URL);
    }
}

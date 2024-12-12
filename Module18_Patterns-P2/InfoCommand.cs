using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18_Patterns_P2;

/// <summary>
/// Команда для просмотра информации
/// </summary>
internal class InfoCommand : Command
{
    YoutubeClient _YTClient;

    public InfoCommand(YoutubeClient yTClient)
    {
        _YTClient = yTClient;
    }

    /// <summary>
    /// Реализация просмотра информации
    /// </summary>
    /// <param name="URL"></param>
    /// <returns></returns>
    public override async Task ARun (string URL)
    {
        var info = await _YTClient.Videos.GetAsync(URL);
        Console.WriteLine(info.Title);
        Console.WriteLine(info.Author);
        Console.WriteLine(info.Description);
        Console.WriteLine(info.Duration);
    }
}

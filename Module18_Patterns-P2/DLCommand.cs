using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18_Patterns_P2;

/// <summary>
/// Команда для загрузки
/// </summary>
internal class DLCommand : Command
{
    YoutubeClient _YTclient;

    public DLCommand(YoutubeClient yTclient)
    {
        _YTclient = yTclient;
    }

    /// <summary>
    /// Реализация загрузки
    /// </summary>
    /// <param name="URL"></param>
    /// <returns></returns>
    public override async Task ARun(string URL)
    {
        await _YTclient.Videos.DownloadAsync(URL, "D:\\someVideo.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast)); // хотел в корень "C:\", но ругается UnauthorizedAccessException. Не помню, как решил это в 8 модуле
    }
}

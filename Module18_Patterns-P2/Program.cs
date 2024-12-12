using YoutubeExplode; // этот пакет заставил меня немножечко побыть ЭkСреMuсТoM

namespace Module18_Patterns_P2;

internal class Program
{
    static async Task Main(string[] args)
    {
        var downloader = new Downloader(); // отправитель
        var reciever = new YoutubeClient(); // получатель

        var infoCommand = new InfoCommand(reciever); // команда получения информации
        var dlCommand = new DLCommand(reciever); // команда загрузки

        downloader.SetCommand(infoCommand); 
        await downloader.RunAsync(args[0]); // оставил возможность проверить работоспособность через параметры запуска экзешника

        downloader.SetCommand(dlCommand);
        await downloader.RunAsync(args[0]);

    }
}

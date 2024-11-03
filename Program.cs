using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DateTimeChecker.xunit")]
namespace DateTimeChecker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }
    }
}
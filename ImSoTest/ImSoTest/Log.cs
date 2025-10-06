using System.Runtime.CompilerServices;
using System.Text;

namespace ImSoTest
{
    public static class Log
    {
        public static string nombreClase = "";
        public static void WriteLine(String Texto, [CallerMemberName] string caller = "")
        {
            try
            {
                if (!Directory.Exists("C:\\ImSoTest"))
                {
                    DirectoryInfo di = Directory.CreateDirectory("C:\\ImSoTest");
                }
                DirectoryInfo dir = new DirectoryInfo("C:\\ImSoTest");
                dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                StreamWriter sw = new StreamWriter("C:\\ImSoTest\\Log_" + nombreClase + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log", true, Encoding.UTF8);
                sw.WriteLine("[" + DateTime.Now.ToString() + "] - " + caller + " : " + Texto);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ERROR AL ESCRIBIR EN LOG");
                Console.WriteLine(" Exception: " + e.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}

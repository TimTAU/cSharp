using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace C_Await
{
    class C_Await
    {
        static void Main(string[] args)
        {
            WriteInfo("Main - start cases...");
            //case_1();
            //case_2();
            case_3();

            WriteInfo("Main - wait a little bit for cases...");
            Thread.Sleep(6000);
            WriteInfo("Main - end");
        }

        static string Download()
        {
            WriteInfo("    Download - begin ... 3s");
            Thread.Sleep(3000);
            WriteInfo("    Download - end");
            return "<head></head>";
        }

        #region synchrone Beispiele, warten auf Download

        static void case_1()
        {
            case_1a();
            case_1b();
        }

        static void case_1a()
        {
            WriteInfo("  case 1a - start download");
            string page = Download();
            WriteInfo("  case 1a - download done, page=" + page);
        }

        static void case_1b()
        {
            WriteInfo("  case 1b - start download ");
            Task<string> task1 = Task<string>.Factory.StartNew(() => Download());
            WriteInfo("  case 1b - tasks startet");
            string page = task1.Result;
            WriteInfo("  case 1b - download done, page=" + page);
        }

        #endregion

        #region asynchrone Beispiele, Funktionen kommen direkt zurück

        // async only enables keyword await

        static async void case_2()
        {
            WriteInfo("  case 2 - start download");
            string page = await DownloadAsync(); // leaves!
            WriteInfo("  case 2 - download done, page=" + page);
        }

        // nur mgl: void, Task, Task<T>
        static async Task<string> DownloadAsync()
        {
            WriteInfo("    DownloadAsync - begin ... 3s");
            Task<string> task1 = Task<string>.Factory.StartNew(() => Download());
            string page = await task1;
            WriteInfo("    DownloadAsync - end");
            return page;
            // nur mgl (s.o.): return, return, return T
        }
        // alternativ zu task1: await Task.Delay(3000);

        static async void case_3()
        {
            WriteInfo("  case 3 - call f");
            int result = await f(); // leaves!
            WriteInfo("  case 3 - call f done");
        }

        static async Task<int> f()
        {
            WriteInfo("    f - begin");
            //int result = await g() + await h();
            int result = (await Task.WhenAll(g(), h()).ConfigureAwait(false)).Sum();
            WriteInfo("    f - end, result=" + result);
            return result;
        }

        static async Task<int> g()
        {
            WriteInfo("    g - begin ... 2s");
            await Task.Delay(2000);
            WriteInfo("    g - end");
            return 1;
        }

        static async Task<int> h()
        {
            WriteInfo("    h - begin ... 2s");
            await Task.Delay(2000);
            WriteInfo("    h - end");
            return 2;
        }

        #endregion

        public static void WriteInfo(string s)
        {
            string id = String.Format("{0,3:000}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("{0} |      thread '{1}' - {2}", DateTime.Now, id.Substring(id.Length - 3, 3), s);
        }
    }
}
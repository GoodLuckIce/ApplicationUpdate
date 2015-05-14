using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IceCommon;

namespace GitHubUpdatePackage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationUpdate.PackageUpdateFile(@"D:\Git\ApplicationUpdate\TlbbAide");
            ApplicationUpdate.PackageUpdateFile(@"D:\Git\ApplicationUpdate\UpdateIce");
        }
    }
}

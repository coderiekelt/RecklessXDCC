using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reckless.Sdk.Services;

namespace Reckless.Sdk
{
    public static class Context
    {
        public static StorageService StorageService;

        public static IrcService IrcService;

        public static string DownloadDirectory;

        public static void Initialize()
        {
            StorageService = new StorageService();
            IrcService = new IrcService();

            DownloadDirectory = StorageService.DownloadDirectory;
        }
    }
}

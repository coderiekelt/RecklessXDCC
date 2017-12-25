using System;
using System.IO;

namespace Reckless.Sdk.Services
{
    public class StorageService
    {
        public string WorkingDirectory;

        public string DownloadDirectory;

        public StorageService()
        {
            this.PrepareWorkingDirectory();
            this.PrepareDownloadDirectory();
        }

        private void PrepareWorkingDirectory()
        {
            this.WorkingDirectory = "%AppData%//Reckless";
            this.WorkingDirectory = Environment.ExpandEnvironmentVariables(this.WorkingDirectory);

            this.CreateDirectoryIfNotExists(this.WorkingDirectory);
        }

        private void PrepareDownloadDirectory()
        {
            this.DownloadDirectory = String.Format("{0}//Downloads", this.WorkingDirectory);

            this.CreateDirectoryIfNotExists(this.DownloadDirectory);
        }

        private void CreateDirectoryIfNotExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}

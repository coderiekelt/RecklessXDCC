using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Reckless.Client.Models;
using Newtonsoft.Json;

namespace Reckless.Client
{
    public static class Utilities
    {
        public static ServerCollection ServerCollection;

        public static DownloadQueue DownloadQueue;

        public static void SaveServerCollection()
        {
            string fileDirectory = Reckless.Sdk.Context.StorageService.WorkingDirectory;
            string fileName = "servers.json";

            string filePath = String.Format("{0}//{1}", fileDirectory, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            StreamWriter fileStream = File.CreateText(filePath);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(fileStream, ServerCollection);

            fileStream.Close();
        }

        public static void LoadServerCollection()
        {
            string fileDirectory = Reckless.Sdk.Context.StorageService.WorkingDirectory;
            string fileName = "servers.json";

            string filePath = String.Format("{0}//{1}", fileDirectory, fileName);

            if (!File.Exists(filePath))
            {
                ServerCollection = new ServerCollection();
                SaveServerCollection();

                return;
            }

            ServerCollection = JsonConvert.DeserializeObject<ServerCollection>(File.ReadAllText(filePath));

            if (ServerCollection == null)
            {
                ServerCollection = new ServerCollection();
            }
        }

        public static void InvokeIfRequired(this ISynchronizeInvoke obj, MethodInvoker action)
        {
            if (obj.InvokeRequired)
            {
                var args = new object[0];
                obj.Invoke(action, args);
            }
            else
            {
                action();
            }
        }
    }
}

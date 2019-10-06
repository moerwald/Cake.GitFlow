namespace Cake.GitFlow.Release.Workflow
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using Newtonsoft.Json;

    public class FetchVersion : IFetchNextVersion
    {
        public string GetNextVersion()
        {


            var process = new Process {
                StartInfo = new ProcessStartInfo{
                    FileName = "GitVersion.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                }
            };

            var sb = new StringBuilder();
            process.Start();
            while (process.StandardOutput.EndOfStream == false)
            {
                sb.Append(process.StandardOutput.ReadLine());
            }

            var version = JsonConvert.DeserializeObject<dynamic>(sb.ToString());
            return version.Version as string;
        }
    }
}
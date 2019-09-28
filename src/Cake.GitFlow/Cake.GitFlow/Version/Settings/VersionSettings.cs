

namespace Cake.GitFlow.Version.Settings
{
    using Cake.Core;
    using Cake.Core.IO;
    
    public class VersionSettings : GitFlowRunnerSettings
    {
        public bool Version { get; set; }

        internal override void Evaluate(ProcessArgumentBuilder args)
        {
            if (Version == true)
            {
                args.Append("--version");
            }
        }
    }
}


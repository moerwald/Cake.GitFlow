namespace Cake.GitFlow
{
    using System;
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Core.Tooling;

    /// <summary>
    /// Contains settings that can be defined in cake scripts.
    /// </summary>
    public class GitFlowRunnerSettings : ToolSettings
    {
        public bool Version { get; set; }
        /// <summary>
        /// Check property states of this class and appends appropriate
        /// cmd line arguments to the <paramref name="args"/> parameter.
        /// </summary>
        /// <param name="args"></param>
        internal void Evaluate(ProcessArgumentBuilder args)
        {
            if (Version)
            {
                args.Append("--version");
            }
        }
    }
}

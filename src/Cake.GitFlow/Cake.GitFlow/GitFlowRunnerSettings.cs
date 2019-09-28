namespace Cake.GitFlow
{
    using Cake.Core.IO;
    using Cake.Core.Tooling;

    /// <summary>
    /// Contains settings that can be defined in cake scripts.
    /// </summary>
    public class GitFlowRunnerSettings : ToolSettings
    {
        /// <summary>
        /// Check property states of this class and appends appropriate
        /// cmd line arguments to the <paramref name="args"/> parameter.
        /// </summary>
        /// <param name="args"></param>
        internal virtual void Evaluate(ProcessArgumentBuilder args){}
    }
}
